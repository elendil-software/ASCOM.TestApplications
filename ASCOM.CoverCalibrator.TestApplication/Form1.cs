using System;
using System.Reflection;
using System.Windows.Forms;
using ASCOM.DeviceInterface;

namespace ASCOM.CoverCalibrator.TestApplication
{
    public partial class Form1 : Form
    {

        private DriverAccess.CoverCalibrator _driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
            {
                _driver.Connected = false;
            }

            stateTimer?.Dispose();

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = DriverAccess.CoverCalibrator.Choose(Properties.Settings.Default.DriverId);
            labelDriverId.Text = Properties.Settings.Default.DriverId;
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                _driver.Connected = false;
            }
            else
            {
                _driver = new DriverAccess.CoverCalibrator(Properties.Settings.Default.DriverId)
                {
                    Connected = true
                };
                
                StartTimer();
            }
            SetUIState();
        }
        
        public void CheckStatus(Object stateInfo)
        {
            try
            {
                SetControlPropertyThreadSafe(textBoxCalibratorState, "Text", _driver.CalibratorState.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), control, propertyName,
                    propertyValue);
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new[] {propertyValue});
            }
        }
        
        private System.Threading.Timer stateTimer;
        
        private void StartTimer()
        {
            stateTimer = new System.Threading.Timer(CheckStatus, null, 1000, 1000);
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected => ((_driver != null) && _driver.Connected);

        private void checkBoxLightOnOff_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLightOnOff.Checked)
                {
                    int maxBrightness = _driver.MaxBrightness;
                    _driver.CalibratorOn(maxBrightness);
                    checkBoxLightOnOff.Text = "Light Off";
                }
                else
                {
                    _driver.CalibratorOff();
                    checkBoxLightOnOff.Text = "Light On";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

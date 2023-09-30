using System;
using System.Reflection;
using System.Windows.Forms;

namespace ASCOM.Focuser.TestApplication
{
    public partial class Form1 : Form
    {

        private DriverAccess.Focuser _driver;

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

            Focuser.TestApplication.Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Focuser.TestApplication.Properties.Settings.Default.DriverId = DriverAccess.Focuser.Choose(Focuser.TestApplication.Properties.Settings.Default.DriverId);
            labelDriverId.Text = Focuser.TestApplication.Properties.Settings.Default.DriverId;
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
                _driver = new DriverAccess.Focuser(Focuser.TestApplication.Properties.Settings.Default.DriverId)
                {
                    Connected = true
                };
                
                labelNameValue.Text = _driver.Name;
                labelDescriptionValue.Text = _driver.Description;
                labelDriverInfoValue.Text = _driver.DriverInfo;
                StartTimer();
            }
            SetUIState();
        }
        
        private void CheckStatus(Object stateInfo)
        {
            try
            {
                SetControlPropertyThreadSafe(textBoxIsMoving, "Text", _driver.IsMoving.ToString());
                SetControlPropertyThreadSafe(textBoxCurrentPosition, "Text", _driver.Position.ToString());
                SetControlPropertyThreadSafe(textBoxMaxStep, "Text", _driver.MaxStep.ToString());
                SetControlPropertyThreadSafe(textBoxIncrement, "Text", _driver.MaxIncrement.ToString());
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
            buttonConnect.Enabled = !string.IsNullOrEmpty(Focuser.TestApplication.Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected => ((_driver != null) && _driver.Connected);
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                _driver.Halt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            try 
            {
                _driver.Move(int.Parse(textBoxPosition.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

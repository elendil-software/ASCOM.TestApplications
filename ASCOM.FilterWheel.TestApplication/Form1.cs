using System;
using System.Reflection;
using System.Windows.Forms;

namespace ASCOM.FilterWheel.TestApplication
{
    public partial class Form1 : Form
    {

        private DriverAccess.FilterWheel _driver;
        private System.Threading.Timer _stateTimer;

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

            _stateTimer?.Dispose();

            FilterWheel.TestApplication.Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            FilterWheel.TestApplication.Properties.Settings.Default.DriverId = DriverAccess.FilterWheel.Choose(FilterWheel.TestApplication.Properties.Settings.Default.DriverId);
            labelDriverId.Text = FilterWheel.TestApplication.Properties.Settings.Default.DriverId;
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                _stateTimer?.Dispose();
                _driver.Connected = false;
            }
            else
            {
                _driver = new DriverAccess.FilterWheel(FilterWheel.TestApplication.Properties.Settings.Default.DriverId)
                {
                    Connected = true
                };
                
                labelNameValue.Text = _driver.Name;
                labelDescriptionValue.Text = _driver.Description;
                labelDriverInfoValue.Text = _driver.DriverInfo;
                comboBoxFilters.Items.Clear();
                string[] filters = _driver.Names;
                foreach (string filter in filters)
                {
                    comboBoxFilters.Items.Add(filter);
                }
                StartTimer();
            }
            SetUIState();
        }
        
        private void CheckStatus(Object stateInfo)
        {
            try
            {
                SetControlPropertyThreadSafe(textBoxCurrentPosition, "Text", _driver.Position.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        private static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
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
        
        private void StartTimer()
        {
            _stateTimer = new System.Threading.Timer(CheckStatus, null, 1000, 1000);
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(FilterWheel.TestApplication.Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected => ((_driver != null) && _driver.Connected);
        
        private void buttonMove_Click(object sender, EventArgs e)
        {
            try 
            {
                _driver.Position = (short)comboBoxFilters.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}

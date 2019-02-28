using System;
using System.Windows.Forms;

namespace ASCOM.SafetyMonitor.TestApplication
{
    public partial class Form1 : Form
    {

        private DriverAccess.SafetyMonitor _driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                _driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = DriverAccess.SafetyMonitor.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                _driver.Connected = false;
                readButton.Enabled = false;
            }
            else
            {
                _driver = new DriverAccess.SafetyMonitor(Properties.Settings.Default.DriverId)
                {
                    Connected = true
                };
                readButton.Enabled = true;
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected => ((_driver != null) && _driver.Connected);

        private void readButton_Click(object sender, EventArgs e)
        {
            isSafeValue.Text = _driver.IsSafe.ToString();
        }
    }
}

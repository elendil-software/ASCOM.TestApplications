using System;
using System.Globalization;
using System.Windows.Forms;

namespace ASCOM.ObservingConditions.TestApplication
{
    public partial class Form1 : Form
    {

        private ASCOM.DriverAccess.ObservingConditions driver;

        public Form1()
        {
            InitializeComponent();
            SetUIState();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsConnected)
                driver.Connected = false;

            Properties.Settings.Default.Save();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DriverId = ASCOM.DriverAccess.ObservingConditions.Choose(Properties.Settings.Default.DriverId);
            SetUIState();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                driver.Connected = false;
                GetDataButton.Enabled = false;

            }
            else
            {
                try
                {
                    driver = new ASCOM.DriverAccess.ObservingConditions(Properties.Settings.Default.DriverId);
                    driver.Connected = true;
                    GetDataButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            SetUIState();
        }

        private void SetUIState()
        {
            buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
            buttonChoose.Enabled = !IsConnected;
            buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
        }

        private bool IsConnected
        {
            get
            {
                return ((this.driver != null) && (driver.Connected == true));
            }
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            try
            { 
                TemperatureValue.Text = driver.Temperature.ToString(CultureInfo.InvariantCulture);
                PressureValue.Text = driver.Pressure.ToString(CultureInfo.InvariantCulture);
                HumidityValue.Text = driver.Humidity.ToString(CultureInfo.InvariantCulture);
                DewPointValue.Text = driver.DewPoint.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

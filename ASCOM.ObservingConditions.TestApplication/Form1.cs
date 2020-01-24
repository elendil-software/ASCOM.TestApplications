using System;
using System.Globalization;
using System.Windows.Forms;
using ASCOM.DeviceInterface;

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
                UpdateValue(CloudCoverValue, () =>
                {
                    CloudCoverValue.Text = driver.CloudCover.ToString(CultureInfo.InvariantCulture);
                    CloudCoverDateTime.Text = driver.TimeSinceLastUpdate("CloudCover").ToString(CultureInfo.InvariantCulture);
                    CloudCoverDescription.Text = driver.SensorDescription("CloudCover");
                });
                
                UpdateValue(DewPointValue, () =>
                {
                    DewPointValue.Text = driver.DewPoint.ToString(CultureInfo.InvariantCulture);
                    DewPointDateTime.Text = driver.TimeSinceLastUpdate("DewPoint").ToString(CultureInfo.InvariantCulture);
                    DewPointDescription.Text = driver.SensorDescription("DewPoint");
                });
                UpdateValue(HumidityValue, () =>
                {
                    HumidityValue.Text = driver.Humidity.ToString(CultureInfo.InvariantCulture);
                    HumidityDateTime.Text = driver.TimeSinceLastUpdate("Humidity").ToString(CultureInfo.InvariantCulture);
                    HumidityDescription.Text = driver.SensorDescription("Humidity");
                });
                UpdateValue(PressureValue, () =>
                {
                    PressureValue.Text = driver.Pressure.ToString(CultureInfo.InvariantCulture);
                    PressureDateTime.Text = driver.TimeSinceLastUpdate("Pressure").ToString(CultureInfo.InvariantCulture);
                    PressureDescription.Text = driver.SensorDescription("Pressure");
                });
                UpdateValue(RainRateValue, () =>
                {
                    RainRateValue.Text = driver.RainRate.ToString(CultureInfo.InvariantCulture);
                    RainRateDateTime.Text = driver.TimeSinceLastUpdate("RainRate").ToString(CultureInfo.InvariantCulture);
                    RainRateDescription.Text = driver.SensorDescription("RainRate");
                });
                UpdateValue(SkyBrightnessValue, () =>
                {
                    SkyBrightnessValue.Text = driver.SkyBrightness.ToString(CultureInfo.InvariantCulture);
                    SkyBrightnessDateTime.Text = driver.TimeSinceLastUpdate("SkyBrightness").ToString(CultureInfo.InvariantCulture);
                    SkyBrightnessDescription.Text = driver.SensorDescription("SkyBrightness");
                });
                UpdateValue(SkyQualityValue, () =>
                {
                    SkyQualityValue.Text = driver.SkyQuality.ToString(CultureInfo.InvariantCulture);
                    SkyQualityDateTime.Text = driver.TimeSinceLastUpdate("SkyQuality").ToString(CultureInfo.InvariantCulture);
                    SkyQualityDescription.Text = driver.SensorDescription("SkyQuality");
                });
                UpdateValue(StarFwhmValue, () =>
                {
                    StarFwhmValue.Text = driver.StarFWHM.ToString(CultureInfo.InvariantCulture);
                    StarFwhmDateTime.Text = driver.TimeSinceLastUpdate("StarFwhm").ToString(CultureInfo.InvariantCulture);
                    StarFwhmDescription.Text = driver.SensorDescription("StarFwhm");
                });
                UpdateValue(SkyTemperatureValue, () =>
                {
                    SkyTemperatureValue.Text = driver.SkyTemperature.ToString(CultureInfo.InvariantCulture);
                    SkyTemperatureDateTime.Text = driver.TimeSinceLastUpdate("SkyTemperature").ToString(CultureInfo.InvariantCulture);
                    SkyTemperatureDescription.Text = driver.SensorDescription("SkyTemperature");
                });
                UpdateValue(TemperatureValue, () =>
                {
                    TemperatureValue.Text = driver.Temperature.ToString(CultureInfo.InvariantCulture);
                    TemperatureDateTime.Text = driver.TimeSinceLastUpdate("Temperature").ToString(CultureInfo.InvariantCulture);
                    TemperatureDescription.Text = driver.SensorDescription("Temperature");
                });
                UpdateValue(WindDirectionValue, () =>
                {
                    WindDirectionValue.Text = driver.WindDirection.ToString(CultureInfo.InvariantCulture);
                    WindDirectionDateTime.Text = driver.TimeSinceLastUpdate("WindDirection").ToString(CultureInfo.InvariantCulture);
                    WindDirectionDescription.Text = driver.SensorDescription("WindDirection");
                });
                UpdateValue(WindGustValue, () =>
                {
                    WindGustValue.Text = driver.WindGust.ToString(CultureInfo.InvariantCulture);
                    WindGustDateTime.Text = driver.TimeSinceLastUpdate("WindGust").ToString(CultureInfo.InvariantCulture);
                    WindGustDescription.Text = driver.SensorDescription("WindGust");
                });
                UpdateValue(WindSpeedValue, () =>
                {
                    WindSpeedValue.Text = driver.WindSpeed.ToString(CultureInfo.InvariantCulture);
                    WindSpeedDateTime.Text = driver.TimeSinceLastUpdate("WindSpeed").ToString(CultureInfo.InvariantCulture);
                    WindSpeedDescription.Text = driver.SensorDescription("WindSpeed");
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateValue(Label labelValue, Action action)
        {
            try
            {
                action();
            }
            catch (MethodNotImplementedException e)
            {
                labelValue.Text = "Not implemented";
            }
            catch (Exception e)
            {
                labelValue.Text = e.Message;
            }
        }
    }
}

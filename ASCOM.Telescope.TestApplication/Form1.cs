using System;
using System.Reflection;
using System.Windows.Forms;

namespace ASCOM.Telescope.TestApplication
{
	public partial class Form1 : Form
	{

		private ASCOM.DriverAccess.Telescope driver;
        private System.Threading.Timer stateTimer;

		public Form1()
		{
			InitializeComponent();
			SetUIState();

			startTrackBtn.Enabled = false;
			stopTrackBtn.Enabled = false;
			parkBtn.Enabled = false;
			unparkBtn.Enabled = false;
			setParkBtn.Enabled = false;
			guideWestButton.Enabled = false;
			guideEastButton.Enabled = false;
			guideNorthButton.Enabled = false;
			guideSouthButton.Enabled = false;

		    SlewButton.Enabled = false;
            AbortButton.Enabled = false;
            moveEastButton.Enabled = false;
            moveWestButton.Enabled = false;
            moveNorthButton.Enabled = false;
            moveSouthButton.Enabled = false;
            moveStopButton.Enabled = false;
		}


		private void StartTimer()
		{
			stateTimer = new System.Threading.Timer(CheckStatus, null, 1000, 1000);
		}

		public void CheckStatus(Object stateInfo)
		{
			try
			{
				SetControlPropertyThreadSafe(isConnectedLabel, "Text", driver.Connected.ToString());
				SetControlPropertyThreadSafe(isTrakingLabel, "Text", driver.Tracking.ToString());
				SetControlPropertyThreadSafe(atParkLabel, "Text", driver.AtPark.ToString());
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
				control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new[] { propertyValue });
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            if (IsConnected)
            {
                driver.Connected = false;
            }

            if (stateTimer != null)
            {
                stateTimer.Dispose();
            }

            Properties.Settings.Default.Save();
		}

		private void buttonChoose_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.DriverId = DriverAccess.Telescope.Choose(Properties.Settings.Default.DriverId);
			SetUIState();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
            try
            {
                if (IsConnected)
                {
                    driver.Connected = false;
                }
                else
                {
                    driver = new ASCOM.DriverAccess.Telescope(Properties.Settings.Default.DriverId);
                    driver.Connected = true;
                    unparkBtn.Enabled = true;

                    StartTimer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
				return ((driver != null) && (driver.Connected));
			}
		}

		private void unparkBtn_Click(object sender, EventArgs e)
		{
			try
			{
				driver.Unpark();
				parkBtn.Enabled = true;
				unparkBtn.Enabled = false;
				setParkBtn.Enabled = true;
				startTrackBtn.Enabled = true;

                moveEastButton.Enabled = true;
                moveWestButton.Enabled = true;
                moveNorthButton.Enabled = true;
                moveSouthButton.Enabled = true;
                moveStopButton.Enabled = true;
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void startTrackBtn_Click(object sender, EventArgs e)
		{
			try
			{
				driver.Tracking = true;
				startTrackBtn.Enabled = false;
				stopTrackBtn.Enabled = true;
				guideWestButton.Enabled = true;
				guideEastButton.Enabled = true;
				guideNorthButton.Enabled = true;
				guideSouthButton.Enabled = true;

			    SlewButton.Enabled = true;
			    AbortButton.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void setParkBtn_Click(object sender, EventArgs e)
		{
			try
			{
				driver.SetPark();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void parkBtn_Click(object sender, EventArgs e)
		{
			try
			{
				driver.Park();
				parkBtn.Enabled = false;
				unparkBtn.Enabled = true;
				setParkBtn.Enabled = false;
				startTrackBtn.Enabled = false;
				stopTrackBtn.Enabled = false;
				guideWestButton.Enabled = false;
				guideEastButton.Enabled = false;
				guideNorthButton.Enabled = false;
				guideSouthButton.Enabled = false;

                SlewButton.Enabled = false;
                AbortButton.Enabled = false;

                moveEastButton.Enabled = false;
                moveWestButton.Enabled = false;
                moveNorthButton.Enabled = false;
                moveSouthButton.Enabled = false;
                moveStopButton.Enabled = false;
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void stopTrackBtn_Click(object sender, EventArgs e)
		{
			try
			{
				driver.Tracking = false;
				startTrackBtn.Enabled = true;
				stopTrackBtn.Enabled = false;
				guideWestButton.Enabled = false;
				guideEastButton.Enabled = false;
				guideNorthButton.Enabled = false;
				guideSouthButton.Enabled = false;

                SlewButton.Enabled = false;
                AbortButton.Enabled = false;
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void guideNorthButton_Click(object sender, EventArgs e)
		{
			try
			{
				driver.PulseGuide(DeviceInterface.GuideDirections.guideNorth, (int)guideDurationNumericUpDown.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void guideSouthButton_Click(object sender, EventArgs e)
		{
			try
			{
				driver.PulseGuide(DeviceInterface.GuideDirections.guideSouth, (int)guideDurationNumericUpDown.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void guideEastButton_Click(object sender, EventArgs e)
		{
			try
			{
				driver.PulseGuide(DeviceInterface.GuideDirections.guideEast, (int)guideDurationNumericUpDown.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void guideWestButton_Click(object sender, EventArgs e)
		{
			try
			{
				driver.PulseGuide(DeviceInterface.GuideDirections.guideWest, (int)guideDurationNumericUpDown.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void moveStopButton_Click(object sender, EventArgs e)
        {
            try
            {
                driver.AbortSlew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void moveEastButton_Click(object sender, EventArgs e)
        {
            try { 
            driver.MoveAxis(DeviceInterface.TelescopeAxes.axisPrimary, Convert.ToDouble(RateNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void moveWestButton_Click(object sender, EventArgs e)
        {
            try { 
            driver.MoveAxis(DeviceInterface.TelescopeAxes.axisPrimary, -1 * Convert.ToDouble(RateNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void moveNorthButton_Click(object sender, EventArgs e)
        {
            try { 
            driver.MoveAxis(DeviceInterface.TelescopeAxes.axisSecondary, Convert.ToDouble(RateNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void moveSouthButton_Click(object sender, EventArgs e)
        {
            try { 
            driver.MoveAxis(DeviceInterface.TelescopeAxes.axisSecondary, -1 * Convert.ToDouble(RateNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            try
            {
                driver.AbortSlew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SlewButton_Click(object sender, EventArgs e)
        {
            try
            {
                driver.SlewToCoordinatesAsync(double.Parse(RATextBox.Text), double.Parse(DecTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

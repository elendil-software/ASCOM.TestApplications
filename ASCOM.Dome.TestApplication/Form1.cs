using System;
using System.Reflection;
using System.Windows.Forms;

namespace ASCOM.Dome.TestApplication
{
	public partial class Form1 : Form
	{
		private DriverAccess.Dome driver;

		public Form1()
		{
			InitializeComponent();
			SetUiState();
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
			Properties.Settings.Default.DriverId = DriverAccess.Dome.Choose(Properties.Settings.Default.DriverId);
			labelDriverId.Text = Properties.Settings.Default.DriverId;
			SetUiState();
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
					if (driver == null)
					{
						driver = new DriverAccess.Dome(Properties.Settings.Default.DriverId) {Connected = true};
					}

					labelNameValue.Text = driver.Name;
					labelDescriptionValue.Text = driver.Description;
					labelDriverInfoValue.Text = driver.DriverInfo;
					StartTimer();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			SetUiState();
		}

		// This method is called by the timer delegate. 
		public void CheckStatus(Object stateInfo)
		{
			try
			{
				SetControlPropertyThreadSafe(textBoxShutterState, "Text", driver.ShutterStatus.ToString());
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

		private void SetUiState()
		{
			buttonConnect.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.DriverId);
			buttonChoose.Enabled = !IsConnected;
			buttonConnect.Text = IsConnected ? "Disconnect" : "Connect";
		}

		private bool IsConnected
		{
			get { return ((driver != null) && (driver.Connected)); }
		}

		private void buttonOpenShutter_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsConnected)
				{
					driver.OpenShutter();
				}
				else
				{
					MessageBox.Show(@"Not connected");
				}
			}
			catch (DriverException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void buttonCloseShutter_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsConnected)
				{
					driver.CloseShutter();
				}
				else
				{
					MessageBox.Show(@"Not connected");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void buttonAbort_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsConnected)
				{
					driver.AbortSlew();
				}
				else
				{
					MessageBox.Show(@"Not connected");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
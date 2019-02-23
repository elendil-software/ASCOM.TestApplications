using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace ASCOM.Switch.TestApplication
{
	public partial class Form1 : Form
	{
		private DriverAccess.Switch driver;

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
			Properties.Settings.Default.DriverId = DriverAccess.Switch.Choose(Properties.Settings.Default.DriverId);
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
					driver = new DriverAccess.Switch(Properties.Settings.Default.DriverId)
					{
						Connected = true
					};

					switchId.Maximum = driver.MaxSwitch;

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
				SetControlPropertyThreadSafe(state, "Text",
					driver.GetSwitch((short) (switchId.Value - 1)).ToString(CultureInfo.InvariantCulture));

				SetControlPropertyThreadSafe(name, "Text",
					driver.GetSwitchName((short) (switchId.Value - 1)).ToString(CultureInfo.InvariantCulture));

				var canWrite = driver.CanWrite((short) (switchId.Value - 1));

				SetControlPropertyThreadSafe(button1, "Enabled", canWrite);
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
			stateTimer = new System.Threading.Timer(CheckStatus, null, 1000, 2000);
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (IsConnected)
				{
					var currentState = driver.GetSwitch((short) (switchId.Value - 1));
					driver.SetSwitch((short) (switchId.Value - 1), !currentState);
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
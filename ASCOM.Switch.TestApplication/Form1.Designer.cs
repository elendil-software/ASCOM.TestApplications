namespace ASCOM.Switch.TestApplication
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonChoose = new System.Windows.Forms.Button();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.labelDriverId = new System.Windows.Forms.Label();
			this.switchId = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.state = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.switchId)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonChoose
			// 
			this.buttonChoose.Location = new System.Drawing.Point(309, 10);
			this.buttonChoose.Name = "buttonChoose";
			this.buttonChoose.Size = new System.Drawing.Size(72, 23);
			this.buttonChoose.TabIndex = 0;
			this.buttonChoose.Text = "Choose";
			this.buttonChoose.UseVisualStyleBackColor = true;
			this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(309, 39);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(72, 23);
			this.buttonConnect.TabIndex = 1;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// labelDriverId
			// 
			this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.Switch.TestApplication.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.labelDriverId.Location = new System.Drawing.Point(12, 40);
			this.labelDriverId.Name = "labelDriverId";
			this.labelDriverId.Size = new System.Drawing.Size(291, 21);
			this.labelDriverId.TabIndex = 2;
			this.labelDriverId.Text = global::ASCOM.Switch.TestApplication.Properties.Settings.Default.DriverId;
			this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// switchId
			// 
			this.switchId.Location = new System.Drawing.Point(57, 76);
			this.switchId.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.switchId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.switchId.Name = "switchId";
			this.switchId.Size = new System.Drawing.Size(42, 20);
			this.switchId.TabIndex = 3;
			this.switchId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Switch";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Toggle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// state
			// 
			this.state.Location = new System.Drawing.Point(12, 102);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(87, 20);
			this.state.TabIndex = 6;
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(12, 128);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(87, 20);
			this.name.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 262);
			this.Controls.Add(this.name);
			this.Controls.Add(this.state);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.switchId);
			this.Controls.Add(this.labelDriverId);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.buttonChoose);
			this.Name = "Form1";
			this.Text = "TEMPLATEDEVICETYPE Test";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.switchId)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonChoose;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label labelDriverId;
		private System.Windows.Forms.NumericUpDown switchId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox state;
		private System.Windows.Forms.TextBox name;
	}
}


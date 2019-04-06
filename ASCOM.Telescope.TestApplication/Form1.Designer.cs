namespace ASCOM.Telescope.TestApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.isConnectedLabel = new System.Windows.Forms.Label();
            this.setParkBtn = new System.Windows.Forms.Button();
            this.unparkBtn = new System.Windows.Forms.Button();
            this.parkBtn = new System.Windows.Forms.Button();
            this.stopTrackBtn = new System.Windows.Forms.Button();
            this.startTrackBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.atParkLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.isTrakingLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guideDurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.guideEastButton = new System.Windows.Forms.Button();
            this.guideWestButton = new System.Windows.Forms.Button();
            this.guideSouthButton = new System.Windows.Forms.Button();
            this.guideNorthButton = new System.Windows.Forms.Button();
            this.moveEastButton = new System.Windows.Forms.Button();
            this.moveWestButton = new System.Windows.Forms.Button();
            this.moveSouthButton = new System.Windows.Forms.Button();
            this.moveNorthButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.moveStopButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DecTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RATextBox = new System.Windows.Forms.TextBox();
            this.isSlewingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SlewButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guideDurationNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumericUpDown)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(6, 19);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(72, 23);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(247, 44);
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
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.Telescope.TestApplication.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(6, 45);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(235, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.Telescope.TestApplication.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connected : ";
            // 
            // isConnectedLabel
            // 
            this.isConnectedLabel.AutoSize = true;
            this.isConnectedLabel.Location = new System.Drawing.Point(100, 79);
            this.isConnectedLabel.Name = "isConnectedLabel";
            this.isConnectedLabel.Size = new System.Drawing.Size(13, 13);
            this.isConnectedLabel.TabIndex = 4;
            this.isConnectedLabel.Text = "?";
            // 
            // setParkBtn
            // 
            this.setParkBtn.Location = new System.Drawing.Point(168, 19);
            this.setParkBtn.Name = "setParkBtn";
            this.setParkBtn.Size = new System.Drawing.Size(75, 23);
            this.setParkBtn.TabIndex = 11;
            this.setParkBtn.Text = "Set Park";
            this.setParkBtn.UseVisualStyleBackColor = true;
            this.setParkBtn.Click += new System.EventHandler(this.setParkBtn_Click);
            // 
            // unparkBtn
            // 
            this.unparkBtn.Location = new System.Drawing.Point(6, 19);
            this.unparkBtn.Name = "unparkBtn";
            this.unparkBtn.Size = new System.Drawing.Size(75, 23);
            this.unparkBtn.TabIndex = 10;
            this.unparkBtn.Text = "Unpark";
            this.unparkBtn.UseVisualStyleBackColor = true;
            this.unparkBtn.Click += new System.EventHandler(this.unparkBtn_Click);
            // 
            // parkBtn
            // 
            this.parkBtn.Location = new System.Drawing.Point(87, 19);
            this.parkBtn.Name = "parkBtn";
            this.parkBtn.Size = new System.Drawing.Size(75, 23);
            this.parkBtn.TabIndex = 9;
            this.parkBtn.Text = "Park";
            this.parkBtn.UseVisualStyleBackColor = true;
            this.parkBtn.Click += new System.EventHandler(this.parkBtn_Click);
            // 
            // stopTrackBtn
            // 
            this.stopTrackBtn.Location = new System.Drawing.Point(87, 19);
            this.stopTrackBtn.Name = "stopTrackBtn";
            this.stopTrackBtn.Size = new System.Drawing.Size(75, 23);
            this.stopTrackBtn.TabIndex = 14;
            this.stopTrackBtn.Text = "Stop track";
            this.stopTrackBtn.UseVisualStyleBackColor = true;
            this.stopTrackBtn.Click += new System.EventHandler(this.stopTrackBtn_Click);
            // 
            // startTrackBtn
            // 
            this.startTrackBtn.Location = new System.Drawing.Point(6, 19);
            this.startTrackBtn.Name = "startTrackBtn";
            this.startTrackBtn.Size = new System.Drawing.Size(75, 23);
            this.startTrackBtn.TabIndex = 13;
            this.startTrackBtn.Text = "Start track";
            this.startTrackBtn.UseVisualStyleBackColor = true;
            this.startTrackBtn.Click += new System.EventHandler(this.startTrackBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isConnectedLabel);
            this.groupBox1.Controls.Add(this.labelDriverId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonChoose);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.atParkLabel);
            this.groupBox3.Controls.Add(this.unparkBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.parkBtn);
            this.groupBox3.Controls.Add(this.setParkBtn);
            this.groupBox3.Location = new System.Drawing.Point(351, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 112);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Park";
            // 
            // atParkLabel
            // 
            this.atParkLabel.AutoSize = true;
            this.atParkLabel.Location = new System.Drawing.Point(68, 54);
            this.atParkLabel.Name = "atParkLabel";
            this.atParkLabel.Size = new System.Drawing.Size(13, 13);
            this.atParkLabel.TabIndex = 10;
            this.atParkLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "At park :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.isTrakingLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.startTrackBtn);
            this.groupBox4.Controls.Add(this.stopTrackBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 112);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tracking";
            // 
            // isTrakingLabel
            // 
            this.isTrakingLabel.AutoSize = true;
            this.isTrakingLabel.Location = new System.Drawing.Point(87, 54);
            this.isTrakingLabel.Name = "isTrakingLabel";
            this.isTrakingLabel.Size = new System.Drawing.Size(55, 13);
            this.isTrakingLabel.TabIndex = 16;
            this.isTrakingLabel.Text = "true | false";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Is tracking :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.guideDurationNumericUpDown);
            this.groupBox5.Controls.Add(this.guideEastButton);
            this.groupBox5.Controls.Add(this.guideWestButton);
            this.groupBox5.Controls.Add(this.guideSouthButton);
            this.groupBox5.Controls.Add(this.guideNorthButton);
            this.groupBox5.Location = new System.Drawing.Point(12, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 185);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Guiding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duration";
            // 
            // guideDurationNumericUpDown
            // 
            this.guideDurationNumericUpDown.Location = new System.Drawing.Point(71, 142);
            this.guideDurationNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.guideDurationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guideDurationNumericUpDown.Name = "guideDurationNumericUpDown";
            this.guideDurationNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.guideDurationNumericUpDown.TabIndex = 5;
            this.guideDurationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // guideEastButton
            // 
            this.guideEastButton.Location = new System.Drawing.Point(223, 56);
            this.guideEastButton.Name = "guideEastButton";
            this.guideEastButton.Size = new System.Drawing.Size(75, 23);
            this.guideEastButton.TabIndex = 3;
            this.guideEastButton.Text = "E";
            this.guideEastButton.UseVisualStyleBackColor = true;
            this.guideEastButton.Click += new System.EventHandler(this.guideEastButton_Click);
            // 
            // guideWestButton
            // 
            this.guideWestButton.Location = new System.Drawing.Point(41, 56);
            this.guideWestButton.Name = "guideWestButton";
            this.guideWestButton.Size = new System.Drawing.Size(75, 23);
            this.guideWestButton.TabIndex = 2;
            this.guideWestButton.Text = "W";
            this.guideWestButton.UseVisualStyleBackColor = true;
            this.guideWestButton.Click += new System.EventHandler(this.guideWestButton_Click);
            // 
            // guideSouthButton
            // 
            this.guideSouthButton.Location = new System.Drawing.Point(132, 97);
            this.guideSouthButton.Name = "guideSouthButton";
            this.guideSouthButton.Size = new System.Drawing.Size(75, 23);
            this.guideSouthButton.TabIndex = 1;
            this.guideSouthButton.Text = "S";
            this.guideSouthButton.UseVisualStyleBackColor = true;
            this.guideSouthButton.Click += new System.EventHandler(this.guideSouthButton_Click);
            // 
            // guideNorthButton
            // 
            this.guideNorthButton.Location = new System.Drawing.Point(132, 19);
            this.guideNorthButton.Name = "guideNorthButton";
            this.guideNorthButton.Size = new System.Drawing.Size(75, 23);
            this.guideNorthButton.TabIndex = 0;
            this.guideNorthButton.Text = "N";
            this.guideNorthButton.UseVisualStyleBackColor = true;
            this.guideNorthButton.Click += new System.EventHandler(this.guideNorthButton_Click);
            // 
            // moveEastButton
            // 
            this.moveEastButton.Location = new System.Drawing.Point(223, 56);
            this.moveEastButton.Name = "moveEastButton";
            this.moveEastButton.Size = new System.Drawing.Size(75, 23);
            this.moveEastButton.TabIndex = 3;
            this.moveEastButton.Text = "E";
            this.moveEastButton.UseVisualStyleBackColor = true;
            this.moveEastButton.Click += new System.EventHandler(this.moveEastButton_Click);
            // 
            // moveWestButton
            // 
            this.moveWestButton.Location = new System.Drawing.Point(41, 56);
            this.moveWestButton.Name = "moveWestButton";
            this.moveWestButton.Size = new System.Drawing.Size(75, 23);
            this.moveWestButton.TabIndex = 2;
            this.moveWestButton.Text = "W";
            this.moveWestButton.UseVisualStyleBackColor = true;
            this.moveWestButton.Click += new System.EventHandler(this.moveWestButton_Click);
            // 
            // moveSouthButton
            // 
            this.moveSouthButton.Location = new System.Drawing.Point(132, 97);
            this.moveSouthButton.Name = "moveSouthButton";
            this.moveSouthButton.Size = new System.Drawing.Size(75, 23);
            this.moveSouthButton.TabIndex = 1;
            this.moveSouthButton.Text = "S";
            this.moveSouthButton.UseVisualStyleBackColor = true;
            this.moveSouthButton.Click += new System.EventHandler(this.moveSouthButton_Click);
            // 
            // moveNorthButton
            // 
            this.moveNorthButton.Location = new System.Drawing.Point(132, 19);
            this.moveNorthButton.Name = "moveNorthButton";
            this.moveNorthButton.Size = new System.Drawing.Size(75, 23);
            this.moveNorthButton.TabIndex = 0;
            this.moveNorthButton.Text = "N";
            this.moveNorthButton.UseVisualStyleBackColor = true;
            this.moveNorthButton.Click += new System.EventHandler(this.moveNorthButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RateNumericUpDown);
            this.groupBox2.Controls.Add(this.moveStopButton);
            this.groupBox2.Controls.Add(this.moveEastButton);
            this.groupBox2.Controls.Add(this.moveWestButton);
            this.groupBox2.Controls.Add(this.moveSouthButton);
            this.groupBox2.Controls.Add(this.moveNorthButton);
            this.groupBox2.Location = new System.Drawing.Point(351, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 185);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rate";
            // 
            // RateNumericUpDown
            // 
            this.RateNumericUpDown.DecimalPlaces = 1;
            this.RateNumericUpDown.Location = new System.Drawing.Point(71, 142);
            this.RateNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RateNumericUpDown.Name = "RateNumericUpDown";
            this.RateNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.RateNumericUpDown.TabIndex = 8;
            this.RateNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // moveStopButton
            // 
            this.moveStopButton.Location = new System.Drawing.Point(132, 56);
            this.moveStopButton.Name = "moveStopButton";
            this.moveStopButton.Size = new System.Drawing.Size(75, 23);
            this.moveStopButton.TabIndex = 4;
            this.moveStopButton.Text = "STOP";
            this.moveStopButton.UseVisualStyleBackColor = true;
            this.moveStopButton.Click += new System.EventHandler(this.moveStopButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DecTextBox);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.RATextBox);
            this.groupBox6.Controls.Add(this.isSlewingLabel);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.SlewButton);
            this.groupBox6.Controls.Add(this.AbortButton);
            this.groupBox6.Location = new System.Drawing.Point(351, 129);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 112);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Slew";
            // 
            // DecTextBox
            // 
            this.DecTextBox.Location = new System.Drawing.Point(62, 45);
            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(100, 20);
            this.DecTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Dec.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "R.A.";
            // 
            // RATextBox
            // 
            this.RATextBox.Location = new System.Drawing.Point(62, 19);
            this.RATextBox.Name = "RATextBox";
            this.RATextBox.Size = new System.Drawing.Size(100, 20);
            this.RATextBox.TabIndex = 17;
            // 
            // isSlewingLabel
            // 
            this.isSlewingLabel.AutoSize = true;
            this.isSlewingLabel.Location = new System.Drawing.Point(90, 84);
            this.isSlewingLabel.Name = "isSlewingLabel";
            this.isSlewingLabel.Size = new System.Drawing.Size(55, 13);
            this.isSlewingLabel.TabIndex = 16;
            this.isSlewingLabel.Text = "true | false";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Is slewing :";
            // 
            // SlewButton
            // 
            this.SlewButton.Location = new System.Drawing.Point(168, 79);
            this.SlewButton.Name = "SlewButton";
            this.SlewButton.Size = new System.Drawing.Size(75, 23);
            this.SlewButton.TabIndex = 13;
            this.SlewButton.Text = "Slew";
            this.SlewButton.UseVisualStyleBackColor = true;
            this.SlewButton.Click += new System.EventHandler(this.SlewButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(249, 79);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(75, 23);
            this.AbortButton.TabIndex = 14;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 630);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ASCOM Telescope Test App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guideDurationNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RateNumericUpDown)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonChoose;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label labelDriverId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label isConnectedLabel;
		private System.Windows.Forms.Button setParkBtn;
		private System.Windows.Forms.Button unparkBtn;
		private System.Windows.Forms.Button parkBtn;
		private System.Windows.Forms.Button stopTrackBtn;
		private System.Windows.Forms.Button startTrackBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label atParkLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label isTrakingLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button guideEastButton;
		private System.Windows.Forms.Button guideWestButton;
		private System.Windows.Forms.Button guideSouthButton;
		private System.Windows.Forms.Button guideNorthButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown guideDurationNumericUpDown;
        private System.Windows.Forms.Button moveEastButton;
        private System.Windows.Forms.Button moveWestButton;
        private System.Windows.Forms.Button moveSouthButton;
        private System.Windows.Forms.Button moveNorthButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button moveStopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RateNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox DecTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RATextBox;
        private System.Windows.Forms.Label isSlewingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SlewButton;
        private System.Windows.Forms.Button AbortButton;
    }
}


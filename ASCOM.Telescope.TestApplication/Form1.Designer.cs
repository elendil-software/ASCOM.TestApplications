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
            this.buttonChoose.Location = new System.Drawing.Point(8, 23);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(96, 28);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(329, 54);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 28);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.Telescope.TestApplication.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(8, 55);
            this.labelDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(313, 25);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.Telescope.TestApplication.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connected : ";
            // 
            // isConnectedLabel
            // 
            this.isConnectedLabel.AutoSize = true;
            this.isConnectedLabel.Location = new System.Drawing.Point(133, 97);
            this.isConnectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isConnectedLabel.Name = "isConnectedLabel";
            this.isConnectedLabel.Size = new System.Drawing.Size(16, 17);
            this.isConnectedLabel.TabIndex = 4;
            this.isConnectedLabel.Text = "?";
            // 
            // setParkBtn
            // 
            this.setParkBtn.Location = new System.Drawing.Point(224, 23);
            this.setParkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setParkBtn.Name = "setParkBtn";
            this.setParkBtn.Size = new System.Drawing.Size(100, 28);
            this.setParkBtn.TabIndex = 11;
            this.setParkBtn.Text = "Set Park";
            this.setParkBtn.UseVisualStyleBackColor = true;
            this.setParkBtn.Click += new System.EventHandler(this.setParkBtn_Click);
            // 
            // unparkBtn
            // 
            this.unparkBtn.Location = new System.Drawing.Point(8, 23);
            this.unparkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unparkBtn.Name = "unparkBtn";
            this.unparkBtn.Size = new System.Drawing.Size(100, 28);
            this.unparkBtn.TabIndex = 10;
            this.unparkBtn.Text = "Unpark";
            this.unparkBtn.UseVisualStyleBackColor = true;
            this.unparkBtn.Click += new System.EventHandler(this.unparkBtn_Click);
            // 
            // parkBtn
            // 
            this.parkBtn.Location = new System.Drawing.Point(116, 23);
            this.parkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parkBtn.Name = "parkBtn";
            this.parkBtn.Size = new System.Drawing.Size(100, 28);
            this.parkBtn.TabIndex = 9;
            this.parkBtn.Text = "Park";
            this.parkBtn.UseVisualStyleBackColor = true;
            this.parkBtn.Click += new System.EventHandler(this.parkBtn_Click);
            // 
            // stopTrackBtn
            // 
            this.stopTrackBtn.Location = new System.Drawing.Point(116, 23);
            this.stopTrackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopTrackBtn.Name = "stopTrackBtn";
            this.stopTrackBtn.Size = new System.Drawing.Size(100, 28);
            this.stopTrackBtn.TabIndex = 14;
            this.stopTrackBtn.Text = "Stop track";
            this.stopTrackBtn.UseVisualStyleBackColor = true;
            this.stopTrackBtn.Click += new System.EventHandler(this.stopTrackBtn_Click);
            // 
            // startTrackBtn
            // 
            this.startTrackBtn.Location = new System.Drawing.Point(8, 23);
            this.startTrackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTrackBtn.Name = "startTrackBtn";
            this.startTrackBtn.Size = new System.Drawing.Size(100, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(444, 137);
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
            this.groupBox3.Location = new System.Drawing.Point(468, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(444, 138);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Park";
            // 
            // atParkLabel
            // 
            this.atParkLabel.AutoSize = true;
            this.atParkLabel.Location = new System.Drawing.Point(91, 66);
            this.atParkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.atParkLabel.Name = "atParkLabel";
            this.atParkLabel.Size = new System.Drawing.Size(16, 17);
            this.atParkLabel.TabIndex = 10;
            this.atParkLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "At park :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.isTrakingLabel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.startTrackBtn);
            this.groupBox4.Controls.Add(this.stopTrackBtn);
            this.groupBox4.Location = new System.Drawing.Point(16, 160);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(444, 138);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tracking";
            // 
            // isTrakingLabel
            // 
            this.isTrakingLabel.AutoSize = true;
            this.isTrakingLabel.Location = new System.Drawing.Point(116, 66);
            this.isTrakingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isTrakingLabel.Name = "isTrakingLabel";
            this.isTrakingLabel.Size = new System.Drawing.Size(74, 17);
            this.isTrakingLabel.TabIndex = 16;
            this.isTrakingLabel.Text = "true | false";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
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
            this.groupBox5.Location = new System.Drawing.Point(16, 304);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(444, 228);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Guiding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duration";
            // 
            // guideDurationNumericUpDown
            // 
            this.guideDurationNumericUpDown.Location = new System.Drawing.Point(95, 175);
            this.guideDurationNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.guideDurationNumericUpDown.Size = new System.Drawing.Size(99, 22);
            this.guideDurationNumericUpDown.TabIndex = 5;
            this.guideDurationNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // guideEastButton
            // 
            this.guideEastButton.Location = new System.Drawing.Point(297, 69);
            this.guideEastButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guideEastButton.Name = "guideEastButton";
            this.guideEastButton.Size = new System.Drawing.Size(100, 28);
            this.guideEastButton.TabIndex = 3;
            this.guideEastButton.Text = "E";
            this.guideEastButton.UseVisualStyleBackColor = true;
            this.guideEastButton.Click += new System.EventHandler(this.guideEastButton_Click);
            // 
            // guideWestButton
            // 
            this.guideWestButton.Location = new System.Drawing.Point(55, 69);
            this.guideWestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guideWestButton.Name = "guideWestButton";
            this.guideWestButton.Size = new System.Drawing.Size(100, 28);
            this.guideWestButton.TabIndex = 2;
            this.guideWestButton.Text = "W";
            this.guideWestButton.UseVisualStyleBackColor = true;
            this.guideWestButton.Click += new System.EventHandler(this.guideWestButton_Click);
            // 
            // guideSouthButton
            // 
            this.guideSouthButton.Location = new System.Drawing.Point(176, 119);
            this.guideSouthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guideSouthButton.Name = "guideSouthButton";
            this.guideSouthButton.Size = new System.Drawing.Size(100, 28);
            this.guideSouthButton.TabIndex = 1;
            this.guideSouthButton.Text = "S";
            this.guideSouthButton.UseVisualStyleBackColor = true;
            this.guideSouthButton.Click += new System.EventHandler(this.guideSouthButton_Click);
            // 
            // guideNorthButton
            // 
            this.guideNorthButton.Location = new System.Drawing.Point(176, 23);
            this.guideNorthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guideNorthButton.Name = "guideNorthButton";
            this.guideNorthButton.Size = new System.Drawing.Size(100, 28);
            this.guideNorthButton.TabIndex = 0;
            this.guideNorthButton.Text = "N";
            this.guideNorthButton.UseVisualStyleBackColor = true;
            this.guideNorthButton.Click += new System.EventHandler(this.guideNorthButton_Click);
            // 
            // moveEastButton
            // 
            this.moveEastButton.Location = new System.Drawing.Point(297, 69);
            this.moveEastButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveEastButton.Name = "moveEastButton";
            this.moveEastButton.Size = new System.Drawing.Size(100, 28);
            this.moveEastButton.TabIndex = 3;
            this.moveEastButton.Text = "E";
            this.moveEastButton.UseVisualStyleBackColor = true;
            this.moveEastButton.Click += new System.EventHandler(this.moveEastButton_Click);
            // 
            // moveWestButton
            // 
            this.moveWestButton.Location = new System.Drawing.Point(55, 69);
            this.moveWestButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveWestButton.Name = "moveWestButton";
            this.moveWestButton.Size = new System.Drawing.Size(100, 28);
            this.moveWestButton.TabIndex = 2;
            this.moveWestButton.Text = "W";
            this.moveWestButton.UseVisualStyleBackColor = true;
            this.moveWestButton.Click += new System.EventHandler(this.moveWestButton_Click);
            // 
            // moveSouthButton
            // 
            this.moveSouthButton.Location = new System.Drawing.Point(176, 119);
            this.moveSouthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveSouthButton.Name = "moveSouthButton";
            this.moveSouthButton.Size = new System.Drawing.Size(100, 28);
            this.moveSouthButton.TabIndex = 1;
            this.moveSouthButton.Text = "S";
            this.moveSouthButton.UseVisualStyleBackColor = true;
            this.moveSouthButton.Click += new System.EventHandler(this.moveSouthButton_Click);
            // 
            // moveNorthButton
            // 
            this.moveNorthButton.Location = new System.Drawing.Point(176, 23);
            this.moveNorthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveNorthButton.Name = "moveNorthButton";
            this.moveNorthButton.Size = new System.Drawing.Size(100, 28);
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
            this.groupBox2.Location = new System.Drawing.Point(468, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(444, 228);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rate";
            // 
            // RateNumericUpDown
            // 
            this.RateNumericUpDown.DecimalPlaces = 1;
            this.RateNumericUpDown.Location = new System.Drawing.Point(95, 175);
            this.RateNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RateNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RateNumericUpDown.Name = "RateNumericUpDown";
            this.RateNumericUpDown.Size = new System.Drawing.Size(99, 22);
            this.RateNumericUpDown.TabIndex = 8;
            this.RateNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // moveStopButton
            // 
            this.moveStopButton.Location = new System.Drawing.Point(176, 69);
            this.moveStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveStopButton.Name = "moveStopButton";
            this.moveStopButton.Size = new System.Drawing.Size(100, 28);
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
            this.groupBox6.Location = new System.Drawing.Point(468, 159);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(444, 138);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Slew";
            // 
            // DecTextBox
            // 
            this.DecTextBox.Location = new System.Drawing.Point(83, 55);
            this.DecTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(132, 22);
            this.DecTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Dec.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "R.A.";
            // 
            // RATextBox
            // 
            this.RATextBox.Location = new System.Drawing.Point(83, 23);
            this.RATextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RATextBox.Name = "RATextBox";
            this.RATextBox.Size = new System.Drawing.Size(132, 22);
            this.RATextBox.TabIndex = 17;
            // 
            // isSlewingLabel
            // 
            this.isSlewingLabel.AutoSize = true;
            this.isSlewingLabel.Location = new System.Drawing.Point(120, 103);
            this.isSlewingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isSlewingLabel.Name = "isSlewingLabel";
            this.isSlewingLabel.Size = new System.Drawing.Size(74, 17);
            this.isSlewingLabel.TabIndex = 16;
            this.isSlewingLabel.Text = "true | false";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Is slewing :";
            // 
            // SlewButton
            // 
            this.SlewButton.Location = new System.Drawing.Point(224, 97);
            this.SlewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SlewButton.Name = "SlewButton";
            this.SlewButton.Size = new System.Drawing.Size(100, 28);
            this.SlewButton.TabIndex = 13;
            this.SlewButton.Text = "Slew";
            this.SlewButton.UseVisualStyleBackColor = true;
            this.SlewButton.Click += new System.EventHandler(this.SlewButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(332, 97);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(100, 28);
            this.AbortButton.TabIndex = 14;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 775);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Telescope";
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


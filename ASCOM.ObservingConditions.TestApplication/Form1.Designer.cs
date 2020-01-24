namespace ASCOM.ObservingConditions.TestApplication
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
            this.GetDataButton = new System.Windows.Forms.Button();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.DewPointLabel = new System.Windows.Forms.Label();
            this.DewPointValue = new System.Windows.Forms.Label();
            this.PressureValue = new System.Windows.Forms.Label();
            this.HumidityValue = new System.Windows.Forms.Label();
            this.TemperatureValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SkyBrightnessValue = new System.Windows.Forms.Label();
            this.RainRateValue = new System.Windows.Forms.Label();
            this.CloudCoverValue = new System.Windows.Forms.Label();
            this.SkyBrightnessLabel = new System.Windows.Forms.Label();
            this.RainRateLabel = new System.Windows.Forms.Label();
            this.CloudCoverLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.WindSpeedValue = new System.Windows.Forms.Label();
            this.WindGustValue = new System.Windows.Forms.Label();
            this.WindDirectionValue = new System.Windows.Forms.Label();
            this.WindGustLabel = new System.Windows.Forms.Label();
            this.WindDirectionLabel = new System.Windows.Forms.Label();
            this.SkyQualityValue = new System.Windows.Forms.Label();
            this.StarFwhmValue = new System.Windows.Forms.Label();
            this.SkyTemperatureValue = new System.Windows.Forms.Label();
            this.SkyQualityLabel = new System.Windows.Forms.Label();
            this.StarFwhmLabel = new System.Windows.Forms.Label();
            this.SkyTemperatureLabel = new System.Windows.Forms.Label();
            this.CloudCoverDateTime = new System.Windows.Forms.Label();
            this.DewPointDateTime = new System.Windows.Forms.Label();
            this.HumidityDateTime = new System.Windows.Forms.Label();
            this.PressureDateTime = new System.Windows.Forms.Label();
            this.RainRateDateTime = new System.Windows.Forms.Label();
            this.SkyBrightnessDateTime = new System.Windows.Forms.Label();
            this.SkyQualityDateTime = new System.Windows.Forms.Label();
            this.StarFwhmDateTime = new System.Windows.Forms.Label();
            this.SkyTemperatureDateTime = new System.Windows.Forms.Label();
            this.TemperatureDateTime = new System.Windows.Forms.Label();
            this.WindDirectionDateTime = new System.Windows.Forms.Label();
            this.WindGustDateTime = new System.Windows.Forms.Label();
            this.WindSpeedDateTime = new System.Windows.Forms.Label();
            this.CloudCoverDescription = new System.Windows.Forms.Label();
            this.DewPointDescription = new System.Windows.Forms.Label();
            this.HumidityDescription = new System.Windows.Forms.Label();
            this.PressureDescription = new System.Windows.Forms.Label();
            this.RainRateDescription = new System.Windows.Forms.Label();
            this.SkyBrightnessDescription = new System.Windows.Forms.Label();
            this.SkyQualityDescription = new System.Windows.Forms.Label();
            this.StarFwhmDescription = new System.Windows.Forms.Label();
            this.SkyTemperatureDescription = new System.Windows.Forms.Label();
            this.TemperatureDescription = new System.Windows.Forms.Label();
            this.WindDirectionDescription = new System.Windows.Forms.Label();
            this.WindGustDescription = new System.Windows.Forms.Label();
            this.WindSpeedDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(412, 12);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(96, 28);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(412, 48);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
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
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.ObservingConditions.TestApplication.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(16, 49);
            this.labelDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(387, 25);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.ObservingConditions.TestApplication.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Enabled = false;
            this.GetDataButton.Location = new System.Drawing.Point(16, 94);
            this.GetDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(100, 28);
            this.GetDataButton.TabIndex = 3;
            this.GetDataButton.Text = "Get Data";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.Location = new System.Drawing.Point(4, 180);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(101, 17);
            this.TemperatureLabel.TabIndex = 4;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityLabel.Location = new System.Drawing.Point(4, 40);
            this.HumidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(70, 17);
            this.HumidityLabel.TabIndex = 8;
            this.HumidityLabel.Text = "Humidity";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureLabel.Location = new System.Drawing.Point(4, 60);
            this.PressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(73, 17);
            this.PressureLabel.TabIndex = 9;
            this.PressureLabel.Text = "Pressure";
            // 
            // DewPointLabel
            // 
            this.DewPointLabel.AutoSize = true;
            this.DewPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DewPointLabel.Location = new System.Drawing.Point(4, 20);
            this.DewPointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DewPointLabel.Name = "DewPointLabel";
            this.DewPointLabel.Size = new System.Drawing.Size(75, 17);
            this.DewPointLabel.TabIndex = 10;
            this.DewPointLabel.Text = "DewPoint";
            // 
            // DewPointValue
            // 
            this.DewPointValue.AutoSize = true;
            this.DewPointValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DewPointValue.Location = new System.Drawing.Point(179, 20);
            this.DewPointValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DewPointValue.Name = "DewPointValue";
            this.DewPointValue.Size = new System.Drawing.Size(32, 17);
            this.DewPointValue.TabIndex = 14;
            this.DewPointValue.Text = "???";
            // 
            // PressureValue
            // 
            this.PressureValue.AutoSize = true;
            this.PressureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureValue.Location = new System.Drawing.Point(179, 60);
            this.PressureValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PressureValue.Name = "PressureValue";
            this.PressureValue.Size = new System.Drawing.Size(32, 17);
            this.PressureValue.TabIndex = 13;
            this.PressureValue.Text = "???";
            // 
            // HumidityValue
            // 
            this.HumidityValue.AutoSize = true;
            this.HumidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityValue.Location = new System.Drawing.Point(179, 40);
            this.HumidityValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumidityValue.Name = "HumidityValue";
            this.HumidityValue.Size = new System.Drawing.Size(32, 17);
            this.HumidityValue.TabIndex = 12;
            this.HumidityValue.Text = "???";
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValue.Location = new System.Drawing.Point(179, 180);
            this.TemperatureValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(32, 17);
            this.TemperatureValue.TabIndex = 11;
            this.TemperatureValue.Text = "???";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.WindSpeedDescription, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.WindGustDescription, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.WindDirectionDescription, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.TemperatureDescription, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.SkyTemperatureDescription, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.StarFwhmDescription, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.SkyQualityDescription, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.SkyBrightnessDescription, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.RainRateDescription, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.PressureDescription, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.HumidityDescription, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.DewPointDescription, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CloudCoverDescription, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.WindSpeedDateTime, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.WindGustDateTime, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.WindDirectionDateTime, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.TemperatureDateTime, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.SkyTemperatureDateTime, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.StarFwhmDateTime, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.SkyQualityDateTime, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.SkyBrightnessDateTime, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.RainRateDateTime, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.PressureDateTime, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.HumidityDateTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DewPointDateTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SkyBrightnessValue, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RainRateValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CloudCoverValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SkyBrightnessLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RainRateLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CloudCoverLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DewPointLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PressureValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DewPointValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HumidityLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PressureLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HumidityValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.WindSpeedLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.WindSpeedValue, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.WindGustValue, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.WindDirectionValue, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.WindGustLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.WindDirectionLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.TemperatureLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.TemperatureValue, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.SkyQualityValue, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.StarFwhmValue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.SkyTemperatureValue, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.SkyQualityLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.StarFwhmLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.SkyTemperatureLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.CloudCoverDateTime, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 269);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // SkyBrightnessValue
            // 
            this.SkyBrightnessValue.AutoSize = true;
            this.SkyBrightnessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyBrightnessValue.Location = new System.Drawing.Point(179, 100);
            this.SkyBrightnessValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyBrightnessValue.Name = "SkyBrightnessValue";
            this.SkyBrightnessValue.Size = new System.Drawing.Size(32, 17);
            this.SkyBrightnessValue.TabIndex = 28;
            this.SkyBrightnessValue.Text = "???";
            // 
            // RainRateValue
            // 
            this.RainRateValue.AutoSize = true;
            this.RainRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainRateValue.Location = new System.Drawing.Point(179, 80);
            this.RainRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RainRateValue.Name = "RainRateValue";
            this.RainRateValue.Size = new System.Drawing.Size(32, 17);
            this.RainRateValue.TabIndex = 27;
            this.RainRateValue.Text = "???";
            // 
            // CloudCoverValue
            // 
            this.CloudCoverValue.AutoSize = true;
            this.CloudCoverValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloudCoverValue.Location = new System.Drawing.Point(179, 0);
            this.CloudCoverValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloudCoverValue.Name = "CloudCoverValue";
            this.CloudCoverValue.Size = new System.Drawing.Size(32, 17);
            this.CloudCoverValue.TabIndex = 26;
            this.CloudCoverValue.Text = "???";
            // 
            // SkyBrightnessLabel
            // 
            this.SkyBrightnessLabel.AutoSize = true;
            this.SkyBrightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyBrightnessLabel.Location = new System.Drawing.Point(4, 100);
            this.SkyBrightnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyBrightnessLabel.Name = "SkyBrightnessLabel";
            this.SkyBrightnessLabel.Size = new System.Drawing.Size(116, 17);
            this.SkyBrightnessLabel.TabIndex = 19;
            this.SkyBrightnessLabel.Text = "Sky Brightness";
            // 
            // RainRateLabel
            // 
            this.RainRateLabel.AutoSize = true;
            this.RainRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainRateLabel.Location = new System.Drawing.Point(4, 80);
            this.RainRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RainRateLabel.Name = "RainRateLabel";
            this.RainRateLabel.Size = new System.Drawing.Size(80, 17);
            this.RainRateLabel.TabIndex = 17;
            this.RainRateLabel.Text = "Rain Rate";
            // 
            // CloudCoverLabel
            // 
            this.CloudCoverLabel.AutoSize = true;
            this.CloudCoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloudCoverLabel.Location = new System.Drawing.Point(4, 0);
            this.CloudCoverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloudCoverLabel.Name = "CloudCoverLabel";
            this.CloudCoverLabel.Size = new System.Drawing.Size(96, 17);
            this.CloudCoverLabel.TabIndex = 15;
            this.CloudCoverLabel.Text = "Cloud Cover";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedLabel.Location = new System.Drawing.Point(4, 240);
            this.WindSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(95, 17);
            this.WindSpeedLabel.TabIndex = 25;
            this.WindSpeedLabel.Text = "Wind Speed";
            // 
            // WindSpeedValue
            // 
            this.WindSpeedValue.AutoSize = true;
            this.WindSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedValue.Location = new System.Drawing.Point(179, 240);
            this.WindSpeedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedValue.Name = "WindSpeedValue";
            this.WindSpeedValue.Size = new System.Drawing.Size(32, 17);
            this.WindSpeedValue.TabIndex = 31;
            this.WindSpeedValue.Text = "???";
            // 
            // WindGustValue
            // 
            this.WindGustValue.AutoSize = true;
            this.WindGustValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindGustValue.Location = new System.Drawing.Point(179, 220);
            this.WindGustValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindGustValue.Name = "WindGustValue";
            this.WindGustValue.Size = new System.Drawing.Size(32, 17);
            this.WindGustValue.TabIndex = 30;
            this.WindGustValue.Text = "???";
            // 
            // WindDirectionValue
            // 
            this.WindDirectionValue.AutoSize = true;
            this.WindDirectionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindDirectionValue.Location = new System.Drawing.Point(179, 200);
            this.WindDirectionValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindDirectionValue.Name = "WindDirectionValue";
            this.WindDirectionValue.Size = new System.Drawing.Size(32, 17);
            this.WindDirectionValue.TabIndex = 29;
            this.WindDirectionValue.Text = "???";
            // 
            // WindGustLabel
            // 
            this.WindGustLabel.AutoSize = true;
            this.WindGustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindGustLabel.Location = new System.Drawing.Point(4, 220);
            this.WindGustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindGustLabel.Name = "WindGustLabel";
            this.WindGustLabel.Size = new System.Drawing.Size(83, 17);
            this.WindGustLabel.TabIndex = 23;
            this.WindGustLabel.Text = "Wind Gust";
            // 
            // WindDirectionLabel
            // 
            this.WindDirectionLabel.AutoSize = true;
            this.WindDirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindDirectionLabel.Location = new System.Drawing.Point(4, 200);
            this.WindDirectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindDirectionLabel.Name = "WindDirectionLabel";
            this.WindDirectionLabel.Size = new System.Drawing.Size(114, 17);
            this.WindDirectionLabel.TabIndex = 21;
            this.WindDirectionLabel.Text = "Wind Direction";
            // 
            // SkyQualityValue
            // 
            this.SkyQualityValue.AutoSize = true;
            this.SkyQualityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyQualityValue.Location = new System.Drawing.Point(179, 120);
            this.SkyQualityValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyQualityValue.Name = "SkyQualityValue";
            this.SkyQualityValue.Size = new System.Drawing.Size(32, 17);
            this.SkyQualityValue.TabIndex = 32;
            this.SkyQualityValue.Text = "???";
            // 
            // StarFwhmValue
            // 
            this.StarFwhmValue.AutoSize = true;
            this.StarFwhmValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarFwhmValue.Location = new System.Drawing.Point(179, 140);
            this.StarFwhmValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StarFwhmValue.Name = "StarFwhmValue";
            this.StarFwhmValue.Size = new System.Drawing.Size(32, 17);
            this.StarFwhmValue.TabIndex = 33;
            this.StarFwhmValue.Text = "???";
            // 
            // SkyTemperatureValue
            // 
            this.SkyTemperatureValue.AutoSize = true;
            this.SkyTemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyTemperatureValue.Location = new System.Drawing.Point(179, 160);
            this.SkyTemperatureValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyTemperatureValue.Name = "SkyTemperatureValue";
            this.SkyTemperatureValue.Size = new System.Drawing.Size(32, 17);
            this.SkyTemperatureValue.TabIndex = 34;
            this.SkyTemperatureValue.Text = "???";
            // 
            // SkyQualityLabel
            // 
            this.SkyQualityLabel.AutoSize = true;
            this.SkyQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyQualityLabel.Location = new System.Drawing.Point(4, 120);
            this.SkyQualityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyQualityLabel.Name = "SkyQualityLabel";
            this.SkyQualityLabel.Size = new System.Drawing.Size(90, 17);
            this.SkyQualityLabel.TabIndex = 35;
            this.SkyQualityLabel.Text = "Sky Quality";
            // 
            // StarFwhmLabel
            // 
            this.StarFwhmLabel.AutoSize = true;
            this.StarFwhmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarFwhmLabel.Location = new System.Drawing.Point(4, 140);
            this.StarFwhmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StarFwhmLabel.Name = "StarFwhmLabel";
            this.StarFwhmLabel.Size = new System.Drawing.Size(89, 17);
            this.StarFwhmLabel.TabIndex = 36;
            this.StarFwhmLabel.Text = "Star FWHM";
            // 
            // SkyTemperatureLabel
            // 
            this.SkyTemperatureLabel.AutoSize = true;
            this.SkyTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyTemperatureLabel.Location = new System.Drawing.Point(4, 160);
            this.SkyTemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyTemperatureLabel.Name = "SkyTemperatureLabel";
            this.SkyTemperatureLabel.Size = new System.Drawing.Size(132, 17);
            this.SkyTemperatureLabel.TabIndex = 37;
            this.SkyTemperatureLabel.Text = "Sky Temperature";
            // 
            // CloudCoverDateTime
            // 
            this.CloudCoverDateTime.AutoSize = true;
            this.CloudCoverDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloudCoverDateTime.Location = new System.Drawing.Point(304, 0);
            this.CloudCoverDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloudCoverDateTime.Name = "CloudCoverDateTime";
            this.CloudCoverDateTime.Size = new System.Drawing.Size(32, 17);
            this.CloudCoverDateTime.TabIndex = 38;
            this.CloudCoverDateTime.Text = "???";
            // 
            // DewPointDateTime
            // 
            this.DewPointDateTime.AutoSize = true;
            this.DewPointDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DewPointDateTime.Location = new System.Drawing.Point(304, 20);
            this.DewPointDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DewPointDateTime.Name = "DewPointDateTime";
            this.DewPointDateTime.Size = new System.Drawing.Size(32, 17);
            this.DewPointDateTime.TabIndex = 39;
            this.DewPointDateTime.Text = "???";
            // 
            // HumidityDateTime
            // 
            this.HumidityDateTime.AutoSize = true;
            this.HumidityDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityDateTime.Location = new System.Drawing.Point(304, 40);
            this.HumidityDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumidityDateTime.Name = "HumidityDateTime";
            this.HumidityDateTime.Size = new System.Drawing.Size(32, 17);
            this.HumidityDateTime.TabIndex = 39;
            this.HumidityDateTime.Text = "???";
            // 
            // PressureDateTime
            // 
            this.PressureDateTime.AutoSize = true;
            this.PressureDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureDateTime.Location = new System.Drawing.Point(304, 60);
            this.PressureDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PressureDateTime.Name = "PressureDateTime";
            this.PressureDateTime.Size = new System.Drawing.Size(32, 17);
            this.PressureDateTime.TabIndex = 39;
            this.PressureDateTime.Text = "???";
            // 
            // RainRateDateTime
            // 
            this.RainRateDateTime.AutoSize = true;
            this.RainRateDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainRateDateTime.Location = new System.Drawing.Point(304, 80);
            this.RainRateDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RainRateDateTime.Name = "RainRateDateTime";
            this.RainRateDateTime.Size = new System.Drawing.Size(32, 17);
            this.RainRateDateTime.TabIndex = 39;
            this.RainRateDateTime.Text = "???";
            // 
            // SkyBrightnessDateTime
            // 
            this.SkyBrightnessDateTime.AutoSize = true;
            this.SkyBrightnessDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyBrightnessDateTime.Location = new System.Drawing.Point(304, 100);
            this.SkyBrightnessDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyBrightnessDateTime.Name = "SkyBrightnessDateTime";
            this.SkyBrightnessDateTime.Size = new System.Drawing.Size(32, 17);
            this.SkyBrightnessDateTime.TabIndex = 40;
            this.SkyBrightnessDateTime.Text = "???";
            // 
            // SkyQualityDateTime
            // 
            this.SkyQualityDateTime.AutoSize = true;
            this.SkyQualityDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyQualityDateTime.Location = new System.Drawing.Point(304, 120);
            this.SkyQualityDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyQualityDateTime.Name = "SkyQualityDateTime";
            this.SkyQualityDateTime.Size = new System.Drawing.Size(32, 17);
            this.SkyQualityDateTime.TabIndex = 41;
            this.SkyQualityDateTime.Text = "???";
            // 
            // StarFwhmDateTime
            // 
            this.StarFwhmDateTime.AutoSize = true;
            this.StarFwhmDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarFwhmDateTime.Location = new System.Drawing.Point(304, 140);
            this.StarFwhmDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StarFwhmDateTime.Name = "StarFwhmDateTime";
            this.StarFwhmDateTime.Size = new System.Drawing.Size(32, 17);
            this.StarFwhmDateTime.TabIndex = 42;
            this.StarFwhmDateTime.Text = "???";
            // 
            // SkyTemperatureDateTime
            // 
            this.SkyTemperatureDateTime.AutoSize = true;
            this.SkyTemperatureDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyTemperatureDateTime.Location = new System.Drawing.Point(304, 160);
            this.SkyTemperatureDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyTemperatureDateTime.Name = "SkyTemperatureDateTime";
            this.SkyTemperatureDateTime.Size = new System.Drawing.Size(32, 17);
            this.SkyTemperatureDateTime.TabIndex = 43;
            this.SkyTemperatureDateTime.Text = "???";
            // 
            // TemperatureDateTime
            // 
            this.TemperatureDateTime.AutoSize = true;
            this.TemperatureDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureDateTime.Location = new System.Drawing.Point(304, 180);
            this.TemperatureDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureDateTime.Name = "TemperatureDateTime";
            this.TemperatureDateTime.Size = new System.Drawing.Size(32, 17);
            this.TemperatureDateTime.TabIndex = 44;
            this.TemperatureDateTime.Text = "???";
            // 
            // WindDirectionDateTime
            // 
            this.WindDirectionDateTime.AutoSize = true;
            this.WindDirectionDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindDirectionDateTime.Location = new System.Drawing.Point(304, 200);
            this.WindDirectionDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindDirectionDateTime.Name = "WindDirectionDateTime";
            this.WindDirectionDateTime.Size = new System.Drawing.Size(32, 17);
            this.WindDirectionDateTime.TabIndex = 45;
            this.WindDirectionDateTime.Text = "???";
            // 
            // WindGustDateTime
            // 
            this.WindGustDateTime.AutoSize = true;
            this.WindGustDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindGustDateTime.Location = new System.Drawing.Point(304, 220);
            this.WindGustDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindGustDateTime.Name = "WindGustDateTime";
            this.WindGustDateTime.Size = new System.Drawing.Size(32, 17);
            this.WindGustDateTime.TabIndex = 46;
            this.WindGustDateTime.Text = "???";
            // 
            // WindSpeedDateTime
            // 
            this.WindSpeedDateTime.AutoSize = true;
            this.WindSpeedDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedDateTime.Location = new System.Drawing.Point(304, 240);
            this.WindSpeedDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedDateTime.Name = "WindSpeedDateTime";
            this.WindSpeedDateTime.Size = new System.Drawing.Size(32, 17);
            this.WindSpeedDateTime.TabIndex = 47;
            this.WindSpeedDateTime.Text = "???";
            // 
            // CloudCoverDescription
            // 
            this.CloudCoverDescription.AutoSize = true;
            this.CloudCoverDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloudCoverDescription.Location = new System.Drawing.Point(429, 0);
            this.CloudCoverDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloudCoverDescription.Name = "CloudCoverDescription";
            this.CloudCoverDescription.Size = new System.Drawing.Size(32, 17);
            this.CloudCoverDescription.TabIndex = 39;
            this.CloudCoverDescription.Text = "???";
            // 
            // DewPointDescription
            // 
            this.DewPointDescription.AutoSize = true;
            this.DewPointDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DewPointDescription.Location = new System.Drawing.Point(429, 20);
            this.DewPointDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DewPointDescription.Name = "DewPointDescription";
            this.DewPointDescription.Size = new System.Drawing.Size(32, 17);
            this.DewPointDescription.TabIndex = 40;
            this.DewPointDescription.Text = "???";
            // 
            // HumidityDescription
            // 
            this.HumidityDescription.AutoSize = true;
            this.HumidityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityDescription.Location = new System.Drawing.Point(429, 40);
            this.HumidityDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumidityDescription.Name = "HumidityDescription";
            this.HumidityDescription.Size = new System.Drawing.Size(32, 17);
            this.HumidityDescription.TabIndex = 48;
            this.HumidityDescription.Text = "???";
            // 
            // PressureDescription
            // 
            this.PressureDescription.AutoSize = true;
            this.PressureDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureDescription.Location = new System.Drawing.Point(429, 60);
            this.PressureDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PressureDescription.Name = "PressureDescription";
            this.PressureDescription.Size = new System.Drawing.Size(32, 17);
            this.PressureDescription.TabIndex = 49;
            this.PressureDescription.Text = "???";
            // 
            // RainRateDescription
            // 
            this.RainRateDescription.AutoSize = true;
            this.RainRateDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RainRateDescription.Location = new System.Drawing.Point(429, 80);
            this.RainRateDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RainRateDescription.Name = "RainRateDescription";
            this.RainRateDescription.Size = new System.Drawing.Size(32, 17);
            this.RainRateDescription.TabIndex = 50;
            this.RainRateDescription.Text = "???";
            // 
            // SkyBrightnessDescription
            // 
            this.SkyBrightnessDescription.AutoSize = true;
            this.SkyBrightnessDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyBrightnessDescription.Location = new System.Drawing.Point(429, 100);
            this.SkyBrightnessDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyBrightnessDescription.Name = "SkyBrightnessDescription";
            this.SkyBrightnessDescription.Size = new System.Drawing.Size(32, 17);
            this.SkyBrightnessDescription.TabIndex = 51;
            this.SkyBrightnessDescription.Text = "???";
            // 
            // SkyQualityDescription
            // 
            this.SkyQualityDescription.AutoSize = true;
            this.SkyQualityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyQualityDescription.Location = new System.Drawing.Point(429, 120);
            this.SkyQualityDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyQualityDescription.Name = "SkyQualityDescription";
            this.SkyQualityDescription.Size = new System.Drawing.Size(32, 17);
            this.SkyQualityDescription.TabIndex = 52;
            this.SkyQualityDescription.Text = "???";
            // 
            // StarFwhmDescription
            // 
            this.StarFwhmDescription.AutoSize = true;
            this.StarFwhmDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarFwhmDescription.Location = new System.Drawing.Point(429, 140);
            this.StarFwhmDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StarFwhmDescription.Name = "StarFwhmDescription";
            this.StarFwhmDescription.Size = new System.Drawing.Size(32, 17);
            this.StarFwhmDescription.TabIndex = 53;
            this.StarFwhmDescription.Text = "???";
            // 
            // SkyTemperatureDescription
            // 
            this.SkyTemperatureDescription.AutoSize = true;
            this.SkyTemperatureDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyTemperatureDescription.Location = new System.Drawing.Point(429, 160);
            this.SkyTemperatureDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SkyTemperatureDescription.Name = "SkyTemperatureDescription";
            this.SkyTemperatureDescription.Size = new System.Drawing.Size(32, 17);
            this.SkyTemperatureDescription.TabIndex = 54;
            this.SkyTemperatureDescription.Text = "???";
            // 
            // TemperatureDescription
            // 
            this.TemperatureDescription.AutoSize = true;
            this.TemperatureDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureDescription.Location = new System.Drawing.Point(429, 180);
            this.TemperatureDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureDescription.Name = "TemperatureDescription";
            this.TemperatureDescription.Size = new System.Drawing.Size(32, 17);
            this.TemperatureDescription.TabIndex = 55;
            this.TemperatureDescription.Text = "???";
            // 
            // WindDirectionDescription
            // 
            this.WindDirectionDescription.AutoSize = true;
            this.WindDirectionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindDirectionDescription.Location = new System.Drawing.Point(429, 200);
            this.WindDirectionDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindDirectionDescription.Name = "WindDirectionDescription";
            this.WindDirectionDescription.Size = new System.Drawing.Size(32, 17);
            this.WindDirectionDescription.TabIndex = 56;
            this.WindDirectionDescription.Text = "???";
            // 
            // WindGustDescription
            // 
            this.WindGustDescription.AutoSize = true;
            this.WindGustDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindGustDescription.Location = new System.Drawing.Point(429, 220);
            this.WindGustDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindGustDescription.Name = "WindGustDescription";
            this.WindGustDescription.Size = new System.Drawing.Size(32, 17);
            this.WindGustDescription.TabIndex = 57;
            this.WindGustDescription.Text = "???";
            // 
            // WindSpeedDescription
            // 
            this.WindSpeedDescription.AutoSize = true;
            this.WindSpeedDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedDescription.Location = new System.Drawing.Point(429, 240);
            this.WindSpeedDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedDescription.Name = "WindSpeedDescription";
            this.WindSpeedDescription.Size = new System.Drawing.Size(32, 17);
            this.WindSpeedDescription.TabIndex = 58;
            this.WindSpeedDescription.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Observing Conditions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label DewPointLabel;
        private System.Windows.Forms.Label DewPointValue;
        private System.Windows.Forms.Label PressureValue;
        private System.Windows.Forms.Label HumidityValue;
        private System.Windows.Forms.Label TemperatureValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label WindGustLabel;
        private System.Windows.Forms.Label WindDirectionLabel;
        private System.Windows.Forms.Label SkyBrightnessLabel;
        private System.Windows.Forms.Label RainRateLabel;
        private System.Windows.Forms.Label CloudCoverLabel;
        private System.Windows.Forms.Label WindSpeedValue;
        private System.Windows.Forms.Label WindGustValue;
        private System.Windows.Forms.Label WindDirectionValue;
        private System.Windows.Forms.Label SkyBrightnessValue;
        private System.Windows.Forms.Label RainRateValue;
        private System.Windows.Forms.Label CloudCoverValue;
        private System.Windows.Forms.Label SkyQualityValue;
        private System.Windows.Forms.Label StarFwhmValue;
        private System.Windows.Forms.Label SkyTemperatureValue;
        private System.Windows.Forms.Label SkyQualityLabel;
        private System.Windows.Forms.Label StarFwhmLabel;
        private System.Windows.Forms.Label SkyTemperatureLabel;
        private System.Windows.Forms.Label SkyBrightnessDateTime;
        private System.Windows.Forms.Label RainRateDateTime;
        private System.Windows.Forms.Label PressureDateTime;
        private System.Windows.Forms.Label HumidityDateTime;
        private System.Windows.Forms.Label DewPointDateTime;
        private System.Windows.Forms.Label CloudCoverDateTime;
        private System.Windows.Forms.Label WindSpeedDateTime;
        private System.Windows.Forms.Label WindGustDateTime;
        private System.Windows.Forms.Label WindDirectionDateTime;
        private System.Windows.Forms.Label TemperatureDateTime;
        private System.Windows.Forms.Label SkyTemperatureDateTime;
        private System.Windows.Forms.Label StarFwhmDateTime;
        private System.Windows.Forms.Label SkyQualityDateTime;
        private System.Windows.Forms.Label WindSpeedDescription;
        private System.Windows.Forms.Label WindGustDescription;
        private System.Windows.Forms.Label WindDirectionDescription;
        private System.Windows.Forms.Label TemperatureDescription;
        private System.Windows.Forms.Label SkyTemperatureDescription;
        private System.Windows.Forms.Label StarFwhmDescription;
        private System.Windows.Forms.Label SkyQualityDescription;
        private System.Windows.Forms.Label SkyBrightnessDescription;
        private System.Windows.Forms.Label RainRateDescription;
        private System.Windows.Forms.Label PressureDescription;
        private System.Windows.Forms.Label HumidityDescription;
        private System.Windows.Forms.Label DewPointDescription;
        private System.Windows.Forms.Label CloudCoverDescription;
    }
}


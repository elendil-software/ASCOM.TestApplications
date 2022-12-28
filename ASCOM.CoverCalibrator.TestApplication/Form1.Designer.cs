namespace ASCOM.CoverCalibrator.TestApplication
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
            ASCOM.CoverCalibrator.TestApplication.Properties.Settings settings1 = new ASCOM.CoverCalibrator.TestApplication.Properties.Settings();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.checkBoxLightOnOff = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCalibratorState = new System.Windows.Forms.TextBox();
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
            settings1.DriverId = "";
            settings1.SettingsKey = "";
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings1, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(12, 40);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(291, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxLightOnOff
            // 
            this.checkBoxLightOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLightOnOff.Location = new System.Drawing.Point(135, 94);
            this.checkBoxLightOnOff.Name = "checkBoxLightOnOff";
            this.checkBoxLightOnOff.Size = new System.Drawing.Size(72, 23);
            this.checkBoxLightOnOff.TabIndex = 4;
            this.checkBoxLightOnOff.Text = "Light On";
            this.checkBoxLightOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxLightOnOff.UseVisualStyleBackColor = true;
            this.checkBoxLightOnOff.CheckedChanged += new System.EventHandler(this.checkBoxLightOnOff_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calibrator state";
            // 
            // textBoxCalibratorState
            // 
            this.textBoxCalibratorState.Location = new System.Drawing.Point(107, 68);
            this.textBoxCalibratorState.Name = "textBoxCalibratorState";
            this.textBoxCalibratorState.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalibratorState.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 134);
            this.Controls.Add(this.textBoxCalibratorState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxLightOnOff);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "Safety Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxCalibratorState;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.CheckBox checkBoxLightOnOff;

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
    }
}


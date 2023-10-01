namespace ASCOM.FilterWheel.TestApplication
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
            ASCOM.FilterWheel.TestApplication.Properties.Settings settings1 = new ASCOM.FilterWheel.TestApplication.Properties.Settings();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.labelDriverInfo = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelDriverInfoValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCurrentPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
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
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.Location = new System.Drawing.Point(118, 119);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.Size = new System.Drawing.Size(278, 23);
            this.labelDescriptionValue.TabIndex = 19;
            this.labelDescriptionValue.Text = "Description";
            // 
            // labelDriverInfo
            // 
            this.labelDriverInfo.Location = new System.Drawing.Point(12, 96);
            this.labelDriverInfo.Name = "labelDriverInfo";
            this.labelDriverInfo.Size = new System.Drawing.Size(100, 23);
            this.labelDriverInfo.TabIndex = 18;
            this.labelDriverInfo.Text = "DriverInfo";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(12, 119);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 23);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Description";
            // 
            // labelNameValue
            // 
            this.labelNameValue.Location = new System.Drawing.Point(118, 73);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(278, 23);
            this.labelNameValue.TabIndex = 16;
            this.labelNameValue.Text = "Name";
            // 
            // labelDriverInfoValue
            // 
            this.labelDriverInfoValue.Location = new System.Drawing.Point(118, 96);
            this.labelDriverInfoValue.Name = "labelDriverInfoValue";
            this.labelDriverInfoValue.Size = new System.Drawing.Size(278, 23);
            this.labelDriverInfoValue.TabIndex = 15;
            this.labelDriverInfoValue.Text = "DriverInfo";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // textBoxCurrentPosition
            // 
            this.textBoxCurrentPosition.Location = new System.Drawing.Point(118, 139);
            this.textBoxCurrentPosition.Name = "textBoxCurrentPosition";
            this.textBoxCurrentPosition.ReadOnly = true;
            this.textBoxCurrentPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentPosition.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Position";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(143, 193);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 26;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(12, 195);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilters.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 237);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.textBoxCurrentPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDriverInfo);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNameValue);
            this.Controls.Add(this.labelDriverInfoValue);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "Filter Wheel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxFilters;

        private System.Windows.Forms.TextBox textBoxCurrentPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMove;

        private System.Windows.Forms.Label labelDescriptionValue;
        private System.Windows.Forms.Label labelDriverInfo;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.Label labelDriverInfoValue;
        private System.Windows.Forms.Label labelName;

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
    }
}


namespace ASCOM.SafetyMonitor.TestApplication
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
            this.readButton = new System.Windows.Forms.Button();
            this.isSafelabel = new System.Windows.Forms.Label();
            this.isSafeValue = new System.Windows.Forms.Label();
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
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.SafetyMonitor.TestApplication.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(12, 40);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(291, 21);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.SafetyMonitor.TestApplication.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(306, 84);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // isSafelabel
            // 
            this.isSafelabel.AutoSize = true;
            this.isSafelabel.Location = new System.Drawing.Point(12, 94);
            this.isSafelabel.Name = "isSafelabel";
            this.isSafelabel.Size = new System.Drawing.Size(46, 13);
            this.isSafelabel.TabIndex = 4;
            this.isSafelabel.Text = "Is Safe :";
            // 
            // isSafeValue
            // 
            this.isSafeValue.AutoSize = true;
            this.isSafeValue.Location = new System.Drawing.Point(64, 94);
            this.isSafeValue.Name = "isSafeValue";
            this.isSafeValue.Size = new System.Drawing.Size(13, 13);
            this.isSafeValue.TabIndex = 5;
            this.isSafeValue.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 124);
            this.Controls.Add(this.isSafeValue);
            this.Controls.Add(this.isSafelabel);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label isSafelabel;
        private System.Windows.Forms.Label isSafeValue;
    }
}


namespace ASCOM.Dome.TestApplication
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
            this.buttonOpenShutter = new System.Windows.Forms.Button();
            this.buttonCloseShutter = new System.Windows.Forms.Button();
            this.textBoxShutterState = new System.Windows.Forms.TextBox();
            this.labelShuterState = new System.Windows.Forms.Label();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(412, 12);
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
            this.buttonConnect.Location = new System.Drawing.Point(412, 48);
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
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.Dome.TestApplication.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(16, 49);
            this.labelDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(387, 25);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.Dome.TestApplication.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOpenShutter
            // 
            this.buttonOpenShutter.Location = new System.Drawing.Point(17, 101);
            this.buttonOpenShutter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenShutter.Name = "buttonOpenShutter";
            this.buttonOpenShutter.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenShutter.TabIndex = 3;
            this.buttonOpenShutter.Text = "OpenShutter";
            this.buttonOpenShutter.UseVisualStyleBackColor = true;
            this.buttonOpenShutter.Click += new System.EventHandler(this.buttonOpenShutter_Click);
            // 
            // buttonCloseShutter
            // 
            this.buttonCloseShutter.Location = new System.Drawing.Point(125, 101);
            this.buttonCloseShutter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCloseShutter.Name = "buttonCloseShutter";
            this.buttonCloseShutter.Size = new System.Drawing.Size(100, 28);
            this.buttonCloseShutter.TabIndex = 4;
            this.buttonCloseShutter.Text = "CloseShutter";
            this.buttonCloseShutter.UseVisualStyleBackColor = true;
            this.buttonCloseShutter.Click += new System.EventHandler(this.buttonCloseShutter_Click);
            // 
            // textBoxShutterState
            // 
            this.textBoxShutterState.Location = new System.Drawing.Point(84, 142);
            this.textBoxShutterState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxShutterState.Name = "textBoxShutterState";
            this.textBoxShutterState.Size = new System.Drawing.Size(132, 22);
            this.textBoxShutterState.TabIndex = 5;
            // 
            // labelShuterState
            // 
            this.labelShuterState.AutoSize = true;
            this.labelShuterState.Location = new System.Drawing.Point(16, 145);
            this.labelShuterState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShuterState.Name = "labelShuterState";
            this.labelShuterState.Size = new System.Drawing.Size(48, 17);
            this.labelShuterState.TabIndex = 6;
            this.labelShuterState.Text = "Status";
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(233, 101);
            this.buttonAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(100, 28);
            this.buttonAbort.TabIndex = 7;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 322);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.labelShuterState);
            this.Controls.Add(this.textBoxShutterState);
            this.Controls.Add(this.buttonCloseShutter);
            this.Controls.Add(this.buttonOpenShutter);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Dome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button buttonOpenShutter;
        private System.Windows.Forms.Button buttonCloseShutter;
        private System.Windows.Forms.TextBox textBoxShutterState;
		private System.Windows.Forms.Label labelShuterState;
		private System.Windows.Forms.Button buttonAbort;
    }
}


namespace ASCOM.Rotator.TestApplication
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
            ASCOM.Rotator.TestApplication.Properties.Settings settings1 = new ASCOM.Rotator.TestApplication.Properties.Settings();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIsMoving = new System.Windows.Forms.TextBox();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.labelDriverInfo = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelDriverInfoValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxMechanicalPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCurrentPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.buttonSync = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "IsMoving";
            // 
            // textBoxIsMoving
            // 
            this.textBoxIsMoving.Location = new System.Drawing.Point(118, 150);
            this.textBoxIsMoving.Name = "textBoxIsMoving";
            this.textBoxIsMoving.ReadOnly = true;
            this.textBoxIsMoving.Size = new System.Drawing.Size(100, 20);
            this.textBoxIsMoving.TabIndex = 6;
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
            // textBoxMechanicalPosition
            // 
            this.textBoxMechanicalPosition.Location = new System.Drawing.Point(118, 176);
            this.textBoxMechanicalPosition.Name = "textBoxMechanicalPosition";
            this.textBoxMechanicalPosition.ReadOnly = true;
            this.textBoxMechanicalPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxMechanicalPosition.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mechanical Pos.";
            // 
            // textBoxCurrentPosition
            // 
            this.textBoxCurrentPosition.Location = new System.Drawing.Point(118, 202);
            this.textBoxCurrentPosition.Name = "textBoxCurrentPosition";
            this.textBoxCurrentPosition.ReadOnly = true;
            this.textBoxCurrentPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentPosition.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Position";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(118, 268);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 26;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(118, 297);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 27;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(12, 270);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 2;
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(199, 267);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(75, 23);
            this.buttonSync.TabIndex = 29;
            this.buttonSync.Text = "Sync";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 439);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.textBoxCurrentPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMechanicalPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDriverInfo);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNameValue);
            this.Controls.Add(this.labelDriverInfoValue);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxIsMoving);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Name = "Form1";
            this.Text = "Safety Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonSync;

        private System.Windows.Forms.TextBox textBoxPosition;

        private System.Windows.Forms.TextBox textBoxCurrentPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonStop;

        private System.Windows.Forms.TextBox textBoxMechanicalPosition;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label labelDescriptionValue;
        private System.Windows.Forms.Label labelDriverInfo;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.Label labelDriverInfoValue;
        private System.Windows.Forms.Label labelName;

        private System.Windows.Forms.TextBox textBoxIsMoving;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
    }
}


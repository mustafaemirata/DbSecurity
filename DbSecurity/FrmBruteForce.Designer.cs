namespace DbSecurity
{
    partial class FrmBruteForce
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerip = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDbname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstPasswordList = new System.Windows.Forms.ListBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "DbName";
            // 
            // txtServerip
            // 
            this.txtServerip.Location = new System.Drawing.Point(252, 154);
            this.txtServerip.Name = "txtServerip";
            this.txtServerip.Size = new System.Drawing.Size(264, 34);
            this.txtServerip.TabIndex = 4;
            this.txtServerip.Text = "192.168.84.128";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(252, 224);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(264, 34);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "SA";
            // 
            // txtDbname
            // 
            this.txtDbname.Location = new System.Drawing.Point(252, 296);
            this.txtDbname.Name = "txtDbname";
            this.txtDbname.Size = new System.Drawing.Size(264, 34);
            this.txtDbname.TabIndex = 6;
            this.txtDbname.Text = "MASTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(725, 154);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(67, 34);
            this.txtCount.TabIndex = 8;
            this.txtCount.Text = "1000";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(70, 369);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(27, 28);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "...";
            // 
            // lstPasswordList
            // 
            this.lstPasswordList.FormattingEnabled = true;
            this.lstPasswordList.ItemHeight = 28;
            this.lstPasswordList.Location = new System.Drawing.Point(75, 423);
            this.lstPasswordList.Name = "lstPasswordList";
            this.lstPasswordList.Size = new System.Drawing.Size(441, 284);
            this.lstPasswordList.TabIndex = 10;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(639, 224);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(153, 47);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // FrmBruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 729);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.lstPasswordList);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDbname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServerip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBruteForce";
            this.Text = "FrmBruteForce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerip;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstPasswordList;
        private System.Windows.Forms.Button startBtn;
    }
}
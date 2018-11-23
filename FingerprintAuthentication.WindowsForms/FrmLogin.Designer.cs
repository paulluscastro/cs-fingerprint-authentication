namespace FingerprintAuthentication.WindowsForms
{
    partial class FrmLogin
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
            this.pnFingerAuthentication = new System.Windows.Forms.Panel();
            this.lnkPassword = new System.Windows.Forms.LinkLabel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPlaceFinger = new System.Windows.Forms.Label();
            this.pnPasswordAuthentication = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnFingerAuthentication.SuspendLayout();
            this.pnPasswordAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFingerAuthentication
            // 
            this.pnFingerAuthentication.Controls.Add(this.lnkPassword);
            this.pnFingerAuthentication.Controls.Add(this.lbUserName);
            this.pnFingerAuthentication.Controls.Add(this.lbPlaceFinger);
            this.pnFingerAuthentication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFingerAuthentication.Location = new System.Drawing.Point(0, 0);
            this.pnFingerAuthentication.Name = "pnFingerAuthentication";
            this.pnFingerAuthentication.Size = new System.Drawing.Size(326, 194);
            this.pnFingerAuthentication.TabIndex = 1;
            // 
            // lnkPassword
            // 
            this.lnkPassword.AutoSize = true;
            this.lnkPassword.Location = new System.Drawing.Point(187, 156);
            this.lnkPassword.Margin = new System.Windows.Forms.Padding(3, 0, 16, 16);
            this.lnkPassword.Name = "lnkPassword";
            this.lnkPassword.Size = new System.Drawing.Size(114, 13);
            this.lnkPassword.TabIndex = 7;
            this.lnkPassword.TabStop = true;
            this.lnkPassword.Text = "User password instead";
            this.lnkPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowPasswordAuthentication);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(16, 45);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(16);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(115, 13);
            this.lbUserName.TabIndex = 6;
            this.lbUserName.Text = "Place your finger...";
            // 
            // lbPlaceFinger
            // 
            this.lbPlaceFinger.AutoSize = true;
            this.lbPlaceFinger.Location = new System.Drawing.Point(16, 16);
            this.lbPlaceFinger.Margin = new System.Windows.Forms.Padding(16, 16, 3, 0);
            this.lbPlaceFinger.Name = "lbPlaceFinger";
            this.lbPlaceFinger.Size = new System.Drawing.Size(95, 13);
            this.lbPlaceFinger.TabIndex = 5;
            this.lbPlaceFinger.Text = "Place your finger...";
            // 
            // pnPasswordAuthentication
            // 
            this.pnPasswordAuthentication.Controls.Add(this.btnConfirm);
            this.pnPasswordAuthentication.Controls.Add(this.btnCancel);
            this.pnPasswordAuthentication.Controls.Add(this.lbPassword);
            this.pnPasswordAuthentication.Controls.Add(this.txtPassword);
            this.pnPasswordAuthentication.Controls.Add(this.lbLogin);
            this.pnPasswordAuthentication.Controls.Add(this.txtLogin);
            this.pnPasswordAuthentication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPasswordAuthentication.Location = new System.Drawing.Point(0, 0);
            this.pnPasswordAuthentication.Name = "pnPasswordAuthentication";
            this.pnPasswordAuthentication.Size = new System.Drawing.Size(326, 194);
            this.pnPasswordAuthentication.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(201, 126);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(53, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(50, 84);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(53, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(50, 45);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(16, 16, 3, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 7;
            this.lbLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(53, 61);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(223, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 194);
            this.Controls.Add(this.pnPasswordAuthentication);
            this.Controls.Add(this.pnFingerAuthentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.pnFingerAuthentication.ResumeLayout(false);
            this.pnFingerAuthentication.PerformLayout();
            this.pnPasswordAuthentication.ResumeLayout(false);
            this.pnPasswordAuthentication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFingerAuthentication;
        private System.Windows.Forms.LinkLabel lnkPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPlaceFinger;
        private System.Windows.Forms.Panel pnPasswordAuthentication;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtLogin;
    }
}
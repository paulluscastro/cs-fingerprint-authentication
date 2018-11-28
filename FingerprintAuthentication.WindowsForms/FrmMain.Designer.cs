namespace FingerprintAuthentication.WindowsForms
{
    partial class FrmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFinger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuUser});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogoff,
            this.mnuClose});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(57, 20);
            this.mnuSystem.Text = "System";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(180, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.CloseProgram);
            // 
            // mnuUser
            // 
            this.mnuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewUser,
            this.mnuNewFinger});
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(47, 20);
            this.mnuUser.Text = "Users";
            // 
            // mnuNewUser
            // 
            this.mnuNewUser.Name = "mnuNewUser";
            this.mnuNewUser.Size = new System.Drawing.Size(180, 22);
            this.mnuNewUser.Text = "Create new user";
            this.mnuNewUser.Click += new System.EventHandler(this.mnuNewUser_Click);
            // 
            // mnuNewFinger
            // 
            this.mnuNewFinger.Name = "mnuNewFinger";
            this.mnuNewFinger.Size = new System.Drawing.Size(180, 22);
            this.mnuNewFinger.Text = "Register new finger";
            this.mnuNewFinger.Click += new System.EventHandler(this.mnuNewFinger_Click);
            // 
            // mnuLogoff
            // 
            this.mnuLogoff.Name = "mnuLogoff";
            this.mnuLogoff.Size = new System.Drawing.Size(180, 22);
            this.mnuLogoff.Text = "Logoff";
            this.mnuLogoff.Click += new System.EventHandler(this.mnuLogoff_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuNewUser;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFinger;
        private System.Windows.Forms.ToolStripMenuItem mnuLogoff;
    }
}


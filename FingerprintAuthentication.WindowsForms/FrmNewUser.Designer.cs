namespace FingerprintAuthentication.WindowsForms
{
    partial class FrmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewUser));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnFingers = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddFinger = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveFinger = new System.Windows.Forms.ToolStripButton();
            this.dgFingers = new System.Windows.Forms.DataGridView();
            this.Finger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnFingers.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFingers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(239, 280);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(25, 64);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(286, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(25, 25);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(16, 16, 3, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 13;
            this.lbLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(28, 41);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(286, 20);
            this.txtLogin.TabIndex = 12;
            // 
            // pnFingers
            // 
            this.pnFingers.Controls.Add(this.dgFingers);
            this.pnFingers.Controls.Add(this.toolStrip1);
            this.pnFingers.Location = new System.Drawing.Point(28, 106);
            this.pnFingers.Name = "pnFingers";
            this.pnFingers.Size = new System.Drawing.Size(286, 168);
            this.pnFingers.TabIndex = 18;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFinger,
            this.btnRemoveFinger});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddFinger
            // 
            this.btnAddFinger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddFinger.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFinger.Image")));
            this.btnAddFinger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFinger.Name = "btnAddFinger";
            this.btnAddFinger.Size = new System.Drawing.Size(33, 22);
            this.btnAddFinger.Text = "Add";
            // 
            // btnRemoveFinger
            // 
            this.btnRemoveFinger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveFinger.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveFinger.Image")));
            this.btnRemoveFinger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveFinger.Name = "btnRemoveFinger";
            this.btnRemoveFinger.Size = new System.Drawing.Size(54, 22);
            this.btnRemoveFinger.Text = "Remove";
            // 
            // dgFingers
            // 
            this.dgFingers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFingers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFingers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Finger,
            this.Side});
            this.dgFingers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFingers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgFingers.Location = new System.Drawing.Point(0, 25);
            this.dgFingers.MultiSelect = false;
            this.dgFingers.Name = "dgFingers";
            this.dgFingers.Size = new System.Drawing.Size(286, 143);
            this.dgFingers.TabIndex = 1;
            // 
            // Finger
            // 
            this.Finger.DataPropertyName = "Finger.Name";
            this.Finger.HeaderText = "Finger Name";
            this.Finger.Name = "Finger";
            this.Finger.ReadOnly = true;
            this.Finger.Width = 92;
            // 
            // Side
            // 
            this.Side.DataPropertyName = "Side.Name";
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Width = 53;
            // 
            // FrmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 315);
            this.Controls.Add(this.pnFingers);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewUser";
            this.Text = "New User";
            this.pnFingers.ResumeLayout(false);
            this.pnFingers.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFingers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel pnFingers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgFingers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.ToolStripButton btnAddFinger;
        private System.Windows.Forms.ToolStripButton btnRemoveFinger;
    }
}
namespace FingerprintAuthentication.WindowsForms
{
    partial class FrmAddFinger
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
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbSelectFinger = new System.Windows.Forms.Label();
            this.cmbFingers = new System.Windows.Forms.ComboBox();
            this.cmbSides = new System.Windows.Forms.ComboBox();
            this.lbSelectSide = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Location = new System.Drawing.Point(285, 428);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 17;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.CaptureFinger);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(28, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelAndAbort);
            // 
            // lbSelectFinger
            // 
            this.lbSelectFinger.AutoSize = true;
            this.lbSelectFinger.Location = new System.Drawing.Point(25, 25);
            this.lbSelectFinger.Margin = new System.Windows.Forms.Padding(16, 16, 3, 0);
            this.lbSelectFinger.Name = "lbSelectFinger";
            this.lbSelectFinger.Size = new System.Drawing.Size(84, 13);
            this.lbSelectFinger.TabIndex = 13;
            this.lbSelectFinger.Text = "Select the finger";
            // 
            // cmbFingers
            // 
            this.cmbFingers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFingers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFingers.FormattingEnabled = true;
            this.cmbFingers.Location = new System.Drawing.Point(28, 41);
            this.cmbFingers.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.cmbFingers.Name = "cmbFingers";
            this.cmbFingers.Size = new System.Drawing.Size(332, 21);
            this.cmbFingers.TabIndex = 18;
            // 
            // cmbSides
            // 
            this.cmbSides.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSides.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSides.FormattingEnabled = true;
            this.cmbSides.Location = new System.Drawing.Point(28, 84);
            this.cmbSides.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.cmbSides.Name = "cmbSides";
            this.cmbSides.Size = new System.Drawing.Size(332, 21);
            this.cmbSides.TabIndex = 20;
            // 
            // lbSelectSide
            // 
            this.lbSelectSide.AutoSize = true;
            this.lbSelectSide.Location = new System.Drawing.Point(25, 68);
            this.lbSelectSide.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.lbSelectSide.Name = "lbSelectSide";
            this.lbSelectSide.Size = new System.Drawing.Size(77, 13);
            this.lbSelectSide.TabIndex = 19;
            this.lbSelectSide.Text = "Select the side";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(28, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 311);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAddFinger
            // 
            this.AcceptButton = this.btnCapture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(372, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbSides);
            this.Controls.Add(this.lbSelectSide);
            this.Controls.Add(this.cmbFingers);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbSelectFinger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddFinger";
            this.Text = "Add finger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSelectFinger;
        private System.Windows.Forms.ComboBox cmbFingers;
        private System.Windows.Forms.ComboBox cmbSides;
        private System.Windows.Forms.Label lbSelectSide;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using FingerprintAuthentication.Commons.Utils;
using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintAuthentication.WindowsForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            pnPasswordAuthentication.Visible = false;
            pnFingerAuthentication.Visible = true;
        }

        private void LoginByPassword()
        {
            FingerContext ctx = new FingerContext();
            User user = ctx.Users.Where(u => u.Login == txtLogin.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Invalid login/password", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Password == CryptoUtils.HashMD5(txtPassword.Text, txtLogin.Text))
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Invalid login/password", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowPasswordAuthentication(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnPasswordAuthentication.Visible = true;
            pnFingerAuthentication.Visible = false;
            AcceptButton = btnConfirm;
            CancelButton = btnCancel;
        }

        private void Confirm(object sender, EventArgs e) =>LoginByPassword();
    }
}

using FingerprintAuthentication.Commons.Utils;
using FingerprintAuthentication.Commons.Validation;
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
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            User user = new User(txtName.Text, txtLogin.Text);
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("As senhas não são iguais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.SetPassword(txtPassword.Text);
            List<ValidationResult> result = user.Validate();
            if (result.Count != 0)
            {
                string message = string.Join(Environment.NewLine, result.Select(r => r.Code + " - " + r.Message).ToArray());
                MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FingerContext ctx = new FingerContext();
            ctx.Users.Add(user);
            ctx.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}

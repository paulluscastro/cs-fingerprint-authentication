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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            mnuNewUser.Visible = Program.CurrentUser.Login == "00000";
            mnuNewFinger.Visible = Program.CurrentUser.Login != "00000";
        }

        private void CloseProgram(object sender, EventArgs e) =>Application.Exit();

        private void mnuNewUser_Click(object sender, EventArgs e)
        {
            using (FrmNewUser window = new FrmNewUser())
                window.ShowDialog();
        }

        private void mnuNewFinger_Click(object sender, EventArgs e)
        {
            using (FrmAddFinger window = new FrmAddFinger())
                window.NewFinger();
        }

        private void mnuLogoff_Click(object sender, EventArgs e)
        {
            Program.Logoff();
        }
    }
}

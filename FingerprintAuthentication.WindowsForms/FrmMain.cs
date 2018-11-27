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
        }

        private void CloseProgram(object sender, EventArgs e) =>Application.Exit();

        private void mnuNewUser_Click(object sender, EventArgs e)
        {
            using (FrmNewUser window = new FrmNewUser())
                window.ShowDialog();
        }
    }
}

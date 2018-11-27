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
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void btnAddFinger_Click(object sender, EventArgs e)
        {
            using (FrmAddFinger window = new FrmAddFinger())
                window.ShowDialog();
        }
    }
}

using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Utils;
using FingerprintAuthentication.Domain.Enums;
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
using static NITGEN.SDK.NBioBSP.NBioAPI.Type;

namespace FingerprintAuthentication.WindowsForms
{
    public partial class FrmAddFinger : Form
    {
        private FingersIndex index = FingersIndex.GetInstance();
        public FrmAddFinger()
        {
            InitializeComponent();
            FillFingers();
            FillSides();
            index.ForeColor = SystemColors.Window;
            index.BackgroundColor = Color.FromArgb(34, 51, 60);
        }
        private void FillFingers()
        {
            Finger[] fingers = Finger.List();
            cmbFingers.Items.Clear();
            cmbFingers.ValueMember = "Id";
            cmbFingers.DisplayMember = "Name";
            cmbFingers.DataSource = fingers;
        }
        private void FillSides()
        {
            Side[] sides = Side.List();
            cmbSides.Items.Clear();
            cmbSides.ValueMember = "Id";
            cmbSides.DisplayMember = "Name";
            cmbSides.DataSource = sides;
        }

        private void CaptureFinger(object sender, EventArgs e)
        {
            Action InitDevice = () =>
            {
                index.WindowOptions.WindowStyle = WINDOW_STYLE.INVISIBLE;
                index.WindowOptions.Option2.FPForeColor[0] = 34;
                index.WindowOptions.Option2.FPForeColor[1] = 51;
                index.WindowOptions.Option2.FPForeColor[2] = 60;
                index.WindowOptions.Option2.FPBackColor[0] = SystemColors.Window.R;
                index.WindowOptions.Option2.FPBackColor[1] = SystemColors.Window.G;
                index.WindowOptions.Option2.FPBackColor[2] = SystemColors.Window.B;
                index.WindowOptions.FingerWnd = pictureBox1.Handle;
            };
            index.CaptureFinger((uint)new Random().Next(0, int.MaxValue), InitDevice, () => DialogResult = DialogResult.OK);
        }
    }
}

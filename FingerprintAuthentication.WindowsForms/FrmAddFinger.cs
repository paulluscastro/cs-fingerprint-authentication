using FingerprintAuthentication.Commons.Model;
using FingerprintAuthentication.Commons.Utils;
using FingerprintAuthentication.Commons.Validation;
using FingerprintAuthentication.Domain.Enums;
using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Infrastructure.Context;
using NITGEN.SDK.NBioBSP;
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
        private FingerCapturer capturer = FingerCapturer.GetInstance();
        public string EncodedData { get; private set; }

        public FrmAddFinger()
        {
            InitializeComponent();
            FillFingers();
            FillSides();
            capturer.ForeColor = SystemColors.Window;
            capturer.BackgroundColor = Color.FromArgb(34, 51, 60);
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
                capturer.WindowOptions.WindowStyle = WINDOW_STYLE.INVISIBLE;
                capturer.WindowOptions.Option2.FPForeColor[0] = 34;
                capturer.WindowOptions.Option2.FPForeColor[1] = 51;
                capturer.WindowOptions.Option2.FPForeColor[2] = 60;
                capturer.WindowOptions.Option2.FPBackColor[0] = SystemColors.Window.R;
                capturer.WindowOptions.Option2.FPBackColor[1] = SystemColors.Window.G;
                capturer.WindowOptions.Option2.FPBackColor[2] = SystemColors.Window.B;
                capturer.WindowOptions.FingerWnd = pictureBox1.Handle;
                capturer.WindowOptions.WindowStyle |= false ? WINDOW_STYLE.NO_FPIMG : 0;
                capturer.WindowOptions.WindowStyle |= false ? WINDOW_STYLE.NO_TOPMOST : 0;
                capturer.WindowOptions.WindowStyle |= false ? WINDOW_STYLE.NO_WELCOME : 0;
            };
            try
            {
                btnCancel.Enabled = false;
                EncodedData = capturer.CaptureFinger(uint.Parse(Program.CurrentUser.Login), InitDevice);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void NewFinger()
        {
            if (ShowDialog() != DialogResult.OK) return;
            RegisteredFinger rf = new RegisteredFinger(Finger.From((int)cmbFingers.SelectedValue), Side.From((int)cmbSides.SelectedValue), EncodedData);
            List<ValidationResult> result = rf.Validate();
            if (result.Count != 0)
            {
                string message = string.Join(Environment.NewLine, result.Select(r => r.Code + " - " + r.Message).ToArray());
                MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FingerContext ctx = new FingerContext();
            ctx.Users.Attach(Program.CurrentUser);
            Program.CurrentUser.Fingers.Add(rf);
            ctx.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void CancelAndAbort(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

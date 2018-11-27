using FingerprintAuthentication.Commons.Utils;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NITGEN.SDK.NBioBSP.NBioAPI.Type;

namespace FingerprintAuthentication.WindowsForms
{
    public partial class FrmLogin : Form
    {
        public User LoggedUser { get; private set; } = null;
        private FingerCapturer capturer = FingerCapturer.GetInstance();
        public string EncodedData { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            pnPasswordAuthentication.Visible = false;
            pnFingerAuthentication.Visible = true;
            capturer.ForeColor = SystemColors.Window;
            capturer.BackgroundColor = Color.FromArgb(34, 51, 60);
        }

        private void LoginByFingerprint()
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
                capturer.WindowOptions.FingerWnd = picFinger.Handle;
                capturer.WindowOptions.WindowStyle |= false ? WINDOW_STYLE.NO_FPIMG : 0;
                capturer.WindowOptions.WindowStyle |= false ? WINDOW_STYLE.NO_TOPMOST : 0;
                capturer.WindowOptions.WindowStyle |= false ? WINDOW_STYLE.NO_WELCOME : 0;
            };
            try
            {
                EncodedData = capturer.CaptureToVerify(InitDevice);
                if (string.IsNullOrEmpty(EncodedData))
                {
                    lbAccessStatus.Text = "Nenhuma impressão digital detectada.";
                }
                else
                {
                    FingerContext ctx = new FingerContext();
                    FIR captured = new FIR(); ;
                    captured.Data = Encoding.UTF8.GetBytes(EncodedData);
                    INPUT_FIR inputFIR;
                    inputFIR = new INPUT_FIR
                    {
                        Form = INPUT_FIR_FORM.FULLFIR,
                    };
                    inputFIR.InputFIR.FIR = captured;
                    foreach (RegisteredFinger finger in ctx.RegisteredFingers)
                    {
                        uint ret;
                        INPUT_FIR storedFIR;
                        FIR stored;
                        bool result;
                        stored = new FIR
                        {
                            Data = Encoding.UTF8.GetBytes(finger.EncodedText),
                        };
                        storedFIR = new INPUT_FIR
                        {
                            Form = INPUT_FIR_FORM.FULLFIR,
                        };
                        storedFIR.InputFIR.FIR = stored;
                        ret = capturer.Api.VerifyMatch(captured, stored, out result, null);
                        if (result)
                        {
                            lbIdentifiedUser.Text = finger.User.Name;
                            lbIdentifiedUser.Visible = true;
                            LoggedUser = finger.User;
                            lbAccessStatus.Text = "Acesso liberado";
                            Application.DoEvents();
                            Thread.Sleep(1500);
                            DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            {
                LoggedUser = user;
                DialogResult = DialogResult.OK;
            }
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

        private void RetryFingerprint(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginByFingerprint();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            LoginByFingerprint();
        }
    }
}

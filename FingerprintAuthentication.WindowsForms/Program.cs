using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerprintAuthentication.WindowsForms
{
    static class Program
    {
        public static User CurrentUser { get; private set; } = null;
        public static FrmMain MainWindow = null;

        private static bool Login()
        {
            using (FrmLogin login = new FrmLogin())
                if (login.ShowDialog() == DialogResult.OK)
                {
                    CurrentUser = login.LoggedUser;
                    return true;
                }
            return false;
        }

        public static void Logoff()
        {
            CurrentUser = null;
            MainWindow?.Close();
            MainWindow?.Dispose();
            if (Login())
            {
                MainWindow = new FrmMain();
                MainWindow.ShowDialog();
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FingerContext ctx = new FingerContext();
            User user = ctx.Users.Where(u => u.Login == "00000").FirstOrDefault();
            if (user == null)
            {
                User master = new User("MASTER", "00000").SetPassword("12345");
                ctx.Users.Add(master);
                ctx.SaveChanges();
                Debug.WriteLine("Usuário MASTER criado");
            }
            Logoff();
        }
    }
}

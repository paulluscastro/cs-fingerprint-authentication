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
        private static bool Login()
        {
            using(FrmLogin login = new FrmLogin())
                return login.ShowDialog() == DialogResult.OK;
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
            if (Login())
                Application.Run(new FrmMain());
        }
    }
}

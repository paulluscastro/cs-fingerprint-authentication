using FingerprintAuthentication.Domain.Model;
using FingerprintAuthentication.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerprintAuthentication.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Iniciando...");
            FingerContext ctx = new FingerContext();
            User user = ctx.Users.Where(u => u.Login == "00000").FirstOrDefault();
            if (user == null)
            {
                User master = new User("MASTER", "00000").SetPassword("12345");
                ctx.Users.Add(master);
                ctx.SaveChanges();
                System.Console.WriteLine("Usuário MASTER criado");
            } else
                System.Console.WriteLine("Usuário MASTER já existia");
            System.Console.WriteLine("Encerrando...");
            System.Console.ReadKey();
        }
    }
}

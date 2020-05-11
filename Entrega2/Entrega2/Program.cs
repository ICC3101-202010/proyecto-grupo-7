using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entrega2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Usuario user = new Usuario();
            //Archivos archivos = new Archivos();
            App server = new App();
            MailSender mailSender = new MailSender();
            SMSSender smsSender = new SMSSender();

            mailSender.EmailSent += user.OnEmailSent;
            user.EmailVerified += server.OnEmailVerified;
            server.Registered += mailSender.OnRegistered;
            server.PasswordChanged += mailSender.OnPasswordChanged;
            server.PasswordChanged += smsSender.OnPasswordChanged;

            bool exec = true;
            while (exec)
            {
                string chosen = ShowOptions(new List<string>() { "Registrarse", "Cambiar contrasena", "Salir" });
                switch (chosen)
                {
                    case "Registrarse":
                        Console.Clear();
                        server.Register();
                        break;
                    case "Cambiar contrasena":
                        Console.Clear();
                        server.ChangePassword();
                        break;
                    case "Salir":
                        exec = false;
                        break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        private static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }

    }
}
}

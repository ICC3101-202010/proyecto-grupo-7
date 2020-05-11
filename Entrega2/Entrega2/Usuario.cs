using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Usuario
    {
        protected string Mail;
        protected string Contraseña;
        protected string Nombre_usuario;
        protected string Tipo_usuario;
        public Usuario(string nombre_usuario, string mail, string contraseña)
        {
            this.Mail = mail;
            this.Contraseña = contraseña;
            this.Nombre_usuario = nombre_usuario;
        }
        public delegate void VerifiedEmailEventHandler(object source, EventArgs args);
        public event VerifiedEmailEventHandler EmailVerified;
        public void OnEmailVerified(object source, EventArgs args)
        {
            EmailVerified(this, new EventArgs());
        }
        public void OnEmailSent(object source, EventArgs args)
        {
            Console.WriteLine("¿Desea revisar su correo?");
            Console.WriteLine("a)si");
            Console.WriteLine("b)no");
            string input_usuario = Console.ReadLine();
            while (true)
            {
                if (input_usuario == "a")
                {
                    EmailVerified(new object(), new EventArgs());
                    break;
                }
                else if (input_usuario == "b")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El criterio ingresado no es válido");
                }
            }
        }

    }
}

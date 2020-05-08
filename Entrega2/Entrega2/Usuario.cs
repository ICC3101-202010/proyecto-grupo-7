using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Usuario
    {
        protected int ID;
        protected string Mail;
        protected string Contraseña;
        protected string Nombre_usuario;
        public Usuario(int Id, string mail, string contraseña, string nombre_usuario)
        {
            this.ID = Id;
            this.Mail = mail;
            this.Contraseña = contraseña;
            this.Nombre_usuario = nombre_usuario;
        }
        //crear clase archivos
        public bool CrearCuenta(int id, string mail, string constraseña, string nombre_usuario)
        {
            for (int i = 0, i < Archivos.usuarios.Count; i++)
            {
                if((Archivos.usuarios[i].Mail != mail) || (Archivos.usuarios[i].Nombre_usuario != nombre_usuario))
                {
                    Console.WriteLine("¿Qué tipo de usuario quieres crear?");
                    Console.WriteLine("1) Gratis");
                    Console.WriteLine("2) Premium");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        UsuarioGratis gratis = new UsuarioGratis(id, mail, constraseña, nombre_usuario);
                        Archivos.usuarios.Add(gratis);
                    }
                    else if (input == "2")
                    {
                        UsuarioPremium premium = new UsuarioPremium(id, mail, constraseña, nombre_usuario);
                        Archivos.usuarios.Add(premium);
                    }
                    else
                    {
                        Console.WriteLine("el criterio ingresado no es válido");
                        return false;
                    }
                    Console.WriteLine("Su cuenta ha sido creada");
                    return true;

                }
            }
        }
    }
}

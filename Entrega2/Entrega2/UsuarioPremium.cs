using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class UsuarioPremium : Usuario
    {
        protected string Tipo_usuario;
        public UsuarioPremium(string nombre_usuario, string mail, string contraseña) : base(nombre_usuario, mail, contraseña)
        {
            this.Mail = mail;
            this.Contraseña = contraseña;
            this.Nombre_usuario = nombre_usuario;
            this.Tipo_usuario = "Premium";
        }
    }
}

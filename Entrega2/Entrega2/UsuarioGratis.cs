using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class UsuarioGratis : Usuario
    {
        protected string Tipo_usuario;
        public UsuarioGratis(string mail, string contraseña, string nombre_usuario) : base(mail, contraseña, nombre_usuario)
        {
            this.Mail = mail;
            this.Contraseña = contraseña;
            this.Nombre_usuario = nombre_usuario;
            this.Tipo_usuario = "Gratis";

        }

        public void CancionAleatoria()
        {

        }

        public void VideoAleatorio()
        {

        }
    }
}

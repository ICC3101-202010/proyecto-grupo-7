using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class UsuarioGratis : Usuario
    {
        public UsuarioGratis(string nombre_usuario, string mail, string contraseña, string tipo_usuario) : base(mail, contraseña, nombre_usuario, tipo_usuario)
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

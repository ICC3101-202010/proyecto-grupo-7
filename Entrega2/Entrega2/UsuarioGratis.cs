using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class UsuarioGratis : Usuario
    {
        public UsuarioGratis(int Id, string mail, string contraseña, string nombre_usuario) : base(Id, mail, contraseña, nombre_usuario)
        {
            this.ID = Id;
            this.Mail = mail;
            this.Contraseña = contraseña;
            this.Nombre_usuario = nombre_usuario;

        }

        public void CancionAleatoria()
        {

        }

        public void VideoAleatorio()
        {

        }
    }
}

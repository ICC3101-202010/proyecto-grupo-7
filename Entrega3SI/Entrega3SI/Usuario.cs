using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega3SI
{
    public class Usuario
    {
        string nombre_usuario;
        string contraseña;
        string email;
        string tipo_usuario;
        int age;

        public Usuario(string nombre_usuario, string email, string contraseña, string tipo_usuario)
        {
            this.Nombre_usuario = nombre_usuario;
            this.Email = email;
            this.Contraseña = contraseña;
            this.Tipo_usuario = tipo_usuario;
        }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Email { get => email; set => email = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public bool CheckCredentials(string username, string pass)
        {
            if (this.Nombre_usuario.Equals(username) && this.Contraseña.Equals(pass))
                return true;
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Administrador : Usuario
    {
        public Administrador(int id, string nombre_usuario, string mail, string contraseña) : base(id, nombre_usuario, mail, contraseña)
        {
            this.ID = id;
            this.Nombre_usuario = nombre_usuario;
            this.Mail = mail;
            this.Contraseña = contraseña;
        }
        public bool Agregar_Película(Película película)
        {
            for (int i = 0; i < Archivos.películas.Count; i++)
            {
                if (Archivos.películas[i] == película)
                {
                    return false;
                }
            }
            Archivos.películas.Add(película);
            return true;
        }
        public bool Agregar_Canción(Canción canción)
        {
            for (int i = 0; i < Archivos.canciones.Count; i++)
            {
                if (Archivos.canciones[i] == canción)
                {
                    return false;
                }
            }
            Archivos.canciones.Add(canción);
            return true;
        }
    }
}


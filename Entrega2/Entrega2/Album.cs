using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Album
    {
        private string Año;
        private string Nombre;
        private Artista Artista;
        //falta foto
        public Album(string nombre, Artista artista, string año)
        {
            this.Nombre = nombre;
            this.Artista = artista;
            this.Año = año;
        }
        public string Nombre_get
        {
            get => Nombre; set => Nombre = value;
        }
        public Artista Artista_get
        {
            get => Artista; set => Artista = value;
        }
        public string Año_get
        {
            get => Año; set => Año = value;
        }
    }

}

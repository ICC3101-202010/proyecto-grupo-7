using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3Spotiflix
{
    [Serializable]
    public class Playlist
    {
        public string Nombre;
        public List<String> ListaCanciones = new List<String>();
        public List<String> ListaPelículas = new List<String>();
        public string Tipo_playlist;
        public bool Agregada;
        public Playlist(string nombre, string tipo_playlist, List<String> listaCanciones, List<String> listaPelículas)
        {
            this.Nombre = nombre;
            this.Tipo_playlist = tipo_playlist;
            this.ListaCanciones = listaCanciones;
            this.ListaPelículas = listaPelículas;
        }
        public Playlist() { }

    }
}
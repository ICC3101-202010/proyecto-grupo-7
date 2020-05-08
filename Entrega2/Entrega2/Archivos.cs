using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    static class Archivos
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Película> películas = new List<Película>();
        public static List<Canción> canciones = new List<Canción>();
        public static List<Playlist> playlists_Canciones = new List<Playlist>();
        public static List<Playlist> playlists_Películas = new List<Playlist>();
        private List<Usuario> Usuarios
        {
            get => usuarios; set => usuarios = value;
        }
        public static List<Película> Películas
        {
            get => películas; set => películas = value;
        }
        public static List<Canción> Canciones
        {
            get => canciones; set => canciones = value;
        }
        public static List<Playlist> Playlists_Canciones
        {
            get => playlists_Canciones; set => playlists_Canciones = value;
        }
        public static List<Playlist> Playlists_Películas
        {
            get => playlists_Películas; set => playlists_Películas = value;
        }
    }
}

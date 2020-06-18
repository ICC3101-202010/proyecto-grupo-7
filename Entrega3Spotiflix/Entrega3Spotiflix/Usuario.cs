using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Entrega3Spotiflix
{
    [Serializable]
    public class Usuario
    {
        string nombre_usuario;
        string contraseña;
        string email;
        string tipo_usuario;
        public bool Logeado;
        string privacidad;
        public List<Playlist> Favoritos = new List<Playlist>();
        List<string> historial = new List<string>();
        List<string> playlistC = new List<string>();
        List<string> playlistV = new List<string>();
        string fechaNac;
        List<string> seguidores = new List<string>();
        string genero;
        string nacionalidad;
        int númeroSeguidores;
        List<String> playlists = new List<string>();
        List<String> solicitudes = new List<string>();

        public Usuario(string nombre_usuario, string email, string contraseña, string tipo_usuario, string genero, string nacionalidad, string fechaNac, List<string> historial, List<string> playlistC, List<string> playlistV, List<string> seguidores, string privacidad, int númeroSeguidores, List<String> playlists, List<String> solicitudes)
        {
            this.Nombre_usuario = nombre_usuario;
            this.Email = email;
            this.Contraseña = contraseña;
            this.Tipo_usuario = tipo_usuario;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
            this.FechaNac = fechaNac;
            this.Historial = historial;
            this.PlaylistC = playlistC;
            this.PlaylistV = playlistV;
            this.Seguidores = seguidores;
            this.Privacidad = privacidad;
            this.NúmeroSeguidores = númeroSeguidores;
            this.Playlists = playlists;
            this.Solicitudes = solicitudes;
        }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Email { get => email; set => email = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public List<string> Historial { get => historial; set => historial = value; }
        public List<string> PlaylistC { get => playlistC; set => playlistC = value; }
        public List<string> PlaylistV { get => playlistV; set => playlistV = value; }
        public List<string> Seguidores { get => seguidores; set => seguidores = value; }
        public List<string> Playlists { get => playlists; set => playlists = value; }
        public string Privacidad { get => privacidad; set => privacidad = value; }
        public int NúmeroSeguidores { get => númeroSeguidores; set => númeroSeguidores = value; }
        public List<string> Solicitudes { get => playlists; set => playlists = value; }



        public bool CheckCredentials(string username, string pass)
        {
            if (this.Nombre_usuario.Equals(username) && this.Contraseña.Equals(pass))
                return true;
            return false;
        }
        public Usuario() { }

    }
}

using Entrega3Spotiflix.CustomsEvenArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3Spotiflix.Controllers
{
    class PlaylistController
    {
        AppForm view;

        public PlaylistController(Form view)
        {
            initialize();
            this.view = view as AppForm;
            this.view.AgregarPlaylistClicked += OnAgregarPlaylistClicked;
            this.view.PlaylistChecked += OnPlaylistChecked;
        }
        public void initialize()
        {
            //Serialización
        }
        public bool OnAgregarPlaylistClicked(object sender, AgregarPlaylistEventArgs e)
        {
            string result = Archivos.AddPlaylist(new List<string>()
                {e.Nombre, e.Tipo_playlist});
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void OnPlaylistChecked(object sender, AgregarPlaylistEventArgs e)
        {
            Playlist playlist = null;
            playlist = Archivos.playlists_Canciones.Where(t =>
                t.Nombre.ToUpper().Contains(e.Nombre.ToUpper())).FirstOrDefault();
        }
    }
}

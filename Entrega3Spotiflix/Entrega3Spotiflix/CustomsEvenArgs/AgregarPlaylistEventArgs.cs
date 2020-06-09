using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3Spotiflix.CustomsEvenArgs
{
    public class AgregarPlaylistEventArgs : EventArgs
    {
        public string Nombre { get; set; }
        public string Tipo_playlist { get; set; }
    }
}

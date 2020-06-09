using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3Spotiflix.CustomsEvenArgs
{
    public class AgregarVideoEventArgs : EventArgs
    {
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Director { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public int Año { get; set; }
        public int Calificacion { get; set; }
        public int Avg_calificacion { get; set; }
        public string Imagen { get; set; }
        public string Url { get; set; }
        public int Reproducciones { get; set; }
    }
}

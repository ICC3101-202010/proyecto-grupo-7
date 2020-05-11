using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Película
    {
        private string titulo;
        private string genero;
        private string categoria;
        private string estudio;
        private string descripcion;
        private string premios;
        private int duracion;
        private int añoPublicacion;
        private int calificacion;
        public List<double> rating;
        public List<double> Rating { get => rating; set => rating = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Película
    {
        public string titulo;
        public string genero;
        public string categoria;
        public string estudio;
        public string descripcion;
        public string premios;
        public int duracion;
        public int añoPublicacion;
        public int calificacion;
        public List<double> rating;
        public List<double> Rating { get => rating; set => rating = value; }
    }
}
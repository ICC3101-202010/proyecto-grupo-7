using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Canción
    {
        public Album album;
        public Artista artista;
        public string titulo;
        public string genero;
        public string discografia;
        public string estudio;
        public string letra;
        public string premios;
        public string cantante;
        public string compositor;
        public int calificacion;
        public int añoPublicacion;
        public List<double> rating;
        public int numReproductions;
        public List<double> Rating { get => rating; set => rating = value; }

    }

}

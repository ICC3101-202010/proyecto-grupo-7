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
        public string estudio;
        public string letra;
        public string premios;
        public string compositor;
        public List<int> calificacion;
        public int Avg_calificacion;
        public int añoPublicacion;
        public int numReproductions;

        public void informacion()
        {
            Console.WriteLine("Título" + titulo + "\nArtista: " + artista.Nombre + "\nEstudio: " + estudio + "\nCompositor: " + compositor + "\nCalificación: " + Avg_calificacion + "\nAlbum: " + album.Nombre + "\nGenero: " + genero + "\nNúmero de reproducciones: " + numReproductions + "\nAño de publicación: " + añoPublicacion);
        }
    }


}

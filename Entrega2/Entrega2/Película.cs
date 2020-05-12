using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{     
    public class Película
    {
        public string titulo;
        public string categoria;
        public string estudio;
        public string descripcion;
        public string premios;
        public int duracion;
        public int min;
        public int añoPublicacion;
<<<<<<< HEAD
        public int rating;
        public List<int> Rating;
        public int avg_Ranking;
        public List<Person> Actores;

        public Película(string titulo, string categoria, string estudio, string descripcion, string premios, int duracion, int min,
            int anoPublicacion, int rating, List<double> Rating, int avg_Ranking)
        {
            this.Titulo = titulo;
=======
        public int clasificacion;
        public List<double> rating;
        public List<double> Rating { get => rating; set => rating = value; }
        public int Avg_Ranking;

        public Película(string titulo, string genero, string categoria, string estudio, string descripcion, string premios, int duracion, int min,
            int anoPublicacion, int clasificacion, List<double> rating, int Avg_Ranking)
        {
            this.Titulo = titulo;
            this.Genero = genero;
>>>>>>> 3d30c0b1c035a8d558d6710a1a1a9d4e1863c84a
            this.Categoria = categoria;
            this.Estudio = estudio;
            this.Premios = premios;
            this.Descripcion = descripcion;
            this.duracion = duracion;
            this.min = min;
<<<<<<< HEAD
            this.AñoPublicacion = añoPublicacion;
            this.Avg_Ranking = avg_Ranking;
        }
        public string Titulo
        {
            get => titulo; set => titulo = value;
        }
        public string Categoria
        {
            get => categoria; set => categoria = value;
=======
            this.AñoPublicacion = anoPublicacion;
            this.clasificacion = clasificacion;
            this.rating = rating;
            this.Avg_Ranking = Avg_Ranking;
        }

        public string Titulo
        {
            get => titulo; set => titulo = Value;
        }
        public string Categoria
        {
            get =>categoria; set =>categoria = value;
>>>>>>> 3d30c0b1c035a8d558d6710a1a1a9d4e1863c84a
        }
        public string Estudio
        {
            get => estudio; set => estudio = value;
        }
        public string Premios
        {
            get => premios; set => premios = value;
        }
        public string Descripcion
        {
            get => descripcion; set => descripcion = value;
        }
<<<<<<< HEAD
        public int Duracion
        {
            get => duracion; set => duracion = value;
        }
        public int AñoPublicacion
        {
            get => añoPublicacion; set => añoPublicacion = value;
        }
        public int Avg_Ranking
        {
            get => Avg_Ranking; set => Avg_Ranking = value;
        }
        public void informacion()
        {
            Console.WriteLine("Título" + titulo + "\nArtista: " + "\nEstudio: " + estudio + "\nDuración: " + duracion + "\nCalificación: " + Avg_Ranking + "\nAño de publicación: " + añoPublicacion);
            Console.WriteLine("Actores: ");
            foreach (Person actores in Actores)
            {
                Console.WriteLine(actores.Nombre);
            }
        }
       
=======
        public int duracion
        {
            get => duracion; set => duracion = value;
        }
        public int AnoPublicacion
        {
            get => anoPublicacion; set => anoPublicacion = value;
        }
        public int clasificacion
        {
            get => clasificacion; set => clasificacion = value;
        }
        public int rating
        {
            get => rating; set => rating = value;
        }
        public int Avg_Ranking
        {
            get => Avg_Ranking; set => Avg_Ranking = value;
        }
>>>>>>> 3d30c0b1c035a8d558d6710a1a1a9d4e1863c84a
    }

}
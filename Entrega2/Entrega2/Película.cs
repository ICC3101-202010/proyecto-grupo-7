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
        public string genero;
        public string categoria;
        public string estudio;
        public string descripcion;
        public string premios;
        public int duracion;
        public int min;
        public int añoPublicacion;
        public int clasificacion;
        public List<double> rating;
        public List<double> Rating { get => rating; set => rating = value; }
        public int Avg_Ranking;

        public Película(string titulo, string genero, string categoria, string estudio, string descripcion, string premios, int duracion, int min,
            int anoPublicacion, int clasificacion, List<double> rating, int Avg_Ranking)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Categoria = categoria;
            this.Estudio = estudio;
            this.Premios = premios;
            this.Descripcion = descripcion;
            this.duracion = duracion;
            this.min = min;
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
    }

}
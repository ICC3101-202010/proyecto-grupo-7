﻿using System;
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
        public int rating;
        public List<int> Rating;
        public int avg_Ranking;
        public List<Person> Actores;

        public Película(string titulo, string genero, string categoria, string estudio, string descripcion, string premios, int duracion, int min,
            int anoPublicacion, int clasificacion, List<double> rating, int Avg_Ranking)
        {
            this.Titulo = titulo;
            this.Categoria = categoria;
            this.Estudio = estudio;
            this.Premios = premios;
            this.Descripcion = descripcion;
            this.duracion = duracion;
            this.min = min;
            this.AñoPublicacion = añoPublicacion;
            this.Avg_Ranking = avg_Ranking;
        }
        public string Titulo
        {
            get => titulo; set => titulo = value;
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
    }

}
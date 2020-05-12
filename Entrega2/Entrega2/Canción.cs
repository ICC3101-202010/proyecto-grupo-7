using System;
using System.Collections.Generic;
using System.Dynamic;
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
    public Cancion(Album album,Artista artista, string titulo,string genero,string discografia,string estudio,string letra,string premios,string cantante, string compositor,int Avg_calificacion,int añoPublicacion, int numReproductions)
    {
        this.Titulo = titulo;
        this.genero = genero;
        this.discografia = discografia;
        this.Estudio = estudio;
        this.letra = letra;
        this.premios = premios;
        this.cantante = cantante;
        this.compositor = compositor;
        this.Avg_calificacion = Avg_calificacion;
        this.añoPublicacion = añoPublicacion;
        this.numReproductions = numReproductions;
    }
    public string Titulo
    {
        get => titulo; set => titulo= value;
    }
    public string genero
    {
        get => genero; set => genero = value;
    }
    public string discografia
    {
        get => discografia; set => discografia = value;
    }
    public string Estudio
    {
        get => estudio; set => estudio = value;
    }
    public string letra
    {
        get => letra; set => letra = value
    }
    public string premios
    {
        get => premios; set => premios = value;
    }
    public string cantante
    {
        get => cantante; set => cantante = value;
    }
    public string compositor
    {
        get => compositor; set => compositor = value;
    }
    public int añoPublicacion
    {
        get => añoPublicacion; set => añoPublicacion = value;
    }
    public int numReproductions
    {
        get => numReproductions; set => numReproductions = value;
    }


}

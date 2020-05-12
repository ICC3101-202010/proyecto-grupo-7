using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Búsqueda
    {
        public List<Canción> buscar_cancion_por_tipo()
        {
            Console.WriteLine("Seleccione el filtro por el cual desea buscar");
            Console.WriteLine("1) Título");
            Console.WriteLine("2) Género");
            Console.WriteLine("3) Compositor");
            Console.WriteLine("4) Album");
            Console.WriteLine("5) Artista");
            string option = Console.ReadLine();
            Console.Write("Escriba el nombre a buscar: ");
            string name = Console.ReadLine();
            List<Canción> resultado = new List<Canción>();

            if (option == "1")
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (canción.titulo == name)
                    {
                        resultado.Add(canción);
                    }
                }
            }
            if (option == "2")
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (canción.genero == name)
                    {
                        resultado.Add(canción);
                    }
                }
            }
            if (option == "3")
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (canción.compositor == name)
                    {
                        resultado.Add(canción);
                    }
                }
            }
            if (option == "4")
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (canción.album.Nombre == name)
                    {
                        resultado.Add(canción);
                    }
                }
            }
            if (option == "5")
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (canción.artista.Nombre == name)
                    {
                        resultado.Add(canción);
                    }
                }
            }
            return resultado;
        }

        public List<Película> buscar_pelicula_por_tipo()
        {
            Console.WriteLine("Seleccione el filtro por el cual desea buscar");
            Console.WriteLine("1) Título");
            Console.WriteLine("2) Categoría");
            Console.WriteLine("3) Director");
            Console.WriteLine("4) Actor");
            Console.WriteLine("5) Estudio");
            Console.WriteLine("6) Escritor");
            string option = Console.ReadLine();
            Console.Write("Escriba el nombre a buscar: ");
            string name = Console.ReadLine();
            List<Película> resultado = new List<Película>();

            if (option == "1")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.titulo == name)
                    {
                        resultado.Add(película);
                    }
                }
            }
            if (option == "2")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.categoria == name)
                    {
                        resultado.Add(película);
                    }
                }
            }
            if (option == "3")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.director == name)
                    {
                        resultado.Add(película);
                    }
                }
            }
            if (option == "4")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.actor.nombre == name)
                    {
                        resultado.Add(película);
                    }
                }
            }
            if (option == "5")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.estudio == name)
                    {
                        resultado.Add(película);
                    }
                }
            }
            if (option == "6")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.escritor == name)
                    {
                        resultado.Add(película);
                    }
                }
            }
            return resultado;
        }
    }
}

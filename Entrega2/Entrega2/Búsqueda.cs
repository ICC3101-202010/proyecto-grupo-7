using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Búsqueda
    {


        public List<Película> BuscarPelícula(string nombre, string filtro)
        {
            List<Película> lista_mostrada = new List<Película>();
            if (filtro == "Título")
            {
                for (int i = 0; i < Archivos.películas.Count; i++)
                {
                    if (Archivos.películas[i].Título == nombre)
                    {
                        Película película = new Película(id, mail, constraseña, nombre_usuario);
                        lista_mostrada.Add(película)
                    }
                }
            }
        }
        
    }
}

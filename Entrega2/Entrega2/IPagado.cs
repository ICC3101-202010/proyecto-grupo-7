using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    interface IPagado
    {
        public void Pagado(Usuario usuario, int id, string nombre_usuario, string mail, string password);
    }
}

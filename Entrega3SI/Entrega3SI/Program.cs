using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3SI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Archivos.Usuarios.Add(new Usuario("cdiazarze", "Carlos@Díaz", "1234", "Gratis"));
            Archivos.Usuarios.Add(new Usuario("ahowardm", "Andres@Howard", "1234", "Premium"));
            Archivos.Usuarios.Add(new Usuario("jperez", "Juan@Perez", "1234", "Premium"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppForm appForm = new AppForm();
            UserController userController = new UserController(appForm);
            Application.Run(appForm);
        }
    }
}
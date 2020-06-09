using Entrega3Spotiflix.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3Spotiflix
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppForm appform = new AppForm();
            UserController userController = new UserController(appform);
            CancionController cancionController = new CancionController(appform);
            Application.Run(appform);
        }
    }
}
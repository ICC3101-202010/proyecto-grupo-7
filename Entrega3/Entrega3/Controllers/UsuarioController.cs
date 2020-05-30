using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3.Controllers
{
    class UserController
    {
        AppForm view;

        public UserController(Form view)
        {
            initialize();
            this.view = view as AppForm;
            this.view.LoginButtonClicked += OnLoginButtonClicked;
            this.view.CreateAccountClicked += OnCreateAccountClicked;
            this.view.UserChecked += OnUserChecked;
        }

        public bool OnCreateAccountClicked(object sender, RegisterEventArgs e)
        {
            string result = Archivos.AddUser(new List<string>()
                {e.Username, e.Email, e.Password, Convert.ToString(DateTime.Now) });
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OnLoginButtonClicked(object sender, LoginEventArgs e)
        {
            Usuario result = null;
            result = Archivos.Usuarios.Where(t =>
               t.Nombre_usuario.ToUpper().Contains(e.UsernameText.ToUpper())).FirstOrDefault();
            if (result is null)
            {
                return false;
            }
            else
            {
                return result.CheckCredentials(e.UsernameText, e.PasswordText);
            }
        }
        public void OnUserChecked(object sender, LoginEventArgs e)
        {
            Usuario usuario = null;
            usuario = Archivos.Usuarios.Where(t =>
               t.Nombre_usuario.ToUpper().Contains(e.UsernameText.ToUpper())).FirstOrDefault();
            view.setNombreUsuario(usuario.Nombre_usuario);
        }
        public void initialize()
        {
            Archivos.Usuarios.Add(new Usuario("ijperrotta", "ijperrotta@miuandes.cl", "1234", "Premium"));
            Archivos.Usuarios.Add(new Usuario("tfbruner", "tfbruner@miuandes.cl", "1234", "Gratis"));
            Archivos.Usuarios.Add(new Usuario("dariedel", "dariedel", "1234", "Premium"));
        }
    }
}

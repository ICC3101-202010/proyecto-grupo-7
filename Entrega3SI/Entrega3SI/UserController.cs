using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entrega3SI
{
    class UserController
    {
        List<Usuario> users = new List<Usuario>();
        AppForm view;

        public UserController(Form view)
        {
            initialize();
            this.view = view as AppForm;
            this.view.LoginButtonClicked += OnLoginButtonClicked;
            this.view.UserChecked += OnUserChecked;
            this.view.CreateAccountClicked += OnCreateAccountClicked;
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
            Usuario user = null;
            user = Archivos.Usuarios.Where(t =>
               t.Nombre_usuario.ToUpper().Contains(e.UsernameText.ToUpper())).FirstOrDefault();
            //view.setNameUser(user.Nombre_usuario);
        }
        public bool OnCreateAccountClicked(object sender, RegisterEventArgs e)
        {
            string result = Archivos.AddUser(new List<string>()
                {e.Username, e.Email, e.Password, Convert.ToString(DateTime.Now)});
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void initialize()
        {
            
        }
    }
}
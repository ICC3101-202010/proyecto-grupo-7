using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3SI
{
    public partial class AppForm : Form
    {
        public delegate bool CreateAccountEventHandler(object source, RegisterEventArgs args);
        public event CreateAccountEventHandler CreateAccountClicked;
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;


        //Organizacion
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public AppForm()
        {
            InitializeComponent();
            panels.Add("LoginPanel", LoginView);
            panels.Add("EntradaPanel", EntradaView);
            panels.Add("ProfilePanel", profileView);
            panels.Add("RegisterPanel", RegisterView);
            panels.Add("ModificarCuentaPanel", panelModificarCuenta);
            stackPanels.Add(panels["EntradaPanel"]);
            LoginView.Visible=true;
            //ShowLastPanel();
        }

        private void loginViewButton_Click(object sender, EventArgs e)
        {
            string username = loginViewUserInput.Text;
            string pass = loginViewPassWordInput.Text;
            OnLoginButtonClicked(username, pass);
        }

        private void profileViewLogOutButton_Click(object sender, EventArgs e)
        {
            profileViewUserText.ResetText();
            profileViewNameText.ResetText();
            profileViewAgeText.ResetText();
            stackPanels.RemoveAt(stackPanels.Count - 1);
            ShowLastPanel();
        }

        //Metodos Internos
        private void OnLoginButtonClicked(string username, string pass)
        {
            if (LoginButtonClicked != null)
            {
                bool result = LoginButtonClicked(this, new LoginEventArgs() { UsernameText = username, PasswordText = pass });
                if (!result)
                {
                    loginViewInvalidCredentialsAlert.Text = "Credenciales invalidas";
                    loginViewInvalidCredentialsAlert.Visible = true;
                }
                else
                {
                    loginViewInvalidCredentialsAlert.ResetText();
                    loginViewInvalidCredentialsAlert.Visible = false;
                    OnUserChecked(username);
                }
            }
        }
        private void OnCreateAccountClicked(string username, string email, string pass, string type)
        {
            if ((type == "") || (type == "") || (username == "") || pass == "" || email == "")
            {
                registerViewInvalidCredentialsAlert.Text = "Agregue los valores que faltan";
                registerViewInvalidCredentialsAlert.Visible = true;
            }
            else
            {
                bool result = CreateAccountClicked(this, new RegisterEventArgs() { Username = username, Password = pass, Email = email });
                if (!result)
                {
                    registerViewInvalidCredentialsAlert.Text = "Usuario y/o email ya existen";
                    registerViewInvalidCredentialsAlert.Visible = true;
                }
                else
                {
                    registerViewInvalidCredentialsAlert.ResetText();
                    registerViewInvalidCredentialsAlert.Visible = false;
                    OnUserChecked(username);
                }
            }
        }
        private void OnUserChecked(string username)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username });
                loginViewUserInput.ResetText();
                loginViewPassWordInput.ResetText();
                stackPanels.Add(panels["ProfilePanel"]);
                setNameUser(username);
                //ShowLastPanel();
                profileView.Visible = true;
            }
        }


        public void setNameUser(string username)
        {
            profileViewUserText.Text = username;
        }

        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Dock = DockStyle.Fill;
                    panel.Visible = true;
                }
            }
        }

        private void buttonGoLogin_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["LoginPanel"]);
            ShowLastPanel();
        }

        private void buttonGoRegister_Click(object sender, EventArgs e)
        {
            registerViewTipoInput.ResetText();
            registerViewUserInput.ResetText();
            registerViewEmailInput.ResetText();
            registerViewPassInput.ResetText();
            stackPanels.Add(panels["RegisterPanel"]);
            ShowLastPanel();
        }

        private void registerViewLogOutButton_Click(object sender, EventArgs e)
        {
            stackPanels.RemoveAt(stackPanels.Count - 1);
            ShowLastPanel();
        }

        private void registerViewButton_Click(object sender, EventArgs e)
        {
            string username = registerViewUserInput.Text;
            string email = registerViewEmailInput.Text;
            string pass = registerViewPassInput.Text;
            string type = registerViewTipoInput.Text;
            OnCreateAccountClicked(username, email, pass, type);
        }
        private void RegisterView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEntrada_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonModificarCuenta_Click(object sender, EventArgs e)
        {
            panelHacersePremium.Visible = false;
            panelCambiarUsername.Visible = false;
            panelCambiarContraseña.Visible = false;
            stackPanels.Add(panels["ModificarCuentaPanel"]);
            ShowLastPanel();
        }

        private void buttonHacersePremium_Click(object sender, EventArgs e)
        {
            panelHacersePremium.Visible = true;
            string usuario_ant = profileViewUserText.Text;
            List<string> Valores = Archivos.GetData(usuario_ant);
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == usuario_ant)
                {
                    usuario.Tipo_usuario = "Premium";
                    textBoxHacersePremium.Text = "Se ha realizado el cambio con éxito";
                    panelHacersePremium.Visible = false;
                }
            }
        }

        private void buttonCambiarUsername_Click(object sender, EventArgs e)
        {
            textBoxUsuarioCambioUsername.ResetText();
            panelCambiarUsername.Visible = true;
        }

        private void buttonCambiarContraseña_Click(object sender, EventArgs e)
        {
            textBoxContraseñaCambioContraseña.ResetText();
            panelCambiarContraseña.Visible = true;
        }

        private void buttonConfirmarCambioUsername_Click(object sender, EventArgs e)
        {
            string usuario_ant = profileViewUserText.Text;
            string usuario_nuevo = textBoxUsuarioCambioUsername.Text;
            List<string> Valores = Archivos.GetData(usuario_ant);
            Valores[0] = usuario_nuevo;
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == usuario_ant)
                {
                    usuario.Nombre_usuario = usuario_nuevo;
                }
            }
            profileViewUserText.Text = usuario_nuevo;
            textBoxCambiarUsername.Text = "Username cambiado con éxito";
            panelCambiarUsername.Visible = false;
        }

        private void buttonConfirmarCambioContraseña_Click(object sender, EventArgs e)
        {
            string user = profileViewUserText.Text;
            string contraseña_ant = textBoxAntiguaContraseñaCambioContraseña.Text;
            string contraseña_nueva = textBoxContraseñaCambioContraseña.Text;
            List<string> Valores = Archivos.GetData(user);
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == user)
                {
                    if (contraseña_ant == usuario.Contraseña)
                    {
                        usuario.Contraseña = contraseña_nueva;
                        Valores[2] = contraseña_nueva;
                        textBoxCambioContraseña.Text = "Contraseña cambiada con éxito";
                        panelCambiarContraseña.Visible = false;
                    }
                    else
                    {
                        textBoxCambioContraseña.Text = "Contraseña Actual Incorrecta";
                    }
                }
            }
        }

        private void buttonVolverModificarCuenta_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["ProfilePanel"]);
            ShowLastPanel();
        }

        private void panelCambiarContraseña_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

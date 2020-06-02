using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega3Spotiflix.CustomsEvenArgs;

namespace Entrega3Spotiflix
{
    public partial class AppForm : Form
    {
        //Organizacion
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        //Eventos
        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterClicked;
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;

        public AppForm()
        {
            InitializeComponent();
            panels.Add("EntradaPanel", panelEntrada);
            panels.Add("LoginPanel", panelLogin);
            panels.Add("RegisterPanel", panelRegister);
            panels.Add("MenuPanel", panelMenu);
            panels.Add("ModificarCuentaPanel", panelModificarCuenta);
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }
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
        private void OnUserChecked(string username)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username });
                loginViewUserInput.ResetText();
                loginViewPassWordInput.ResetText();
                setNameUser(username);
                stackPanels.Add(panels["MenuPanel"]);
                ShowLastPanel();
            }
        }
        private void OnRegisterClicked(string username, string email, string pass, string tipo_usuario)
        {
            if ((tipo_usuario == "") || (username == "") || pass == "" || email == "")
            {
                registerViewInvalidCredentialsAlert.Text = "Agregue los valores que faltan";
                registerViewInvalidCredentialsAlert.Visible = true;
            }
            else
            {
                bool result = RegisterClicked(this, new RegisterEventArgs() { Username = username, Password = pass, Email = email, Tipo_usuario = tipo_usuario });
                if (!result)
                {
                    registerViewInvalidCredentialsAlert.Text = "Esta cuenta ya existe";
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
        public void setNameUser(string username)
        {
            textBoxUsernamePerfil.Text = username;
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
            stackPanels.Add(panels["RegisterPanel"]);
            ShowLastPanel();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginViewButton_Click(object sender, EventArgs e)
        {
            string username = loginViewUserInput.Text;
            string pass = loginViewPassWordInput.Text;
            OnLoginButtonClicked(username, pass);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginViewInvalidCredentialsAlert_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginViewPassWordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginViewUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolverDeLogin_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }

        private void registerViewButton_Click(object sender, EventArgs e)
        {
            string username = registerViewUserInput.Text;
            string email = registerViewEmailInput.Text;
            string pass = registerViewPassInput.Text;
            string tipo_usuario = registerViewTipoInput.Text;
            OnRegisterClicked(username, email, pass, tipo_usuario);
        }

        private void buttonVolverDeRegister_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }

        private void buttonModificarCuenta_Click(object sender, EventArgs e)
        {
            textBoxHacersePremium.Visible = false;
            label11.Visible = false;
            textBoxUsuarioCambioUsername.Visible = false;
            buttonConfirmarCambioUsername.Visible = false;
            textBoxCambiarUsername.Visible = false;
            textBoxContraseñaCambioContraseña.Visible = false;
            textBoxAntiguaContraseñaCambioContraseña.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            buttonConfirmarCambioContraseña.Visible = false;
            textBoxCambioContraseña.Visible = false;
            stackPanels.Add(panels["ModificarCuentaPanel"]);
            ShowLastPanel();
        }

        private void buttonVolverDeModificarCuenta_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void buttonCambiarContraseña_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            textBoxUsuarioCambioUsername.Visible = false;
            buttonConfirmarCambioUsername.Visible = false;
            textBoxContraseñaCambioContraseña.ResetText();
            textBoxAntiguaContraseñaCambioContraseña.ResetText();
            textBoxCambioContraseña.ResetText();
            textBoxHacersePremium.Visible = false;
            textBoxCambiarUsername.Visible = false;
            textBoxContraseñaCambioContraseña.Visible = true;
            textBoxAntiguaContraseñaCambioContraseña.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            buttonConfirmarCambioContraseña.Visible = true;
            textBoxCambioContraseña.Visible = true;
        }

        private void buttonCambiarUsername_Click(object sender, EventArgs e)
        {
            textBoxContraseñaCambioContraseña.Visible = false;
            textBoxAntiguaContraseñaCambioContraseña.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            buttonConfirmarCambioContraseña.Visible = false;
            textBoxCambioContraseña.Visible = false;
            textBoxHacersePremium.Visible = false;
            textBoxUsuarioCambioUsername.ResetText();
            textBoxCambiarUsername.ResetText();
            label11.Visible = true;
            textBoxUsuarioCambioUsername.Visible = true;
            buttonConfirmarCambioUsername.Visible = true;
            textBoxCambiarUsername.Visible = true;
        }

        private void buttonHacersePremium_Click(object sender, EventArgs e)
        {
            textBoxContraseñaCambioContraseña.Visible = false;
            textBoxAntiguaContraseñaCambioContraseña.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            buttonConfirmarCambioContraseña.Visible = false;
            textBoxCambioContraseña.Visible = false;
            label11.Visible = false;
            textBoxUsuarioCambioUsername.Visible = false;
            buttonConfirmarCambioUsername.Visible = false;
            textBoxCambioContraseña.Visible = false;
            textBoxCambiarUsername.Visible = false;
            textBoxHacersePremium.Visible = true;
            string usuario_ant = textBoxUsernamePerfil.Text;
            List<string> Valores = Archivos.GetData(usuario_ant);
            if (Valores[3].Contains("Premium"))
            {
                textBoxHacersePremium.Visible = true;
                textBoxHacersePremium.Text = "Este Usuario ya es premium";
            }
            else
            {
                foreach (Usuario usuario in Archivos.Usuarios)
                {
                    if (usuario.Nombre_usuario == usuario_ant)
                    {
                        usuario.Tipo_usuario = "Premium";
                        textBoxHacersePremium.Text = "Se ha realizado el cambio con éxito";
                        textBoxHacersePremium.Visible = false;
                    }
                }
            }
        }

        private void buttonConfirmarCambioUsername_Click(object sender, EventArgs e)
        {
            string usuario_ant = textBoxUsernamePerfil.Text;
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
            textBoxUsernamePerfil.Text = usuario_nuevo;
            textBoxCambiarUsername.Text = "Username cambiado con éxito";
            label11.Visible = false;
            textBoxUsuarioCambioUsername.Visible = false;
            buttonConfirmarCambioUsername.Visible = false;
        }

        private void buttonConfirmarCambioContraseña_Click(object sender, EventArgs e)
        {
            string user = textBoxUsernamePerfil.Text;
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
                    }
                    else
                    {
                        textBoxCambioContraseña.Text = "Contraseña Actual Incorrecta";
                    }
                }
            }
            textBoxContraseñaCambioContraseña.Visible = false;
            textBoxAntiguaContraseñaCambioContraseña.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            buttonConfirmarCambioContraseña.Visible = false;
        }

        private void textBoxAntiguaContraseñaCambioContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHacersePremium_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCambioContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCambiarUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseñaCambioContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuarioCambioUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsernamePerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void FotoMenu_Click(object sender, EventArgs e)
        {

        }
    }
}

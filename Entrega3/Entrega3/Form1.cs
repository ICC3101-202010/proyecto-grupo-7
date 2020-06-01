using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega3
{
    public partial class Form1 : Form
    {
        //Organizacion
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        //Eventos
        public delegate bool CreateAccountEventHandler(object source, RegisterEventArgs args);
        public event CreateAccountEventHandler CreateAccountClicked;
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;

        //Metodos Internos
        private void OnLoginButtonClicked(string username, string pass)
        {
            if (LoginButtonClicked != null)
            {
                bool result = LoginButtonClicked(this, new LoginEventArgs() { UsernameText = username, PasswordText = pass });
                if (!result)
                {
                    CredencialesInvalidasLogin.Text = "Credenciales invalidas";
                    CredencialesInvalidasLogin.Visible = true;
                }
                else
                {
                    CredencialesInvalidasLogin.ResetText();
                    CredencialesInvalidasLogin.Visible = false;
                    OnUserChecked(username);
                }
            }
        }
        public void setNombreUsuario(string username)
        {
            UsuarioLogin.Text = username;
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
        private void OnUserChecked(string username)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username });
                UsuarioLogin.ResetText();
                UsuarioLogin.ResetText();
                stackPanels.Add(panels["MenuPanel"]);
                setNombreUsuario(username);
                stackPanels.Add(panels["EntradaPanel"]);
                ShowLastPanel();
            }
        }
        private void OnCreateAccountClicked(string username, string email, string pass, string type)
        {
            if ((type == "") || (type == "") || (username == "") || pass == "" || email == "")
            {
                CredencialesInválidasRegister.Text = "Agregue los valores que faltan";
                CredencialesInválidasRegister.Visible = true;
            }
            else
            {
                /*bool result = */CreateAccountClicked(this, new RegisterEventArgs() { Password = pass, Username = username, Email = email });
                /*if (!result)
                {
                    CredencialesInválidasRegister.Text = "Usuario y/o email ya existen";
                    CredencialesInválidasRegister.Visible = true;
                }
                else
                {
                    CredencialesInválidasRegister.ResetText();
                    CredencialesInválidasRegister.Visible = false;
                    OnUserChecked(username);
                }*/
            }
        }

        public Form1()
        {
            InitializeComponent();
            panels.Add("EntradaPanel", panelEntrada);
            panels.Add("LoginPanel", panelLogin);
            panels.Add("RegisterPanel", panelRegister);
            panels.Add("MenuPanel", panelMenu);
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }

        private void buttonGoLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
        }

        private void buttonGoRegister_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
        }

        private void buttonVolverDeRegister_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = UsuarioRegister.Text;
            string email = EmailRegister.Text;
            string pass = ContraseñaRegister.Text;
            string type = TipoUsuarioRegister.Text;
            OnCreateAccountClicked(username, email, pass, type);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = UsuarioLogin.Text;
            string pass = ContraseñaLogin.Text;
            OnLoginButtonClicked(username, pass);
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
    }
}

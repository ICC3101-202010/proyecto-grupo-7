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
            panels.Add("WelcomePanel", panelBienvenido);
            panels.Add("LoginPanel", panelLogin);
            panels.Add("CreateAccountPanel", panelRegister);
            panels.Add("Menú", PanelMenu);
            stackPanels.Add(panels["WelcomePanel"]);
            ShowLastPanel();
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
                    panel.Visible = true;
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["Menú"]);
            ShowLastPanel();
        }

        private void buttonVolver1_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["WelcomePanel"]);
            ShowLastPanel();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsuarioLogin.Text;
            string pass = textBoxContraseñaLogin.Text;
            //OnLoginButtonClicked(username, pass);
        }
        
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["WelcomePanel"]);
            ShowLastPanel();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["WelcomePanel"]);
            ShowLastPanel();
        }

        private void buttonGoLogin(object sender, EventArgs e)
        {
            stackPanels.Add(panels["LoginPanel"]);
            ShowLastPanel();
        }

        private void buttonGoRegister(object sender, EventArgs e)
        {
            stackPanels.Add(panels["CreateAccountPanel"]);
            ShowLastPanel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void setNombreUsuario(string username)
        {
            textBoxUsuarioLogin.Text = username;
        }
        private void OnUserChecked(string username)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username });
                textBoxUsuarioLogin.ResetText();
                textBoxContraseñaLogin.ResetText();
                stackPanels.Add(panels["Menú"]);
                setNombreUsuario(username);
                ShowLastPanel();
            }
        }
    }
}

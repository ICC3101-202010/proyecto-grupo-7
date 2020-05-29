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
            panels.Add("LoginPanel", panel1);
            panels.Add("CreateAccountPanel", panel2);
            panels.Add("Menú", panel3);
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
        private void button1GoLogin_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["LoginPanel"]);
            ShowLastPanel();
        }

        private void button2GoRegister_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["CreateAccountPanel"]);
            ShowLastPanel();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void buttonVolver1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1GoLogin_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2GoRegister_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
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

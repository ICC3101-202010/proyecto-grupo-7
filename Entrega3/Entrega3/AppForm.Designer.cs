namespace Entrega3
{
    partial class AppForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.TextCredencialesInválidas = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContraseñaLogin = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelBienvenido = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonVolver1 = new System.Windows.Forms.Button();
            this.textBoxEmailRegister = new System.Windows.Forms.TextBox();
            this.textBoxTipoRegister = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaRegister = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxUsuarioRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelBienvenido.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.TextCredencialesInválidas);
            this.panelLogin.Controls.Add(this.buttonVolver);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.textBoxContraseñaLogin);
            this.panelLogin.Controls.Add(this.textBoxUsuarioLogin);
            this.panelLogin.Controls.Add(this.textBox4);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(728, 352);
            this.panelLogin.TabIndex = 14;
            // 
            // TextCredencialesInválidas
            // 
            this.TextCredencialesInválidas.AutoSize = true;
            this.TextCredencialesInválidas.Location = new System.Drawing.Point(351, 239);
            this.TextCredencialesInválidas.Name = "TextCredencialesInválidas";
            this.TextCredencialesInválidas.Size = new System.Drawing.Size(59, 13);
            this.TextCredencialesInválidas.TabIndex = 11;
            this.TextCredencialesInválidas.Text = "USUARIO:";
            this.TextCredencialesInválidas.Visible = false;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(28, 311);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(87, 29);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "VOLVER";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(326, 269);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(111, 30);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "INICIAR SESIÓN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "USUARIO:";
            // 
            // textBoxContraseñaLogin
            // 
            this.textBoxContraseñaLogin.Location = new System.Drawing.Point(337, 216);
            this.textBoxContraseñaLogin.Name = "textBoxContraseñaLogin";
            this.textBoxContraseñaLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseñaLogin.TabIndex = 6;
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(337, 163);
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuarioLogin.TabIndex = 5;
            this.textBoxUsuarioLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(728, 30);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Spotflix";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBienvenido
            // 
            this.panelBienvenido.Controls.Add(this.button2);
            this.panelBienvenido.Controls.Add(this.button1);
            this.panelBienvenido.Controls.Add(this.label9);
            this.panelBienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBienvenido.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenido.Name = "panelBienvenido";
            this.panelBienvenido.Size = new System.Drawing.Size(728, 352);
            this.panelBienvenido.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 57);
            this.button2.TabIndex = 14;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonGoRegister);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 57);
            this.button1.TabIndex = 13;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGoLogin);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 36);
            this.label9.TabIndex = 12;
            this.label9.Text = "¡Bienvenido a Spotiflix!";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.panelBienvenido);
            this.PanelMenu.Controls.Add(this.buttonLogOut);
            this.PanelMenu.Controls.Add(this.textBox3);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(728, 352);
            this.PanelMenu.TabIndex = 19;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(28, 288);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(109, 40);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Cerrar Sesión";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(728, 30);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Menú";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.PanelMenu);
            this.panelRegister.Controls.Add(this.panelLogin);
            this.panelRegister.Controls.Add(this.buttonVolver1);
            this.panelRegister.Controls.Add(this.textBoxEmailRegister);
            this.panelRegister.Controls.Add(this.textBoxTipoRegister);
            this.panelRegister.Controls.Add(this.textBoxContraseñaRegister);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.textBoxUsuarioRegister);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(728, 352);
            this.panelRegister.TabIndex = 11;
            // 
            // buttonVolver1
            // 
            this.buttonVolver1.Location = new System.Drawing.Point(12, 311);
            this.buttonVolver1.Name = "buttonVolver1";
            this.buttonVolver1.Size = new System.Drawing.Size(92, 29);
            this.buttonVolver1.TabIndex = 18;
            this.buttonVolver1.Text = "VOLVER";
            this.buttonVolver1.UseVisualStyleBackColor = true;
            this.buttonVolver1.Click += new System.EventHandler(this.buttonVolver1_Click);
            // 
            // textBoxEmailRegister
            // 
            this.textBoxEmailRegister.Location = new System.Drawing.Point(337, 144);
            this.textBoxEmailRegister.Name = "textBoxEmailRegister";
            this.textBoxEmailRegister.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailRegister.TabIndex = 17;
            // 
            // textBoxTipoRegister
            // 
            this.textBoxTipoRegister.Location = new System.Drawing.Point(337, 229);
            this.textBoxTipoRegister.Name = "textBoxTipoRegister";
            this.textBoxTipoRegister.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipoRegister.TabIndex = 16;
            // 
            // textBoxContraseñaRegister
            // 
            this.textBoxContraseñaRegister.Location = new System.Drawing.Point(337, 187);
            this.textBoxContraseñaRegister.Name = "textBoxContraseñaRegister";
            this.textBoxContraseñaRegister.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseñaRegister.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingrese su Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese su Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese el Tipo de Cuenta:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(299, 269);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(127, 38);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Registrarse";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxUsuarioRegister
            // 
            this.textBoxUsuarioRegister.Location = new System.Drawing.Point(337, 102);
            this.textBoxUsuarioRegister.Name = "textBoxUsuarioRegister";
            this.textBoxUsuarioRegister.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuarioRegister.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese su Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingrese sus datos para registrarse";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 352);
            this.Controls.Add(this.panelRegister);
            this.Name = "AppForm";
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelBienvenido.ResumeLayout(false);
            this.panelBienvenido.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button buttonVolver1;
        private System.Windows.Forms.TextBox textBoxEmailRegister;
        private System.Windows.Forms.TextBox textBoxTipoRegister;
        private System.Windows.Forms.TextBox textBoxContraseñaRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxUsuarioRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContraseñaLogin;
        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelBienvenido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TextCredencialesInválidas;
    }
}


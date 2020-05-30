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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1GoLogin = new System.Windows.Forms.Button();
            this.button2GoRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
=======
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
>>>>>>> a600ea2beb36d55ad8537cc05abad3b0564b8d81
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
<<<<<<< HEAD
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "¡Bienvenido a Spotiflix!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1GoLogin
            // 
            this.button1GoLogin.Location = new System.Drawing.Point(352, 251);
            this.button1GoLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1GoLogin.Name = "button1GoLogin";
            this.button1GoLogin.Size = new System.Drawing.Size(344, 88);
            this.button1GoLogin.TabIndex = 12;
            this.button1GoLogin.Text = "Iniciar Sesión";
            this.button1GoLogin.UseVisualStyleBackColor = true;
            this.button1GoLogin.Click += new System.EventHandler(this.button1GoLogin_Click);
            // 
            // button2GoRegister
            // 
            this.button2GoRegister.Location = new System.Drawing.Point(352, 348);
            this.button2GoRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2GoRegister.Name = "button2GoRegister";
            this.button2GoRegister.Size = new System.Drawing.Size(344, 88);
            this.button2GoRegister.TabIndex = 13;
            this.button2GoRegister.Text = "Registrarse";
            this.button2GoRegister.UseVisualStyleBackColor = true;
            this.button2GoRegister.Click += new System.EventHandler(this.button2GoRegister_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonVolver);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 549);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonVolver1);
            this.panel2.Controls.Add(this.textBoxEmailRegister);
            this.panel2.Controls.Add(this.textBoxTipoRegister);
            this.panel2.Controls.Add(this.textBoxContraseñaRegister);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buttonRegister);
            this.panel2.Controls.Add(this.textBoxUsuarioRegister);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 549);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPath);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.MediaPlayer);
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1129, 549);
            this.panel3.TabIndex = 19;
            this.panel3.Visible = false;
=======
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
>>>>>>> a600ea2beb36d55ad8537cc05abad3b0564b8d81
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(38, 12);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(413, 302);
            this.MediaPlayer.TabIndex = 6;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(602, 337);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(164, 62);
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
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1129, 45);
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
            this.buttonVolver1.Location = new System.Drawing.Point(18, 478);
            this.buttonVolver1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVolver1.Name = "buttonVolver1";
            this.buttonVolver1.Size = new System.Drawing.Size(138, 45);
            this.buttonVolver1.TabIndex = 18;
            this.buttonVolver1.Text = "VOLVER";
            this.buttonVolver1.UseVisualStyleBackColor = true;
            this.buttonVolver1.Click += new System.EventHandler(this.buttonVolver1_Click);
            // 
            // textBoxEmailRegister
            // 
            this.textBoxEmailRegister.Location = new System.Drawing.Point(506, 222);
            this.textBoxEmailRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmailRegister.Name = "textBoxEmailRegister";
            this.textBoxEmailRegister.Size = new System.Drawing.Size(148, 26);
            this.textBoxEmailRegister.TabIndex = 17;
            // 
            // textBoxTipoRegister
            // 
            this.textBoxTipoRegister.Location = new System.Drawing.Point(506, 352);
            this.textBoxTipoRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTipoRegister.Name = "textBoxTipoRegister";
            this.textBoxTipoRegister.Size = new System.Drawing.Size(148, 26);
            this.textBoxTipoRegister.TabIndex = 16;
            // 
            // textBoxContraseñaRegister
            // 
            this.textBoxContraseñaRegister.Location = new System.Drawing.Point(506, 288);
            this.textBoxContraseñaRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContraseñaRegister.Name = "textBoxContraseñaRegister";
            this.textBoxContraseñaRegister.Size = new System.Drawing.Size(148, 26);
            this.textBoxContraseñaRegister.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingrese su Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese su Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese el Tipo de Cuenta:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(448, 414);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(190, 58);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Registrarse";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxUsuarioRegister
            // 
            this.textBoxUsuarioRegister.Location = new System.Drawing.Point(506, 157);
            this.textBoxUsuarioRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsuarioRegister.Name = "textBoxUsuarioRegister";
            this.textBoxUsuarioRegister.Size = new System.Drawing.Size(148, 26);
            this.textBoxUsuarioRegister.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese su Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(621, 46);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingrese sus datos para registrarse";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
<<<<<<< HEAD
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(42, 478);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(130, 45);
            this.buttonVolver.TabIndex = 10;
            this.buttonVolver.Text = "VOLVER";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(489, 414);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(166, 46);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "INICIAR SESIÓN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "USUARIO:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(506, 332);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 251);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1129, 45);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Spotflix";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "FullScreen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Location = new System.Drawing.Point(42, 398);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(409, 38);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "Select a File";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
=======
>>>>>>> a600ea2beb36d55ad8537cc05abad3b0564b8d81
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1129, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2GoRegister);
            this.Controls.Add(this.button1GoLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
=======
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
>>>>>>> a600ea2beb36d55ad8537cc05abad3b0564b8d81
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
<<<<<<< HEAD
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.Panel panelBienvenido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TextCredencialesInválidas;
>>>>>>> a600ea2beb36d55ad8537cc05abad3b0564b8d81
    }
}


namespace Entrega3
{
    partial class Form1
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
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonVolverDeLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ContraseñaLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CredencialesInválidasRegister = new System.Windows.Forms.TextBox();
            this.buttonVolverDeRegister = new System.Windows.Forms.Button();
            this.EmailRegister = new System.Windows.Forms.TextBox();
            this.TipoUsuarioRegister = new System.Windows.Forms.TextBox();
            this.ContraseñaRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioRegister = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoRegister = new System.Windows.Forms.Button();
            this.buttonGoLogin = new System.Windows.Forms.Button();
            this.UsuarioLogin = new System.Windows.Forms.TextBox();
            this.CredencialesInvalidasLogin = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelEntrada.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntrada
            // 
            this.panelEntrada.Controls.Add(this.panelRegister);
            this.panelEntrada.Controls.Add(this.buttonGoRegister);
            this.panelEntrada.Controls.Add(this.buttonGoLogin);
            this.panelEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntrada.Location = new System.Drawing.Point(0, 0);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(676, 353);
            this.panelEntrada.TabIndex = 0;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.panelLogin);
            this.panelRegister.Controls.Add(this.CredencialesInválidasRegister);
            this.panelRegister.Controls.Add(this.buttonVolverDeRegister);
            this.panelRegister.Controls.Add(this.EmailRegister);
            this.panelRegister.Controls.Add(this.TipoUsuarioRegister);
            this.panelRegister.Controls.Add(this.ContraseñaRegister);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.UsuarioRegister);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(676, 353);
            this.panelRegister.TabIndex = 2;
            this.panelRegister.Visible = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelMenu);
            this.panelLogin.Controls.Add(this.CredencialesInvalidasLogin);
            this.panelLogin.Controls.Add(this.UsuarioLogin);
            this.panelLogin.Controls.Add(this.buttonVolverDeLogin);
            this.panelLogin.Controls.Add(this.label6);
            this.panelLogin.Controls.Add(this.ContraseñaLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label5);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(676, 353);
            this.panelLogin.TabIndex = 11;
            this.panelLogin.Visible = false;
            // 
            // buttonVolverDeLogin
            // 
            this.buttonVolverDeLogin.Location = new System.Drawing.Point(12, 301);
            this.buttonVolverDeLogin.Name = "buttonVolverDeLogin";
            this.buttonVolverDeLogin.Size = new System.Drawing.Size(101, 40);
            this.buttonVolverDeLogin.TabIndex = 4;
            this.buttonVolverDeLogin.Text = "VOLVER";
            this.buttonVolverDeLogin.UseVisualStyleBackColor = true;
            this.buttonVolverDeLogin.Click += new System.EventHandler(this.buttonVolverDeLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // ContraseñaLogin
            // 
            this.ContraseñaLogin.Location = new System.Drawing.Point(287, 164);
            this.ContraseñaLogin.Name = "ContraseñaLogin";
            this.ContraseñaLogin.Size = new System.Drawing.Size(100, 20);
            this.ContraseñaLogin.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(260, 216);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(136, 43);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "INICIAR SESIÓN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // CredencialesInválidasRegister
            // 
            this.CredencialesInválidasRegister.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CredencialesInválidasRegister.Location = new System.Drawing.Point(287, 243);
            this.CredencialesInválidasRegister.Name = "CredencialesInválidasRegister";
            this.CredencialesInválidasRegister.Size = new System.Drawing.Size(100, 20);
            this.CredencialesInválidasRegister.TabIndex = 10;
            this.CredencialesInválidasRegister.Visible = false;
            // 
            // buttonVolverDeRegister
            // 
            this.buttonVolverDeRegister.Location = new System.Drawing.Point(12, 301);
            this.buttonVolverDeRegister.Name = "buttonVolverDeRegister";
            this.buttonVolverDeRegister.Size = new System.Drawing.Size(110, 40);
            this.buttonVolverDeRegister.TabIndex = 9;
            this.buttonVolverDeRegister.Text = "VOLVER";
            this.buttonVolverDeRegister.UseVisualStyleBackColor = true;
            this.buttonVolverDeRegister.Click += new System.EventHandler(this.buttonVolverDeRegister_Click);
            // 
            // EmailRegister
            // 
            this.EmailRegister.Location = new System.Drawing.Point(287, 119);
            this.EmailRegister.Name = "EmailRegister";
            this.EmailRegister.Size = new System.Drawing.Size(100, 20);
            this.EmailRegister.TabIndex = 8;
            // 
            // TipoUsuarioRegister
            // 
            this.TipoUsuarioRegister.Location = new System.Drawing.Point(287, 213);
            this.TipoUsuarioRegister.Name = "TipoUsuarioRegister";
            this.TipoUsuarioRegister.Size = new System.Drawing.Size(100, 20);
            this.TipoUsuarioRegister.TabIndex = 7;
            // 
            // ContraseñaRegister
            // 
            this.ContraseñaRegister.Location = new System.Drawing.Point(287, 167);
            this.ContraseñaRegister.Name = "ContraseñaRegister";
            this.ContraseñaRegister.Size = new System.Drawing.Size(100, 20);
            this.ContraseñaRegister.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TIPO DE USUARIO:";
            // 
            // UsuarioRegister
            // 
            this.UsuarioRegister.Location = new System.Drawing.Point(287, 73);
            this.UsuarioRegister.Name = "UsuarioRegister";
            this.UsuarioRegister.Size = new System.Drawing.Size(100, 20);
            this.UsuarioRegister.TabIndex = 2;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(260, 269);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(132, 39);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "REGISTRARSE";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            // 
            // buttonGoRegister
            // 
            this.buttonGoRegister.Location = new System.Drawing.Point(239, 207);
            this.buttonGoRegister.Name = "buttonGoRegister";
            this.buttonGoRegister.Size = new System.Drawing.Size(153, 56);
            this.buttonGoRegister.TabIndex = 1;
            this.buttonGoRegister.Text = "REGISTRARSE";
            this.buttonGoRegister.UseVisualStyleBackColor = true;
            this.buttonGoRegister.Click += new System.EventHandler(this.buttonGoRegister_Click);
            // 
            // buttonGoLogin
            // 
            this.buttonGoLogin.Location = new System.Drawing.Point(239, 132);
            this.buttonGoLogin.Name = "buttonGoLogin";
            this.buttonGoLogin.Size = new System.Drawing.Size(153, 56);
            this.buttonGoLogin.TabIndex = 0;
            this.buttonGoLogin.Text = "INICIAR SESIÓN";
            this.buttonGoLogin.UseVisualStyleBackColor = true;
            this.buttonGoLogin.Click += new System.EventHandler(this.buttonGoLogin_Click);
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.Location = new System.Drawing.Point(287, 126);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(100, 20);
            this.UsuarioLogin.TabIndex = 5;
            // 
            // CredencialesInvalidasLogin
            // 
            this.CredencialesInvalidasLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CredencialesInvalidasLogin.Location = new System.Drawing.Point(287, 187);
            this.CredencialesInvalidasLogin.Name = "CredencialesInvalidasLogin";
            this.CredencialesInvalidasLogin.Size = new System.Drawing.Size(100, 20);
            this.CredencialesInvalidasLogin.TabIndex = 6;
            this.CredencialesInvalidasLogin.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonLogOut);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(676, 353);
            this.panelMenu.TabIndex = 7;
            this.panelMenu.Visible = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(12, 301);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(110, 40);
            this.buttonLogOut.TabIndex = 0;
            this.buttonLogOut.Text = "CERRAR SESIÓN";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 353);
            this.Controls.Add(this.panelEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEntrada.ResumeLayout(false);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Button buttonGoRegister;
        private System.Windows.Forms.Button buttonGoLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button buttonVolverDeRegister;
        private System.Windows.Forms.TextBox EmailRegister;
        private System.Windows.Forms.TextBox TipoUsuarioRegister;
        private System.Windows.Forms.TextBox ContraseñaRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CredencialesInválidasRegister;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonVolverDeLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ContraseñaLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CredencialesInvalidasLogin;
        private System.Windows.Forms.TextBox UsuarioLogin;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonLogOut;
    }
}


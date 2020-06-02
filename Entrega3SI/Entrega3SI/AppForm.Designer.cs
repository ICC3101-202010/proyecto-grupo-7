namespace Entrega3SI
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
            this.LoginView = new System.Windows.Forms.Panel();
            this.loginViewInvalidCredentialsAlert = new System.Windows.Forms.TextBox();
            this.loginViewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginViewPassWordInput = new System.Windows.Forms.TextBox();
            this.loginViewUserInput = new System.Windows.Forms.TextBox();
            this.profileView = new System.Windows.Forms.Panel();
            this.panelModificarCuenta = new System.Windows.Forms.Panel();
            this.buttonVolverModificarCuenta = new System.Windows.Forms.Button();
            this.panelCambiarContraseña = new System.Windows.Forms.Panel();
            this.textBoxAntiguaContraseñaCambioContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonConfirmarCambioContraseña = new System.Windows.Forms.Button();
            this.textBoxCambioContraseña = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaCambioContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCambiarUsername = new System.Windows.Forms.Panel();
            this.buttonConfirmarCambioUsername = new System.Windows.Forms.Button();
            this.textBoxCambiarUsername = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioCambioUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelHacersePremium = new System.Windows.Forms.Panel();
            this.textBoxHacersePremium = new System.Windows.Forms.TextBox();
            this.buttonHacersePremium = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCambiarContraseña = new System.Windows.Forms.Button();
            this.buttonModificarCuenta = new System.Windows.Forms.Button();
            this.profileViewNameText = new System.Windows.Forms.TextBox();
            this.profileViewAgeText = new System.Windows.Forms.TextBox();
            this.profileViewUserText = new System.Windows.Forms.TextBox();
            this.profileViewLogOutButton = new System.Windows.Forms.Button();
            this.EntradaView = new System.Windows.Forms.Panel();
            this.RegisterView = new System.Windows.Forms.Panel();
            this.registerViewInvalidCredentialsAlert = new System.Windows.Forms.TextBox();
            this.registerViewLogOutButton = new System.Windows.Forms.Button();
            this.registerViewEmailInput = new System.Windows.Forms.TextBox();
            this.registerViewPassInput = new System.Windows.Forms.TextBox();
            this.registerViewTipoInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registerViewUserInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerViewButton = new System.Windows.Forms.Button();
            this.buttonGoRegister = new System.Windows.Forms.Button();
            this.buttonGoLogin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LoginView.SuspendLayout();
            this.profileView.SuspendLayout();
            this.panelModificarCuenta.SuspendLayout();
            this.panelCambiarContraseña.SuspendLayout();
            this.panelCambiarUsername.SuspendLayout();
            this.panelHacersePremium.SuspendLayout();
            this.EntradaView.SuspendLayout();
            this.RegisterView.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginView
            // 
            this.LoginView.Controls.Add(this.loginViewInvalidCredentialsAlert);
            this.LoginView.Controls.Add(this.loginViewButton);
            this.LoginView.Controls.Add(this.label2);
            this.LoginView.Controls.Add(this.label1);
            this.LoginView.Controls.Add(this.loginViewPassWordInput);
            this.LoginView.Controls.Add(this.loginViewUserInput);
            this.LoginView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginView.Location = new System.Drawing.Point(0, 0);
            this.LoginView.Name = "LoginView";
            this.LoginView.Size = new System.Drawing.Size(800, 450);
            this.LoginView.TabIndex = 0;
            this.LoginView.Visible = false;
            // 
            // loginViewInvalidCredentialsAlert
            // 
            this.loginViewInvalidCredentialsAlert.Location = new System.Drawing.Point(305, 222);
            this.loginViewInvalidCredentialsAlert.Name = "loginViewInvalidCredentialsAlert";
            this.loginViewInvalidCredentialsAlert.Size = new System.Drawing.Size(131, 20);
            this.loginViewInvalidCredentialsAlert.TabIndex = 5;
            this.loginViewInvalidCredentialsAlert.Visible = false;
            // 
            // loginViewButton
            // 
            this.loginViewButton.Location = new System.Drawing.Point(326, 248);
            this.loginViewButton.Name = "loginViewButton";
            this.loginViewButton.Size = new System.Drawing.Size(110, 36);
            this.loginViewButton.TabIndex = 4;
            this.loginViewButton.Text = "INICIAR SESIÓN";
            this.loginViewButton.UseVisualStyleBackColor = true;
            this.loginViewButton.Click += new System.EventHandler(this.loginViewButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME:";
            // 
            // loginViewPassWordInput
            // 
            this.loginViewPassWordInput.Location = new System.Drawing.Point(336, 196);
            this.loginViewPassWordInput.Name = "loginViewPassWordInput";
            this.loginViewPassWordInput.Size = new System.Drawing.Size(100, 20);
            this.loginViewPassWordInput.TabIndex = 1;
            // 
            // loginViewUserInput
            // 
            this.loginViewUserInput.Location = new System.Drawing.Point(336, 149);
            this.loginViewUserInput.Name = "loginViewUserInput";
            this.loginViewUserInput.Size = new System.Drawing.Size(100, 20);
            this.loginViewUserInput.TabIndex = 0;
            // 
            // profileView
            // 
            this.profileView.Controls.Add(this.label11);
            this.profileView.Controls.Add(this.buttonModificarCuenta);
            this.profileView.Controls.Add(this.profileViewNameText);
            this.profileView.Controls.Add(this.profileViewAgeText);
            this.profileView.Controls.Add(this.profileViewUserText);
            this.profileView.Controls.Add(this.profileViewLogOutButton);
            this.profileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileView.Location = new System.Drawing.Point(0, 0);
            this.profileView.Name = "profileView";
            this.profileView.Size = new System.Drawing.Size(800, 450);
            this.profileView.TabIndex = 6;
            this.profileView.Visible = false;
            // 
            // panelModificarCuenta
            // 
            this.panelModificarCuenta.Controls.Add(this.profileView);
            this.panelModificarCuenta.Controls.Add(this.buttonVolverModificarCuenta);
            this.panelModificarCuenta.Controls.Add(this.panelCambiarContraseña);
            this.panelModificarCuenta.Controls.Add(this.panelCambiarUsername);
            this.panelModificarCuenta.Controls.Add(this.panelHacersePremium);
            this.panelModificarCuenta.Controls.Add(this.buttonHacersePremium);
            this.panelModificarCuenta.Controls.Add(this.button1);
            this.panelModificarCuenta.Controls.Add(this.label7);
            this.panelModificarCuenta.Controls.Add(this.buttonCambiarContraseña);
            this.panelModificarCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModificarCuenta.Location = new System.Drawing.Point(0, 0);
            this.panelModificarCuenta.Name = "panelModificarCuenta";
            this.panelModificarCuenta.Size = new System.Drawing.Size(800, 450);
            this.panelModificarCuenta.TabIndex = 7;
            this.panelModificarCuenta.Visible = false;
            // 
            // buttonVolverModificarCuenta
            // 
            this.buttonVolverModificarCuenta.Location = new System.Drawing.Point(12, 400);
            this.buttonVolverModificarCuenta.Name = "buttonVolverModificarCuenta";
            this.buttonVolverModificarCuenta.Size = new System.Drawing.Size(107, 41);
            this.buttonVolverModificarCuenta.TabIndex = 28;
            this.buttonVolverModificarCuenta.Text = "VOLVER";
            this.buttonVolverModificarCuenta.UseVisualStyleBackColor = true;
            this.buttonVolverModificarCuenta.Click += new System.EventHandler(this.buttonVolverModificarCuenta_Click);
            // 
            // panelCambiarContraseña
            // 
            this.panelCambiarContraseña.Controls.Add(this.textBoxAntiguaContraseñaCambioContraseña);
            this.panelCambiarContraseña.Controls.Add(this.label10);
            this.panelCambiarContraseña.Controls.Add(this.buttonConfirmarCambioContraseña);
            this.panelCambiarContraseña.Controls.Add(this.textBoxCambioContraseña);
            this.panelCambiarContraseña.Controls.Add(this.textBoxContraseñaCambioContraseña);
            this.panelCambiarContraseña.Controls.Add(this.label9);
            this.panelCambiarContraseña.Location = new System.Drawing.Point(183, 337);
            this.panelCambiarContraseña.Name = "panelCambiarContraseña";
            this.panelCambiarContraseña.Size = new System.Drawing.Size(417, 113);
            this.panelCambiarContraseña.TabIndex = 27;
            this.panelCambiarContraseña.Visible = false;
            this.panelCambiarContraseña.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCambiarContraseña_Paint);
            // 
            // textBoxAntiguaContraseñaCambioContraseña
            // 
            this.textBoxAntiguaContraseñaCambioContraseña.Location = new System.Drawing.Point(210, 3);
            this.textBoxAntiguaContraseñaCambioContraseña.Name = "textBoxAntiguaContraseñaCambioContraseña";
            this.textBoxAntiguaContraseñaCambioContraseña.Size = new System.Drawing.Size(140, 20);
            this.textBoxAntiguaContraseñaCambioContraseña.TabIndex = 37;
            this.textBoxAntiguaContraseñaCambioContraseña.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ingrese su Contraseña:";
            this.label10.Visible = false;
            // 
            // buttonConfirmarCambioContraseña
            // 
            this.buttonConfirmarCambioContraseña.Location = new System.Drawing.Point(217, 56);
            this.buttonConfirmarCambioContraseña.Name = "buttonConfirmarCambioContraseña";
            this.buttonConfirmarCambioContraseña.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmarCambioContraseña.TabIndex = 33;
            this.buttonConfirmarCambioContraseña.Text = "ACEPTAR";
            this.buttonConfirmarCambioContraseña.UseVisualStyleBackColor = true;
            this.buttonConfirmarCambioContraseña.Visible = false;
            this.buttonConfirmarCambioContraseña.Click += new System.EventHandler(this.buttonConfirmarCambioContraseña_Click);
            // 
            // textBoxCambioContraseña
            // 
            this.textBoxCambioContraseña.Location = new System.Drawing.Point(77, 79);
            this.textBoxCambioContraseña.Name = "textBoxCambioContraseña";
            this.textBoxCambioContraseña.Size = new System.Drawing.Size(246, 20);
            this.textBoxCambioContraseña.TabIndex = 35;
            this.textBoxCambioContraseña.Visible = false;
            // 
            // textBoxContraseñaCambioContraseña
            // 
            this.textBoxContraseñaCambioContraseña.Location = new System.Drawing.Point(210, 32);
            this.textBoxContraseñaCambioContraseña.Name = "textBoxContraseñaCambioContraseña";
            this.textBoxContraseñaCambioContraseña.Size = new System.Drawing.Size(140, 20);
            this.textBoxContraseñaCambioContraseña.TabIndex = 34;
            this.textBoxContraseñaCambioContraseña.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ingrese la nueva Contraseña:";
            this.label9.Visible = false;
            // 
            // panelCambiarUsername
            // 
            this.panelCambiarUsername.Controls.Add(this.buttonConfirmarCambioUsername);
            this.panelCambiarUsername.Controls.Add(this.textBoxCambiarUsername);
            this.panelCambiarUsername.Controls.Add(this.textBoxUsuarioCambioUsername);
            this.panelCambiarUsername.Controls.Add(this.label8);
            this.panelCambiarUsername.Location = new System.Drawing.Point(183, 198);
            this.panelCambiarUsername.Name = "panelCambiarUsername";
            this.panelCambiarUsername.Size = new System.Drawing.Size(417, 93);
            this.panelCambiarUsername.TabIndex = 27;
            this.panelCambiarUsername.Visible = false;
            // 
            // buttonConfirmarCambioUsername
            // 
            this.buttonConfirmarCambioUsername.Location = new System.Drawing.Point(217, 43);
            this.buttonConfirmarCambioUsername.Name = "buttonConfirmarCambioUsername";
            this.buttonConfirmarCambioUsername.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmarCambioUsername.TabIndex = 30;
            this.buttonConfirmarCambioUsername.Text = "ACEPTAR";
            this.buttonConfirmarCambioUsername.UseVisualStyleBackColor = true;
            this.buttonConfirmarCambioUsername.Visible = false;
            this.buttonConfirmarCambioUsername.Click += new System.EventHandler(this.buttonConfirmarCambioUsername_Click);
            // 
            // textBoxCambiarUsername
            // 
            this.textBoxCambiarUsername.Location = new System.Drawing.Point(77, 66);
            this.textBoxCambiarUsername.Name = "textBoxCambiarUsername";
            this.textBoxCambiarUsername.Size = new System.Drawing.Size(246, 20);
            this.textBoxCambiarUsername.TabIndex = 31;
            this.textBoxCambiarUsername.Visible = false;
            // 
            // textBoxUsuarioCambioUsername
            // 
            this.textBoxUsuarioCambioUsername.Location = new System.Drawing.Point(210, 13);
            this.textBoxUsuarioCambioUsername.Name = "textBoxUsuarioCambioUsername";
            this.textBoxUsuarioCambioUsername.Size = new System.Drawing.Size(140, 20);
            this.textBoxUsuarioCambioUsername.TabIndex = 30;
            this.textBoxUsuarioCambioUsername.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ingrese el nuevo Username:";
            this.label8.Visible = false;
            // 
            // panelHacersePremium
            // 
            this.panelHacersePremium.Controls.Add(this.textBoxHacersePremium);
            this.panelHacersePremium.Location = new System.Drawing.Point(183, 64);
            this.panelHacersePremium.Name = "panelHacersePremium";
            this.panelHacersePremium.Size = new System.Drawing.Size(417, 93);
            this.panelHacersePremium.TabIndex = 26;
            this.panelHacersePremium.Visible = false;
            // 
            // textBoxHacersePremium
            // 
            this.textBoxHacersePremium.Location = new System.Drawing.Point(77, 39);
            this.textBoxHacersePremium.Name = "textBoxHacersePremium";
            this.textBoxHacersePremium.Size = new System.Drawing.Size(246, 20);
            this.textBoxHacersePremium.TabIndex = 29;
            this.textBoxHacersePremium.Visible = false;
            // 
            // buttonHacersePremium
            // 
            this.buttonHacersePremium.Location = new System.Drawing.Point(336, 23);
            this.buttonHacersePremium.Name = "buttonHacersePremium";
            this.buttonHacersePremium.Size = new System.Drawing.Size(107, 41);
            this.buttonHacersePremium.TabIndex = 25;
            this.buttonHacersePremium.Text = "Hacerse Premium";
            this.buttonHacersePremium.UseVisualStyleBackColor = true;
            this.buttonHacersePremium.Click += new System.EventHandler(this.buttonHacersePremium_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cambiar Username";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCambiarUsername_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 36);
            this.label7.TabIndex = 23;
            this.label7.Text = "Perfil";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCambiarContraseña
            // 
            this.buttonCambiarContraseña.Location = new System.Drawing.Point(336, 290);
            this.buttonCambiarContraseña.Name = "buttonCambiarContraseña";
            this.buttonCambiarContraseña.Size = new System.Drawing.Size(107, 41);
            this.buttonCambiarContraseña.TabIndex = 22;
            this.buttonCambiarContraseña.Text = "Cambiar contraseña";
            this.buttonCambiarContraseña.UseVisualStyleBackColor = true;
            this.buttonCambiarContraseña.Click += new System.EventHandler(this.buttonCambiarContraseña_Click);
            // 
            // buttonModificarCuenta
            // 
            this.buttonModificarCuenta.Location = new System.Drawing.Point(128, 400);
            this.buttonModificarCuenta.Name = "buttonModificarCuenta";
            this.buttonModificarCuenta.Size = new System.Drawing.Size(110, 38);
            this.buttonModificarCuenta.TabIndex = 6;
            this.buttonModificarCuenta.Text = "PERFIL USUARIO";
            this.buttonModificarCuenta.UseVisualStyleBackColor = true;
            // 
            // profileViewNameText
            // 
            this.profileViewNameText.Location = new System.Drawing.Point(219, 145);
            this.profileViewNameText.Name = "profileViewNameText";
            this.profileViewNameText.Size = new System.Drawing.Size(100, 20);
            this.profileViewNameText.TabIndex = 3;
            // 
            // profileViewAgeText
            // 
            this.profileViewAgeText.Location = new System.Drawing.Point(219, 192);
            this.profileViewAgeText.Name = "profileViewAgeText";
            this.profileViewAgeText.Size = new System.Drawing.Size(100, 20);
            this.profileViewAgeText.TabIndex = 2;
            // 
            // profileViewUserText
            // 
            this.profileViewUserText.Location = new System.Drawing.Point(219, 98);
            this.profileViewUserText.Name = "profileViewUserText";
            this.profileViewUserText.Size = new System.Drawing.Size(100, 20);
            this.profileViewUserText.TabIndex = 1;
            // 
            // profileViewLogOutButton
            // 
            this.profileViewLogOutButton.Location = new System.Drawing.Point(12, 400);
            this.profileViewLogOutButton.Name = "profileViewLogOutButton";
            this.profileViewLogOutButton.Size = new System.Drawing.Size(110, 38);
            this.profileViewLogOutButton.TabIndex = 0;
            this.profileViewLogOutButton.Text = "CERRAR SESIÓN";
            this.profileViewLogOutButton.UseVisualStyleBackColor = true;
            this.profileViewLogOutButton.Click += new System.EventHandler(this.profileViewLogOutButton_Click);
            // 
            // EntradaView
            // 
            this.EntradaView.Controls.Add(this.buttonGoRegister);
            this.EntradaView.Controls.Add(this.buttonGoLogin);
            this.EntradaView.Location = new System.Drawing.Point(12, 18);
            this.EntradaView.Name = "EntradaView";
            this.EntradaView.Size = new System.Drawing.Size(350, 238);
            this.EntradaView.TabIndex = 4;
            this.EntradaView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEntrada_Paint);
            // 
            // RegisterView
            // 
            this.RegisterView.Controls.Add(this.panelModificarCuenta);
            this.RegisterView.Controls.Add(this.registerViewInvalidCredentialsAlert);
            this.RegisterView.Controls.Add(this.registerViewLogOutButton);
            this.RegisterView.Controls.Add(this.registerViewEmailInput);
            this.RegisterView.Controls.Add(this.registerViewPassInput);
            this.RegisterView.Controls.Add(this.registerViewTipoInput);
            this.RegisterView.Controls.Add(this.label6);
            this.RegisterView.Controls.Add(this.label5);
            this.RegisterView.Controls.Add(this.label4);
            this.RegisterView.Controls.Add(this.registerViewUserInput);
            this.RegisterView.Controls.Add(this.label3);
            this.RegisterView.Controls.Add(this.registerViewButton);
            this.RegisterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterView.Location = new System.Drawing.Point(0, 0);
            this.RegisterView.Name = "RegisterView";
            this.RegisterView.Size = new System.Drawing.Size(800, 450);
            this.RegisterView.TabIndex = 2;
            this.RegisterView.Visible = false;
            this.RegisterView.Paint += new System.Windows.Forms.PaintEventHandler(this.RegisterView_Paint);
            // 
            // registerViewInvalidCredentialsAlert
            // 
            this.registerViewInvalidCredentialsAlert.Location = new System.Drawing.Point(336, 274);
            this.registerViewInvalidCredentialsAlert.Name = "registerViewInvalidCredentialsAlert";
            this.registerViewInvalidCredentialsAlert.Size = new System.Drawing.Size(139, 20);
            this.registerViewInvalidCredentialsAlert.TabIndex = 10;
            this.registerViewInvalidCredentialsAlert.Visible = false;
            // 
            // registerViewLogOutButton
            // 
            this.registerViewLogOutButton.Location = new System.Drawing.Point(21, 380);
            this.registerViewLogOutButton.Name = "registerViewLogOutButton";
            this.registerViewLogOutButton.Size = new System.Drawing.Size(125, 45);
            this.registerViewLogOutButton.TabIndex = 9;
            this.registerViewLogOutButton.Text = "VOLVER";
            this.registerViewLogOutButton.UseVisualStyleBackColor = true;
            this.registerViewLogOutButton.Click += new System.EventHandler(this.registerViewLogOutButton_Click);
            // 
            // registerViewEmailInput
            // 
            this.registerViewEmailInput.Location = new System.Drawing.Point(386, 149);
            this.registerViewEmailInput.Name = "registerViewEmailInput";
            this.registerViewEmailInput.Size = new System.Drawing.Size(100, 20);
            this.registerViewEmailInput.TabIndex = 8;
            // 
            // registerViewPassInput
            // 
            this.registerViewPassInput.Location = new System.Drawing.Point(386, 199);
            this.registerViewPassInput.Name = "registerViewPassInput";
            this.registerViewPassInput.Size = new System.Drawing.Size(100, 20);
            this.registerViewPassInput.TabIndex = 7;
            // 
            // registerViewTipoInput
            // 
            this.registerViewTipoInput.Location = new System.Drawing.Point(386, 248);
            this.registerViewTipoInput.Name = "registerViewTipoInput";
            this.registerViewTipoInput.Size = new System.Drawing.Size(100, 20);
            this.registerViewTipoInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "EMAIL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CONTRASEÑA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO DE USUARIO:";
            // 
            // registerViewUserInput
            // 
            this.registerViewUserInput.Location = new System.Drawing.Point(386, 98);
            this.registerViewUserInput.Name = "registerViewUserInput";
            this.registerViewUserInput.Size = new System.Drawing.Size(100, 20);
            this.registerViewUserInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "USERNAME:";
            // 
            // registerViewButton
            // 
            this.registerViewButton.Location = new System.Drawing.Point(326, 300);
            this.registerViewButton.Name = "registerViewButton";
            this.registerViewButton.Size = new System.Drawing.Size(149, 54);
            this.registerViewButton.TabIndex = 0;
            this.registerViewButton.Text = "REGISTRARSE";
            this.registerViewButton.UseVisualStyleBackColor = true;
            this.registerViewButton.Click += new System.EventHandler(this.registerViewButton_Click);
            // 
            // buttonGoRegister
            // 
            this.buttonGoRegister.Location = new System.Drawing.Point(278, 218);
            this.buttonGoRegister.Name = "buttonGoRegister";
            this.buttonGoRegister.Size = new System.Drawing.Size(160, 45);
            this.buttonGoRegister.TabIndex = 1;
            this.buttonGoRegister.Text = "REGISTRARSE";
            this.buttonGoRegister.UseVisualStyleBackColor = true;
            this.buttonGoRegister.Click += new System.EventHandler(this.buttonGoRegister_Click);
            // 
            // buttonGoLogin
            // 
            this.buttonGoLogin.Location = new System.Drawing.Point(278, 167);
            this.buttonGoLogin.Name = "buttonGoLogin";
            this.buttonGoLogin.Size = new System.Drawing.Size(158, 45);
            this.buttonGoLogin.TabIndex = 0;
            this.buttonGoLogin.Text = "INICIAR SESIÓN";
            this.buttonGoLogin.UseVisualStyleBackColor = true;
            this.buttonGoLogin.Click += new System.EventHandler(this.buttonGoLogin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 36);
            this.label11.TabIndex = 24;
            this.label11.Text = "Perfil";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterView);
            this.Controls.Add(this.EntradaView);
            this.Controls.Add(this.LoginView);
            this.Name = "AppForm";
            this.Text = "Form1";
            this.LoginView.ResumeLayout(false);
            this.LoginView.PerformLayout();
            this.profileView.ResumeLayout(false);
            this.profileView.PerformLayout();
            this.panelModificarCuenta.ResumeLayout(false);
            this.panelModificarCuenta.PerformLayout();
            this.panelCambiarContraseña.ResumeLayout(false);
            this.panelCambiarContraseña.PerformLayout();
            this.panelCambiarUsername.ResumeLayout(false);
            this.panelCambiarUsername.PerformLayout();
            this.panelHacersePremium.ResumeLayout(false);
            this.panelHacersePremium.PerformLayout();
            this.EntradaView.ResumeLayout(false);
            this.RegisterView.ResumeLayout(false);
            this.RegisterView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginView;
        private System.Windows.Forms.Button loginViewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginViewPassWordInput;
        private System.Windows.Forms.TextBox loginViewUserInput;
        private System.Windows.Forms.TextBox loginViewInvalidCredentialsAlert;
        private System.Windows.Forms.Panel profileView;
        private System.Windows.Forms.Button profileViewLogOutButton;
        private System.Windows.Forms.TextBox profileViewNameText;
        private System.Windows.Forms.TextBox profileViewAgeText;
        private System.Windows.Forms.TextBox profileViewUserText;
        private System.Windows.Forms.Panel EntradaView;
        private System.Windows.Forms.Button buttonGoRegister;
        private System.Windows.Forms.Button buttonGoLogin;
        private System.Windows.Forms.Panel RegisterView;
        private System.Windows.Forms.TextBox registerViewInvalidCredentialsAlert;
        private System.Windows.Forms.Button registerViewLogOutButton;
        private System.Windows.Forms.TextBox registerViewEmailInput;
        private System.Windows.Forms.TextBox registerViewPassInput;
        private System.Windows.Forms.TextBox registerViewTipoInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerViewUserInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerViewButton;
        private System.Windows.Forms.Button buttonModificarCuenta;
        private System.Windows.Forms.Panel panelModificarCuenta;
        private System.Windows.Forms.Button buttonVolverModificarCuenta;
        private System.Windows.Forms.Panel panelCambiarContraseña;
        private System.Windows.Forms.Button buttonConfirmarCambioContraseña;
        private System.Windows.Forms.TextBox textBoxCambioContraseña;
        private System.Windows.Forms.TextBox textBoxContraseñaCambioContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelCambiarUsername;
        private System.Windows.Forms.Button buttonConfirmarCambioUsername;
        private System.Windows.Forms.TextBox textBoxCambiarUsername;
        private System.Windows.Forms.TextBox textBoxUsuarioCambioUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelHacersePremium;
        private System.Windows.Forms.TextBox textBoxHacersePremium;
        private System.Windows.Forms.Button buttonHacersePremium;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCambiarContraseña;
        private System.Windows.Forms.TextBox textBoxAntiguaContraseñaCambioContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}


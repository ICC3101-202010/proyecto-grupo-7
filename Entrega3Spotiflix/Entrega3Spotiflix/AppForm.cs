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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;

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
            IniciarSerializacion();
            panels.Add("EntradaPanel", panelEntrada);
            panels.Add("LoginPanel", panelLogin);
            panels.Add("RegisterPanel", panelRegister);
            panels.Add("MenuPanel", panelMenu);
            panels.Add("ModificarCuentaPanel", panelModificarCuenta);
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Logeado == true)
                {
                    stackPanels.Add(panels["MenuPanel"]);
                    setNameUser(usuario.Nombre_usuario);
                    ShowLastPanel();
                }
            }
            if (stackPanels.Count() == 0)
            {
                stackPanels.Add(panels["EntradaPanel"]);
                ShowLastPanel();
            }
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
                    foreach (Usuario user in Archivos.Usuarios)
                    {
                        if (user.Nombre_usuario == username)
                        {
                            user.Logeado = true;
                            Serializacion();
                        }
                    }
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
                foreach (Usuario user in Archivos.Usuarios)
                {
                    if (user.Nombre_usuario == username)
                    {
                        user.Logeado = true;
                        Serializacion();
                    }
                }
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
                    Serializacion();
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
            loginViewUserInput.ResetText();
            loginViewPassWordInput.ResetText();
            loginViewInvalidCredentialsAlert.ResetText();
            loginViewInvalidCredentialsAlert.Visible = false;
            stackPanels.Add(panels["LoginPanel"]);
            ShowLastPanel();
        }

        private void buttonGoRegister_Click(object sender, EventArgs e)
        {
            registerViewInvalidCredentialsAlert.ResetText();
            registerViewInvalidCredentialsAlert.Visible = false;
            registerViewUserInput.ResetText();
            registerViewEmailInput.ResetText();
            registerViewPassInput.ResetText();
            registerViewTipoInput.ResetText();
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
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Logeado == true)
                {
                    usuario.Logeado = false;
                }
            }
            Serializacion();
            setNameUser("");
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
                        textBoxHacersePremium.Visible = true;
                        usuario.Tipo_usuario = "Premium";
                        textBoxHacersePremium.Text = "Se ha realizado el cambio con éxito";
                    }
                    Serializacion();
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
            Serializacion();
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
                    Serializacion();
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

        //Serialización

        private void Serializacion()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream7 = new FileStream("películasApp.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream8 = new FileStream("cancionesApp.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream9 = new FileStream("playlists_Canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream10 = new FileStream("playlists_Películas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream11 = new FileStream("Usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream stream12 = new FileStream("PersonasApp.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream7, Archivos.películasApp);
            formatter.Serialize(stream8, Archivos.cancionesApp);
            formatter.Serialize(stream9, Archivos.playlists_Canciones);
            formatter.Serialize(stream10, Archivos.playlists_Películas);
            formatter.Serialize(stream11, Archivos.Usuarios);
            formatter.Serialize(stream12, Archivos.PersonasApp);
            stream7.Close();
            stream8.Close();
            stream9.Close();
            stream10.Close();
            stream11.Close();
            stream12.Close();
        }
        private void IniciarSerializacion()
        {
            Usuario grupo7 = new Usuario("username", "email", "contraseña", "Premium");
            Archivos.Usuarios.Add(grupo7);
            foreach (Usuario i in Archivos.Usuarios)
            {
                List<string> data = new List<string>()
                        { i.Nombre_usuario, i.Email, i.Contraseña, Convert.ToString(DateTime.Now), i.Tipo_usuario};
                Archivos.Lista_usuarios.Add(Archivos.Lista_usuarios.Count + 1, data);
            }

            IFormatter formatter = new BinaryFormatter();

            string urlpelículasApp = Directory.GetCurrentDirectory() + "\\películasApp.bin";
            string urlcancionesApp = Directory.GetCurrentDirectory() + "\\cancionesApp.bin";
            string urlplaylists_Canciones = Directory.GetCurrentDirectory() + "\\playlists_Canciones.bin";
            string urlplaylists_Películas = Directory.GetCurrentDirectory() + "\\playlists_Películas.bin";
            string urlUsuarios = Directory.GetCurrentDirectory() + "\\Usuarios.bin";
            string urlPersonasApp = Directory.GetCurrentDirectory() + "\\PersonasApp.bin";

            if (File.Exists(urlpelículasApp) && File.Exists(urlcancionesApp) && File.Exists(urlplaylists_Canciones) && File.Exists(urlplaylists_Películas) && File.Exists(urlUsuarios) && File.Exists(urlPersonasApp))
            {
                Stream stream1 = new FileStream("películasApp.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream2 = new FileStream("cancionesApp.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream3 = new FileStream("playlists_Canciones.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream4 = new FileStream("playlists_Películas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream5 = new FileStream("Usuarios.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Stream stream6 = new FileStream("PersonasApp.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                //try que Desterializa; catch mostrar mensaje; finally cierra archivo
                try
                {
                    List<Película> des = (List<Película>)formatter.Deserialize(stream1);
                    if (des.Count != 0)
                    {
                        Archivos.películasApp = des;
                    }
                }
                catch
                {
                }
                try
                {
                    List<Canción> des2 = (List<Canción>)formatter.Deserialize(stream2);
                    if (des2.Count != 0)
                    {
                        Archivos.cancionesApp.Clear();
                        Archivos.cancionesApp = des2;
                    }
                }
                catch
                {
                }
                try
                {
                    Archivos.playlists_Canciones = (List<Playlist>)formatter.Deserialize(stream3);
                }
                catch
                {
                }
                try
                {
                    Archivos.playlists_Películas = (List<Playlist>)formatter.Deserialize(stream4);
                }
                catch
                {
                }
                try
                {
                    Archivos.Usuarios = (List<Usuario>)formatter.Deserialize(stream5);
                    foreach (Usuario i in Archivos.Usuarios)
                    {
                        List<string> data = new List<string>()
                        { i.Nombre_usuario, i.Email, i.Contraseña, Convert.ToString(DateTime.Now), i.Tipo_usuario};
                        Archivos.Lista_usuarios.Add(Archivos.Lista_usuarios.Count + 1, data);
                    }
                }
                catch
                {
                }
                try
                {
                    Archivos.PersonasApp = (List<Person>)formatter.Deserialize(stream6);
                }
                catch
                {
                }
                finally
                {
                    stream1.Close();
                    stream2.Close();
                    stream3.Close();
                    stream4.Close();
                    stream5.Close();
                    stream6.Close();
                }
            }
        }
    }
}

﻿using System;
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
using System.Windows.Forms.VisualStyles;

namespace Entrega3Spotiflix
{
    public partial class AppForm : Form
    {
        //Organizacion
        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        string ruta;
        List<Canción> colaCanciones = new List<Canción>();
        List<Película> colaPelículas = new List<Película>();
        

        //Eventos
        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterClicked;
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;
        public delegate bool AgregarCancionEventHandler(object source, AgregarCancionEventArgs args);
        public event AgregarCancionEventHandler AgregarCancionClicked;
        public event EventHandler<AgregarCancionEventArgs> CancionChecked;
        public delegate bool AgregarPlaylistEventHandler(object source, AgregarPlaylistEventArgs args);
        public event AgregarPlaylistEventHandler AgregarPlaylistClicked;
        public event EventHandler<AgregarPlaylistEventArgs> PlaylistChecked;
        public delegate bool AgregarVideoEventHandler(object source, AgregarVideoEventArgs args);
        public event AgregarVideoEventHandler AgregarVideoClicked;
        public event EventHandler<AgregarVideoEventArgs> VideoChecked;

        public AppForm()
        {
            InitializeComponent();
            string carpeta = Directory.GetCurrentDirectory();
            string resolución = "256kbps";
            int reproducciones = 0;
            int Avg_calificacion = 0; //CANCION Y PELICULA
            List<int> Calificación = new List<int>(); //CANCION Y PELICULA
            //Una Cerveza-Ráfaga
            int duración1 = 240;
            Artista Ráfaga = new Artista("Ráfaga", "Ráfaga", "Masculino", 25, "Argentina");
            Album Una_cerveza = new Album("Foto_UnaCerveza.jpg", "Una cerveza", Ráfaga, 2016);
            List<string> genero_una_cerveza = new List<string>();
            string espacio = "3,78MB";
            genero_una_cerveza.Add("Cumbia");
            string url_una_cerveza = carpeta +  @"\Songs\una cerveza.mp3";
            Canción Una_Cerveza = new Canción("Una cerveza", Ráfaga, Una_cerveza, genero_una_cerveza, 2016, reproducciones, Calificación, Avg_calificacion, duración1, resolución, espacio, url_una_cerveza);
            Archivos.cancionesApp.Add(Una_Cerveza);

            //Callaita-Bad Bunny
            List<int> Calificación1 = new List<int>();
            int duración2 = 251;
            Artista Bad_Bunny = new Artista("Bad Bunny", "Bad Bunny", "Masculino", 26, "Puerto Rico");
            Album callaita = new Album("Foto_callaita.jpg", "Callaita", Bad_Bunny, 2019);
            List<string> genero_callaita = new List<string>();
            string espacio2 = "7,68MB";
            genero_callaita.Add("Reggaeton");
            string url_callaita = carpeta + @"\Songs\callaita.mp3";
            Canción Callaita = new Canción("Callaita", Bad_Bunny, callaita, genero_callaita, 2019, reproducciones, Calificación1, Avg_calificacion, duración2, resolución, espacio2, url_callaita);
            Archivos.cancionesApp.Add(Callaita);

            //Tattoo
            List<int> Calificación2 = new List<int>();
            int duración3 = 202;
            Artista Rauw_Alejandro = new Artista("Rauw Alejandro", "Rauw Alejandro", "Masculino", 22, "Puerto Rico");
            Album TattoA = new Album("FotoTattoo.jpg", "Tatto", Rauw_Alejandro, 2019);
            List<string> genero_Tatto = new List<string>();
            string espacio3 = "6,32MB";
            genero_Tatto.Add("Reggaeton");
            string url_Tatto = carpeta + @"\Songs\tatto.mp3";
            Canción Tatto = new Canción("Tattoo", Rauw_Alejandro, TattoA, genero_Tatto, 2019, reproducciones, Calificación2, Avg_calificacion, duración3, resolución, espacio3, url_Tatto);
            Archivos.cancionesApp.Add(Tatto);

            //Piñata
            List<int> Calificación3 = new List<int>();
            int duración4 = 144;
            Artista ElCuis = new Artista("ElCuis", "El Cuis", "Masculino", 26, "Argentino");
            Album piñata = new Album("piñata.jpg", "Piñata", ElCuis, 2019);
            List<string> genero_piñata = new List<string>();
            string espacio4 = "4,36MB";
            genero_piñata.Add("Cumbia");
            string url_piñata = carpeta + @"\Songs\piñata.mp3";
            Canción Piñata = new Canción("Piñata", ElCuis, piñata, genero_piñata, 2019, reproducciones, Calificación3, Avg_calificacion, duración4, resolución, espacio4, url_piñata);
            Archivos.cancionesApp.Add(Piñata);

            //Watermelon sugar
            List<int> Calificación4 = new List<int>();
            int duración5 = 174;
            Artista Harry_Styles = new Artista("Harry", "Harry Styles", "Masculino", 26, "Estados Unidos");
            Album FineLine = new Album("Watermelon.jpeg", "Fine Line", Harry_Styles, 2020);
            List<string> genero_WS = new List<string>();
            string espacio5 = "7,68MB";
            genero_WS.Add("Pop");
            string url_WS = carpeta + @"\Songs\watermelon sugar.mp3";
            Canción WatermelonSugar = new Canción("Watermelon Sugar", Harry_Styles, FineLine, genero_WS, 2020, reproducciones, Calificación4, Avg_calificacion, duración5, resolución, espacio5, url_WS);
            Archivos.cancionesApp.Add(WatermelonSugar);

            //I want it that way
            List<int> Calificación5 = new List<int>();
            int duración6 = 211;
            Artista BSB = new Artista("BSB", "Back street boys", "Masculino", 50, "Estados Unidos");
            Album Millenium = new Album("bsb.jfif", "BSB", BSB, 1999);
            List<string> genero_BSB = new List<string>();
            string espacio6 = "1,67MB";
            genero_BSB.Add("Pop");
            string url_BSB = carpeta + @"\Songs\bsb.mp3";
            Canción IWantThatWay = new Canción("I Want That Way", BSB, Millenium, genero_BSB, 1999, reproducciones, Calificación5, Avg_calificacion, duración6, resolución, espacio6, url_BSB);
            Archivos.cancionesApp.Add(IWantThatWay);

            //Llora remix
            List<int> Calificación6 = new List<int>();
            int duración7 = 312;
            Artista Cauty = new Artista("Cauty", "Cauty", "Masculino", 26, "Chile");
            Album lloras = new Album("lloras.jpg", "Lloras", Cauty, 2020);
            List<string> genero_lloras = new List<string>();
            string espacio7 = "4,46MB";
            genero_callaita.Add("Reggaeton");
            string url_lloras = carpeta + @"\Songs\lloras remix.mp3";
            Canción Lloras = new Canción("Lloras Remix", Cauty, lloras, genero_lloras, 2020, reproducciones, Calificación6, Avg_calificacion, duración7, resolución, espacio7, url_lloras);
            Archivos.cancionesApp.Add(Lloras);

            //Blinding lights
            List<int> Calificación7 = new List<int>();
            int duración8 = 251;
            Artista The_Weeknd = new Artista("The Weeknd", "The Weeknd", "Masculino", 31, "Estados Unidos");
            Album AfterHours = new Album("blinding.jpg", "After Hours", The_Weeknd, 2020);
            List<string> genero_blin = new List<string>();
            string espacio8 = "3,10MB";
            genero_blin.Add("Pop");
            string url_blind = carpeta + @"\Songs\blinding lights.mp3";
            Canción Blin = new Canción("Blinding Lights", The_Weeknd, AfterHours, genero_blin,2020, reproducciones, Calificación7, Avg_calificacion, duración8, resolución, espacio8, url_blind);
            Archivos.cancionesApp.Add(Blin);

            //Bohemian Rapsody
            List<int> Calificación8 = new List<int>();
            int duración9 = 360;
            Artista Queen = new Artista("Queen", "Queen", "Masculino", 26, "Puerto Rico");
            Album Bohemian = new Album("bohemian.jfif", "Bohemian Rhapsody", Queen, 1979);
            List<string> genero_BR = new List<string>();
            string espacio9 = "3,91MB";
            genero_BR.Add("Rock");
            string url_BR = carpeta + @"\Songs\bohemian.mp3";
            Canción BR = new Canción("Bohemian Rapsody", Queen, Bohemian, genero_BR, 2009, reproducciones, Calificación, Avg_calificacion, duración9, resolución, espacio9, url_BR);
            Archivos.cancionesApp.Add(BR);

            //Home
            List<int> Calificación9 = new List<int>();
            int duración10 = 251;
            Artista Blake_Shelton = new Artista("Blake Shelton", "Blake Shelton", "Masculino", 43, "Estados Unidos");
            Album home = new Album("home.jfif", "Home", Blake_Shelton, 2019);
            List<string> genero_home = new List<string>();
            string espacio10 = "2,57MB";
            genero_home.Add("Pop");
            string url_home = carpeta + @"\Songs\Home.mp3";
            Canción Home = new Canción("Home", Blake_Shelton, home, genero_home, 2019, reproducciones, Calificación9, Avg_calificacion, duración10, resolución, espacio10, url_home);
            Archivos.cancionesApp.Add(Home);


            //Trailer rapidos y furiosos 9
            string titulo = "Trailer RyF9";
            List<string> categoria = new List<string>();
            string categori = "Accion";
            categoria.Add(categori);
            Person p1 = new Person("Justin", "Lin", "Masculino", 46, "China");
            string descripcion = "Buen trailer con mucha ficción";
            int duracion = 246;
            int año = 2020;
            int clas = 18;
            int calificacion = 0;
            List<int> calificaciones = new List<int>() { };
            string imagen = carpeta + @"\ryf9.jpeg";
            string url = carpeta + @"\Movies\Fast.mp4";
            int rep = 0;
            Película trailerryf = new Película(titulo, categoria, p1, descripcion, duracion, año, clas, calificaciones, calificacion, imagen, url, rep);
            Archivos.películasApp.Add(trailerryf);

            //Trailer dark
            string titulo1 = "Trailer dark";
            List<string> categoria1 = new List<string>();
            string categori1 = "Drama";
            categoria1.Add(categori1);
            Person p2 = new Person("Nikoclaus", "Summerer", "Masculino", 49, "Alemania");
            string descripcion1 = "Trailer de dark, temporada 4";
            int duracion1 = 89;
            int año1 = 2017;
            int clas1 = 0;
            int calificacion1 = 0;
            List<int> calificaciones1 = new List<int>() { };
            string imagen1 = carpeta +  @"\dark.jpg";
            string url1 = carpeta + @"\Movies\Dark.mp4";
            int rep1 = 0;
            Película trailerDark = new Película(titulo1, categoria1, p2, descripcion1, duracion1, año1, clas1, calificaciones1, calificacion1, imagen1, url1, rep1);
            Archivos.películasApp.Add(trailerDark);

            //Trailer Inception
            string titulo2 = "Trailer Inception";
            List<string> categoria2 = new List<string>();
            string categori2 = "Suspenso";
            categoria2.Add(categori2);
            Person p3 = new Person("Chistopher", "Nolan", "Masculino", 49, "Reino Unido");
            string descripcion2 = "Trailer inception, pelicula protagonizada por Leonador DiCaprio";
            int duracion2 = 147;
            int año2 = 2010;
            int clas2 = 0;
            int calificacion2 = 0;
            List<int> calificaciones2 = new List<int>() { };
            string imagen2 = carpeta + @"\origen.jpg";
            string url2 = carpeta + @"\Movies\TrailerInception.mp4";
            int rep2 = 0;
            Película trailerInception = new Película(titulo2, categoria2, p3, descripcion2, duracion2, año2, clas2, calificaciones2, calificacion2, imagen2, url2, rep2);
            Archivos.películasApp.Add(trailerInception);

            //Trailer Casa de papel
            string titulo3 = "Trailer Casa de papel";
            List<string> categoria3 = new List<string>();
            string categori3 = "Drama";
            categoria3.Add(categori3);
            Person p4 = new Person("Alex", "Pina", "Masculino", 52, "España");
            string descripcion3 = "Trailer Temporada 4 de la casa de papel, la serie que todos esperan ver";
            int duracion3 = 129;
            int año3 = 2020;
            int clas3 = 0;
            int calificacion3 = 0;
            List<int> calificaciones3 = new List<int>() { };
            string imagen3 = carpeta + @"\casa.jpg";
            string url3 = carpeta + @"\Movies\CasaDePapel.mp4";
            int rep3 = 0;
            Película trailerCdp = new Película(titulo3, categoria3, p4, descripcion3, duracion3, año3, clas3, calificaciones3, calificacion3, imagen3, url3, rep3);
            Archivos.películasApp.Add(trailerCdp);

            //Alexis Sanchez lo mejor
            string titulo4 = "Alexis Sanchez, lo mejor";
            List<string> categoria4 = new List<string>();
            string categori4 = "Deporte";
            categoria4.Add(categori4);
            Person p5 = new Person("Youtube", "Desconocido", "Indefnido", 0, "Youtube");
            string descripcion4 = "Las mejores jugadas de Alexis Sanchez";
            int duracion4 = 611;
            int año4 = 2017;
            int clas4 = 0;
            int calificacion4 = 0;
            List<int> calificaciones4 = new List<int>() { };
            string imagen4 = carpeta + @"\alexis.jpg";
            string url4 = carpeta + @"\Movies\LoMejorDeAlexis.mp4";
            int rep4 = 0;
            Película alexis = new Película(titulo4, categoria4, p5, descripcion4, duracion4, año4, clas4, calificaciones4, calificacion4, imagen4, url4, rep4);
            Archivos.películasApp.Add(alexis);




            IniciarSerializacion();
            panels.Add("EntradaPanel", panelEntrada);
            panels.Add("LoginPanel", panelLogin);
            panels.Add("RegisterPanel", panelRegister);
            panels.Add("MenuPanel", panelMenu);
            panels.Add("ModificarCuentaPanel", panelModificarCuenta);
            panels.Add("CancionesPanel", panelCancciones);
            panels.Add("PelículasPanel", panelPelículas);
            panels.Add("BúsquedaPanel", panelBúsqueda);
            panels.Add("AgregarCancionpanel", panelAgregarCancion);
            panels.Add("CrearPlaylistPanel", panelCrearPlaylist);
            panels.Add("MisPlaylistPanel", panelMisPlaylist);
            panels.Add("AgregarVideoPanel", panelAgregarVideo);
            panels.Add("EliminarMediaPanel", panelEliminarMedia);
            panels.Add("TopMediaPanel", panelTopMedia);
            panels.Add("HistorialPanel", panelHistorial);
            panels.Add("UsuariosPanel", panelUsuarios);
            panels.Add("SiguiendoPanel", panelSiguiendo);
            panels.Add("TodasMisPlaylistsPanel", panelTodasMisPlaylists);
            panels.Add("SolicitudesPanel", panelSolicitudes);

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
                foreach (Usuario usuario in Archivos.Usuarios)
                {
                    if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                    {
                        if (usuario.Solicitudes.Count() != 0)
                        {
                            MessageBox.Show("Usted tiene " + usuario.Solicitudes.Count() + " solicitud(es) pendiente(s)");
                        }
                    }
                }
            }
            p = 0;
            d = 0;
            u = 0;
            c = 0;
            i = 0;
            b = 0;
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
                foreach (Usuario usuario in Archivos.Usuarios)
                {
                    if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                    {
                        if (usuario.Solicitudes.Count() != 0)
                        {
                            MessageBox.Show("Usted tiene " + usuario.Solicitudes.Count() + " solicitud(es) pendiente(s)");
                        }
                    }
                }
            }
        }
        private void OnRegisterClicked(string username, string email, string pass, string tipo_usuario, string privacidad)
        {
            if ((tipo_usuario == "") || (username == "") || pass == "" || email == "" || privacidad == "")
            {
                registerViewInvalidCredentialsAlert.Text = "Agregue los valores que faltan";
                registerViewInvalidCredentialsAlert.Visible = true;
            }
            else
            {
                bool result = RegisterClicked(this, new RegisterEventArgs() { Username = username, Password = pass, Email = email, Tipo_usuario = tipo_usuario, Privacidad = privacidad });
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
        private void OnAgregarCancionClicked(string nombre, string artista, string album, string genero, string AñoPublicacion, string reproducciones, string calificacion, string avg_calificacion, string duracion, string resolucion, string espacio, string ruta, string imagen)
        {
            if (nombre == "" || artista == "" || album == "" || duracion == "" || espacio == "" || Convert.ToString(resolucion) == "" || ruta == "" || genero == "")
            {
                labelFaltanDatosCancion.Text = "No han ingresado todos los datos";
                labelFaltanDatosCancion.Visible = true;
            }
            else
            {
                bool result = AgregarCancionClicked(this, new AgregarCancionEventArgs() { Nombre = nombre, Artista = artista, Album = album, genero = genero, añoPublicacion = AñoPublicacion, Reproducciones = Convert.ToInt32(reproducciones), Calificacion=Convert.ToInt32(calificacion), avg_calificacion = Convert.ToInt32(avg_calificacion), Duracion = duracion, Resolucion = resolucion, Espacio = espacio, URL = ruta , imagen = imagen});
                if (!result)
                {
                    labelFaltanDatosCancion.Text = "Esta cancion ya existe";
                    labelFaltanDatosCancion.Visible = true;
                }
                else
                {
                    labelFaltanDatosCancion.ResetText();
                    labelFaltanDatosCancion.Visible = false;
                    Serializacion();
                    OnCancionChecked(nombre);
                }
            }
        }
        private void OnCancionChecked(string nombre)
        {
            if (CancionChecked != null)
            {
                CancionChecked(this, new AgregarCancionEventArgs() { Nombre = nombre });
                textBoxNombreCancion.ResetText();
                textBoxArtistaCancion.ResetText();
                textBoxAlbumCancion.ResetText();
                textBoxDuracionCancion.ResetText();
                textBoxGeneroCancion.ResetText();
                textBoxEspacioCancion.ResetText();
                textBoxResoluciónCancion.ResetText();
                labelFaltanDatosCancion.ResetText();
                ; setNombreCancion(nombre);
                foreach (Canción cancion in Archivos.cancionesApp)
                {
                    if (cancion.Titulo == nombre)
                    {
                        cancion.Agregada = true;
                        Serializacion();
                    }
                }
                stackPanels.Add(panels["MenuPanel"]);
                ShowLastPanel();
            }
        }
        private void OnAgregarVideoClicked(string titulo, string categoria, string director, string descripcion, string duracion, string año, string calificacion, string avg_calificacion, string imagen, string url, string reproducciones)
        {
            if (titulo == "" || categoria == "" || director == "" || duracion == "" || url == "" || descripcion == "")
            {
                labelFaltanDatosPelicula.Text = "No han ingresado todos los datos";
                labelFaltanDatosPelicula.Visible = true;
            }
            else
            {
                bool result = AgregarVideoClicked(this, new AgregarVideoEventArgs() { Titulo = titulo, Categoria=categoria, Director=director,Descripcion=descripcion,Duracion=Convert.ToInt32(duracion), Año = Convert.ToInt32(año), Calificacion = Convert.ToInt32(calificacion), Avg_calificacion = Convert.ToInt32(avg_calificacion), Imagen = imagen, Url=url, Reproducciones = Convert.ToInt32(reproducciones)});
                if (!result)
                {
                    labelFaltanDatosCancion.Text = "Este video ya existe";
                    labelFaltanDatosCancion.Visible = true;
                }
                else
                {
                    labelFaltanDatosPelicula.ResetText();
                    labelFaltanDatosPelicula.Visible = false;
                    Serializacion();
                    OnVideoChecked(titulo);
                }
            }
        }
        private void OnVideoChecked(string nombre)
        {
            if (VideoChecked != null)
            {
                VideoChecked(this, new AgregarVideoEventArgs() { Titulo = nombre });
                textBoxTituloPelicula.ResetText();
                textBoxDirectorPelicula.ResetText();
                textBoxDecripcionPelicula.ResetText();
                textBoxAñoPelicula.ResetText();
                textBoxCategoriaPelicula.ResetText();
                textBoxDuracionPelicula.ResetText();
                setNombreVideo(nombre);
                foreach (Película pelicula in Archivos.películasApp)
                {
                    if (pelicula.Titulo == nombre)
                    {
                        pelicula.Agregada = true;
                        Serializacion();
                    }
                }
                stackPanels.Add(panels["MenuPanel"]);
                ShowLastPanel();
            }
        }
        public void setNombreCancion(string nombre)
        {
            textBoxNombreCancion.Text = nombre;
        }
        public void setNombreVideo(string nombre)
        {
            textBoxTituloPelicula.Text = nombre;
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
            comboBoxTipoUsuario.ResetText();
            comboBoxPrivacidadUsuario.ResetText();
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
            string tipo_usuario = comboBoxTipoUsuario.SelectedItem.ToString();
            string privacidad = comboBoxPrivacidadUsuario.SelectedItem.ToString();
            OnRegisterClicked(username, email, pass, tipo_usuario, privacidad);
        }

        private void buttonVolverDeRegister_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["EntradaPanel"]);
            ShowLastPanel();
        }

        private void buttonModificarCuenta_Click(object sender, EventArgs e)
        {
            textBoxEditarFechaNacimiento.ResetText();
            textBoxEditarNacionalidad.ResetText();
            panelInformacionPerfil.Visible = false;
            UsernameEditarPerfil.Text = textBoxUsernamePerfil.Text;
            string foto_perfil = "perfilNetflixVerde.png";
            pictureBoxFotoPerfil.Image = Image.FromFile(foto_perfil);
            pictureBoxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
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
            panelInformacionPerfil.Visible = false;
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
            panelInformacionPerfil.Visible = false;
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
            panelInformacionPerfil.Visible = false;
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
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario1.Tipo_usuario == "Premium")
                    {
                        textBoxHacersePremium.Visible = true;
                        textBoxHacersePremium.Text = "Este Usuario ya es premium";
                    }
                    else if (usuario1.Nombre_usuario == "admin")
                    {
                        textBoxHacersePremium.Visible = true;
                        textBoxHacersePremium.Text = "El admistrador cuenta con todas las funciones Premium";
                    }
                    else
                    {
                        textBoxHacersePremium.Visible = true;
                        usuario1.Tipo_usuario = "Premium";
                        textBoxHacersePremium.Text = "Se ha realizado el cambio con éxito";
                        Serializacion();
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
                    UsernameEditarPerfil.Text = usuario.Nombre_usuario;
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
            foreach (Usuario i in Archivos.Usuarios)
            {
                List<string> data = new List<string>()
                        { i.Nombre_usuario, i.Email, i.Contraseña, Convert.ToString(DateTime.Now), i.Tipo_usuario, i.Privacidad};
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

        private void panelCancciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGoVerCanciones_Click(object sender, EventArgs e)
        {
            buttonAgregarAMisPlaylists.Visible = false;
            labelReproduciendo.Visible = false;
            labelCanciónReproducida.Visible = false;
            buttonNext1.Visible = false;
            buttonNext2.Visible = false;
            buttonAgregarColaCanción.Visible = false;
            FotoCanciónMostrada.Visible = false;
            buttonAgregarCancionAPlaylist.Visible = false;
            buttonReproducir.Visible = false;
            buttonEvaluar.Visible = false;
            comboBoxCalificación.Visible = false;
            buttonConfirmarCalificación.Visible = false;
            CanciónSeleccionada.Visible = false;
            panel1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            stackPanels.Add(panels["CancionesPanel"]);
            ShowLastPanel();
            listViewCanciones.Clear();
            VerCanciones(Archivos.cancionesApp);

        }
        private void VerCanciones(List<Canción> canciones)
        {
            ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
            foreach (Canción canción in canciones)
            {
                listViewCanciones.Items.Add(new ListViewItem(canción.Titulo, Canciones));

            }
            listViewCanciones.Groups.Add(Canciones);
        }
        private void VerPelículas(List<Película> películas)
        {
            ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
            foreach (Película película in películas)
            {
                listViewPelículas.Items.Add(new ListViewItem(película.Titulo, Películas));

            }
            listViewPelículas.Groups.Add(Películas);
        }

        private void listViewCanciones_MouseClick(object sender, MouseEventArgs e)
        {
            buttonAgregarAMisPlaylists.Visible = true;
            buttonAgregarColaCanción.Visible = true;
            axWindowsMediaPlayer2.Visible = false;
            panel1.Visible = true;
            FotoCanciónMostrada.Visible = true;
            buttonAgregarCancionAPlaylist.Visible = true;
            buttonReproducir.Visible = true;
            buttonEvaluar.Visible = true;
            CanciónSeleccionada.Visible = true;
            CanciónSeleccionada.Text = listViewCanciones.SelectedItems[0].SubItems[0].Text;
            foreach (Canción canción in Archivos.cancionesApp)
            {
                if (canción.titulo == CanciónSeleccionada.Text)
                {
                    try
                    {
                        FotoCanciónMostrada.Image = Image.FromFile(canción.album.Imagen);
                        FotoCanciónMostrada.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        string sin_foto = "logo.jpeg";
                        FotoCanciónMostrada.Image = Image.FromFile(sin_foto);
                        FotoCanciónMostrada.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    AlbumCanciónSeleccionada.Text = canción.album.Nombre;
                    ArtistaCanciónSeleccionada.Text = canción.artista.Apellido;
                    DuraciónCanciónSeleccionada.Text = canción.duración.ToString();
                    ReproduccionesCanciónSeleccionada.Text = canción.reproducciones.ToString();
                    CalificaciónCanciónSeleccionada.Text = canción.Avg_calificacion.ToString();

                }
            }
        }

        private void CanciónSeleccionada_Click(object sender, EventArgs e)
        {

        }

        private void FotoCanciónMostrada_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverDeVerCanción_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void buttonVolverDeVerPelícula_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void listViewPelículas_MouseClick(object sender, MouseEventArgs e)
        {
            buttonAgregarPelículaAMisPlaylist.Visible = true;
            comboBoxPlaylistParaAgregarPelícula.Visible = false;
            buttonConfirmarAgregarPelículaAPlaylist.Visible = false;
            buttonAgregarColaPelícula.Visible = true;
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Visible = false;
            FotoPelícula.Visible = true;
            buttonAgregarPelículaAPlaylist.Visible = true;
            buttonReproducirPelícula.Visible = true;
            buttonEvaluarPelícula.Visible = true;
            PelículaSeleccionada.Visible = true;
            PelículaSeleccionada.Text = listViewPelículas.SelectedItems[0].SubItems[0].Text;
            foreach (Película película in Archivos.películasApp)
            {
                if (película.titulo == PelículaSeleccionada.Text)
                {
                    try
                    {
                        FotoPelícula.Image = Image.FromFile(película.Imagen);
                        FotoPelícula.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        string sin_foto = "logo.jpeg";
                        FotoPelícula.Image = Image.FromFile(sin_foto);
                        FotoPelícula.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    panel2.Visible = true;
                    AñoPelículaSeleccionada.Text = película.añoPublicacion.ToString();
                    DuraciónPelículaSeleccionada.Text = película.duracion.ToString();
                    CalificaciónPelículaSeleccionada.Text = película.Avg_calificación.ToString();
                    NumeroReproduccionesPelículaSeleccionada.Text = película.reproducciones.ToString();
                }
            }
        }

        private void buttonGoVerPelículas_Click(object sender, EventArgs e)
        {
            buttonAgregarPelículaAMisPlaylist.Visible = false;
            comboBoxPlaylistParaAgregarPelícula.Visible = false;
            buttonConfirmarAgregarPelículaAPlaylist.Visible = false;
            buttonAgregarColaPelícula.Visible = false;
            buttonNext1Películas.Visible = false;
            buttonNext2Películas.Visible = false;
            panel2.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            FotoPelícula.Visible = false;
            comboBoxCalificaciónPelícula.Visible = false;
            buttonConfirmarCalificaciónPelícula.Visible = false;
            buttonAgregarPelículaAPlaylist.Visible = false;
            buttonReproducirPelícula.Visible = false;
            buttonEvaluarPelícula.Visible = false;
            PelículaSeleccionada.Visible = false;
            stackPanels.Add(panels["PelículasPanel"]);
            ShowLastPanel();
            listViewPelículas.Clear();
            VerPelículas(Archivos.películasApp);
        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            labelReproduciendo.Visible = true;
            labelCanciónReproducida.Visible = true;
            buttonNext1.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            foreach (Canción canción in Archivos.cancionesApp)
            {
                if (canción.titulo == CanciónSeleccionada.Text)
                {
                    EncontrarArchivo(canción.titulo);
                    axWindowsMediaPlayer1.URL = this.ruta;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    canción.reproducciones += 1;
                    ReproduccionesCanciónSeleccionada.Text = canción.reproducciones.ToString();
                    labelCanciónReproducida.Text = canción.titulo;
                    foreach (Usuario usuario in Archivos.Usuarios)
                    {
                        if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                        {
                            usuario.Historial.Add(canción.titulo);
                        }
                    }
                }
            }
            Serializacion();
        }
        public void EncontrarArchivo(string valor)
        {
            foreach (Película película in Archivos.películasApp)
            {
                if (valor == película.titulo)
                {
                    this.ruta = película.Url;
                }
            }
            foreach (Canción canción in Archivos.cancionesApp)
            {
                if (valor == canción.titulo)
                {
                    this.ruta = canción.Url;
                }
            }
        }

        private void pictureBoxPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBoxReproducir_Click(object sender, EventArgs e)
        {

        }

        private void buttonReproducirPelícula_Click(object sender, EventArgs e)
        {
            buttonAgregarPelículaAMisPlaylist.Visible = false;
            buttonNext1Películas.Visible = true;
            panel2.Visible = false;
            axWindowsMediaPlayer2.Dock = DockStyle.Fill;
            axWindowsMediaPlayer2.Visible = true;
            buttonVolverDeVerPelícula.Visible = false;
            foreach (Película pelicula in Archivos.películasApp)
            {
                if (pelicula.titulo == PelículaSeleccionada.Text)
                {
                    EncontrarArchivo(pelicula.titulo);
                    axWindowsMediaPlayer2.URL = pelicula.Url;
                    pictureBoxSalirReproducirPelicula.SizeMode = PictureBoxSizeMode.StretchImage;
                    axWindowsMediaPlayer2.Dock = DockStyle.Fill;
                    pictureBoxSalirReproducirPelicula.Visible = true;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    pelicula.reproducciones += 1;
                    NumeroReproduccionesPelículaSeleccionada.Text = pelicula.reproducciones.ToString();
                    foreach (Usuario usuario in Archivos.Usuarios)
                    {
                        if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                        {
                            usuario.Historial.Add(pelicula.titulo);
                        }
                    }
                }
            }
            Serializacion();
        }

        private void buttonGoBuscar_Click(object sender, EventArgs e)
        {
            buttonAgregarOtroFiltro2.Visible = false;
            textBoxFiltroBúsqueda.Visible = false;
            textBoxFiltroBúsqueda2.Visible = false;
            textBoxFiltroBúsqueda3.Visible = false;
            comboBoxFiltro1.ResetText();
            comboBoxFiltro3.ResetText();
            comboBoxFiltro2.ResetText();
            comboBoxCriterio1.ResetText();
            comboBoxFiltro2.Visible = false;
            comboBoxFiltro3.Visible = false;
            comboBoxFiltro1.Visible = false;
            labelFiltroBúsqueda.Visible = false;
            panelBúsquedaDeCriterio.Visible = false;
            string fotoBuscar = "iconoBuscar.jpg";
            pictureBoxBuscar.Image = Image.FromFile(fotoBuscar);
            pictureBoxBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            stackPanels.Add(panels["BúsquedaPanel"]);
            ShowLastPanel();
        }

        private void buttonVolverDeBúsqueda_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void comboBoxCriterio1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selección = comboBoxCriterio1.SelectedItem.ToString();
            listViewBúsqueda.Clear();
            if (selección == "Canciones")
            {
                comboBoxFiltro1.ResetText();
                comboBoxFiltro1.Visible = true;
                labelFiltroBúsqueda.Visible = true;
                comboBoxFiltro1.Items.Clear();
                comboBoxFiltro1.Items.Add("Título");
                comboBoxFiltro1.Items.Add("Género");
                comboBoxFiltro1.Items.Add("Álbum");
                comboBoxFiltro1.Items.Add("Artista");
            }
            if (selección == "Películas")
            {
                comboBoxFiltro1.ResetText();
                comboBoxFiltro1.Visible = true;
                labelFiltroBúsqueda.Visible = true;
                comboBoxFiltro1.Items.Clear();
                comboBoxFiltro1.Items.Add("Título");
                comboBoxFiltro1.Items.Add("Categoría");
                comboBoxFiltro1.Items.Add("Director");
            }
            if (selección == "Playlists")
            {
                comboBoxFiltro1.ResetText();
                comboBoxFiltro1.Items.Clear();
                comboBoxFiltro1.Visible = true;
                labelFiltroBúsqueda.Visible = true;
                comboBoxFiltro1.Items.Add("De Canciones");
                comboBoxFiltro1.Items.Add("De Películas");
            }
        }

        private void comboBoxFiltro1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBúsquedaDeCriterio.Visible = true;
            textBoxFiltroBúsqueda.Visible = true;
            textBoxFiltroBúsqueda2.ResetText();
            textBoxFiltroBúsqueda3.ResetText();
            textBoxFiltroBúsqueda.ResetText();
            if (comboBoxCriterio1.Text != "Playlists")
            {
                buttonAgregarOtroFiltro1.Visible = true;
            }
        }

        private void comboBoxCriterioCanción_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBúsquedaDeCriterio.Visible = true;
            textBoxFiltroBúsqueda.ResetText();
            buttonAgregarOtroFiltro2.Visible = false;
            textBoxFiltroBúsqueda3.Visible = true;
        }
        List<String> resultados = new List<string>();
        private void pictureBoxBuscar_Click(object sender, EventArgs e)
        {
            resultados.Clear();
            listViewBúsqueda.Items.Clear();
            string selección1 = comboBoxCriterio1.Text;
            string filtro1 = comboBoxFiltro1.Text;
            string filtro2 = comboBoxFiltro2.Text;
            string filtro3 = comboBoxFiltro3.Text;
            labelFiltroBúsqueda.Visible = true;
            string valor1 = textBoxFiltroBúsqueda.Text;
            string valor2 = textBoxFiltroBúsqueda2.Text;
            string valor3 = textBoxFiltroBúsqueda3.Text;
            if (textBoxFiltroBúsqueda.Visible == true && textBoxFiltroBúsqueda2.Visible == false && textBoxFiltroBúsqueda3.Visible == false)
            {
                if (valor1 == "")
                {
                    MessageBox.Show("Ingrese un valor para su búsqueda");
                }
                else
                {
                    Buscar1Criterio(selección1, filtro1, valor1);
                }
            }
            if (textBoxFiltroBúsqueda2.Visible == true && textBoxFiltroBúsqueda3.Visible == false)
            {
                if (valor2 == "" || valor1 == "")
                {
                    MessageBox.Show("Ingrese un valor para su búsqueda");
                }
                else
                {
                    Buscar2Criterio(selección1, filtro1, filtro2, valor1, valor2);
                }
            }
            if (textBoxFiltroBúsqueda3.Visible == true)
            {
                if (valor2 == "" || valor3 == "" || valor1 == "")
                {
                    MessageBox.Show("Ingrese un valor para su búsqueda");
                }
                else
                {
                    Buscar3Criterio(selección1, filtro1, filtro2, filtro3, valor1, valor2, valor3);
                }
            }
            if (resultados.Count() == 0)
            {
                MessageBox.Show("No se han encontrado resultados");
            }
        }

        private void Buscar1Criterio(string criterio1, string filtro1, string valor)
        {
            if (criterio1 == "Canciones")
            {
                if (filtro1 == "Título")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.titulo.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.artista.Apellido.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
            }
            if (criterio1 == "Películas")
            {
                if (filtro1 == "Título")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        if (película.titulo.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                            resultados.Add(película.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro1 == "Género")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro1 == "Director")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        if (película.director.Apellido.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                            resultados.Add(película.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
            }
            if (criterio1 == "Playlists")
            {
                if (filtro1 == "De Canciones")
                {
                    ListViewGroup Playlist = new ListViewGroup("Playlist", HorizontalAlignment.Left);
                    foreach (Playlist playlist in Archivos.playlists_Canciones)
                    {
                        if (playlist.Tipo_playlist == "De Canciones")
                        {
                            if (playlist.Nombre.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(playlist.Nombre, Playlist));
                                resultados.Add(playlist.Nombre);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Playlist);
                }
                if (filtro1 == "De Películas")
                {
                    ListViewGroup Playlist = new ListViewGroup("Playlist", HorizontalAlignment.Left);
                    foreach (Playlist playlist in Archivos.playlists_Películas)
                    {
                        if (playlist.Tipo_playlist == "De Películas")
                        {
                            if (playlist.Nombre.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(playlist.Nombre, Playlist));
                                resultados.Add(playlist.Nombre);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Playlist);
                }
            }
        }

        private void Buscar3Criterio(string criterio1, string filtro1, string filtro2, string filtro3, string valor, string valor2, string valor3)
        {
            if (criterio1 == "Canciones")
            {
                if (filtro1 == "Título" && filtro2 == "Género" && filtro3 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.titulo.Contains(valor) && canción.album.Nombre.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Género" && filtro3 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.titulo.Contains(valor) && canción.artista.Apellido.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Álbum" && filtro3 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor2) && canción.titulo.Contains(valor) && canción.artista.Apellido.Contains(valor3))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Álbum" && filtro3 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor3) && canción.titulo.Contains(valor) && canción.album.Nombre.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Artista" && filtro3 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.artista.Apellido.Contains(valor2) && canción.titulo.Contains(valor) && canción.album.Nombre.Contains(valor3))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Artista" && filtro3 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor3) && canción.titulo.Contains(valor) && canción.artista.Apellido.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Género" && filtro3 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.titulo.Contains(valor2) && canción.album.Nombre.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Género" && filtro3 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.titulo.Contains(valor2) && canción.artista.Apellido.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Álbum" && filtro1 == "Género" && filtro3 == "Título")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.album.Nombre.Contains(valor2) && canción.titulo.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Álbum" && filtro1 == "Género" && filtro3 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.album.Nombre.Contains(valor2) && canción.artista.Apellido.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Artista" && filtro1 == "Género" && filtro3 == "Título")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.artista.Apellido.Contains(valor2) && canción.titulo.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Artista" && filtro1 == "Género" && filtro3 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.artista.Apellido.Contains(valor2) && canción.album.Nombre.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Álbum" && filtro3 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor) && canción.titulo.Contains(valor2) && canción.artista.Nombre.Contains(valor3))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Álbum" && filtro3 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor3) && canción.album.Nombre.Contains(valor) && canción.titulo.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Artista" && filtro1 == "Álbum" && filtro3 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor3) && canción.album.Nombre.Contains(valor) && canción.artista.Apellido.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Álbum" && filtro2 == "Género" && filtro3 == "Título")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.album.Nombre.Contains(valor) && canción.titulo.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Artista" && filtro3 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.artista.Apellido.Contains(valor) && canción.titulo.Contains(valor2) && canción.album.Nombre.Contains(valor3))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Artista" && filtro3 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor3) && canción.artista.Apellido.Contains(valor) && canción.titulo.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista" && filtro2 == "Álbum" && filtro3 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor3) && canción.artista.Apellido.Contains(valor) && canción.album.Nombre.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista" && filtro2 == "Álbum" && filtro3 == "Título")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.titulo.Contains(valor3) && canción.artista.Apellido.Contains(valor) && canción.album.Nombre.Contains(valor2))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista" && filtro2 == "Género" && filtro3 == "Título")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.artista.Apellido.Contains(valor) && canción.titulo.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista" && filtro2 == "Género" && filtro3 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.artista.Apellido.Contains(valor) && canción.album.Nombre.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
            }
            if (criterio1 == "Películas")
            {
                if (filtro1 == "Título" && filtro2 == "Director" && filtro3 == "Categoría")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor3) && película.titulo.Contains(valor) && película.director.Apellido.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro1 == "Título" && filtro2 == "Categoría" && filtro3 == "Director")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor2) && película.titulo.Contains(valor) && película.director.Apellido.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro2 == "Título" && filtro1 == "Categoría" && filtro3 == "Director")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor) && película.titulo.Contains(valor2) && película.director.Apellido.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro2 == "Director" && filtro1 == "Categoría" && filtro3 == "Título")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor) && película.director.Apellido.Contains(valor2) && película.titulo.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro1 == "Director" && filtro2 == "Categoría" && filtro3 == "Título")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor2) && película.director.Apellido.Contains(valor) && película.titulo.Contains(valor3))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro2 == "Título" && filtro1 == "Director" && filtro3 == "Categoría")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor3) && película.director.Apellido.Contains(valor) && película.titulo.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
            }
        }

        private void Buscar2Criterio(string criterio1, string filtro1, string filtro2, string valor, string valor2)
        {
            if (criterio1 == "Canciones")
            {
                if (filtro1 == "Título" && filtro2 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.titulo.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor2) && canción.titulo.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Título" && filtro2 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.artista.Apellido.Contains(valor2) && canción.titulo.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.titulo.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Álbum" && filtro1 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.album.Nombre.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Artista" && filtro1 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor) && canción.artista.Apellido.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor) && canción.titulo.Contains(valor2))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Artista" && filtro1 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor) && canción.artista.Apellido.Contains(valor2))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Álbum" && filtro2 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.album.Nombre.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro2 == "Título" && filtro1 == "Artista")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.artista.Apellido.Contains(valor) && canción.titulo.Contains(valor2))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista" && filtro2 == "Álbum")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        if (canción.album.Nombre.Contains(valor2) && canción.artista.Apellido.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                            resultados.Add(canción.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
                if (filtro1 == "Artista" && filtro2 == "Género")
                {
                    ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        foreach (String género in canción.genero)
                        {
                            if (género.Contains(valor2) && canción.artista.Apellido.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(canción.Titulo, Canciones));
                                resultados.Add(canción.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Canciones);
                }
            }
            if (criterio1 == "Películas")
            {
                if (filtro1 == "Título" && filtro2 == "Director")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        if (película.titulo.Contains(valor) && película.director.Apellido.Contains(valor2))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                            resultados.Add(película.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro1 == "Título" && filtro2 == "Categoría")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor2) && película.titulo.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro2 == "Título" && filtro1 == "Categoría")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor) && película.titulo.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro2 == "Director" && filtro1 == "Categoría")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor) && película.director.Apellido.Contains(valor2))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro1 == "Director" && filtro2 == "Categoría")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        foreach (String categoría in película.categoria)
                        {
                            if (categoría.Contains(valor2) && película.director.Apellido.Contains(valor))
                            {
                                listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                                resultados.Add(película.Titulo);
                            }
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
                if (filtro2 == "Título" && filtro1 == "Director")
                {
                    ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
                    foreach (Película película in Archivos.películasApp)
                    {
                        if (película.titulo.Contains(valor2) && película.director.Apellido.Contains(valor))
                        {
                            listViewBúsqueda.Items.Add(new ListViewItem(película.Titulo, Películas));
                            resultados.Add(película.Titulo);
                        }
                    }
                    listViewBúsqueda.Groups.Add(Películas);
                }
            }
        }

        private void comboBoxCriterioPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBúsquedaDeCriterio.Visible = true;
            textBoxFiltroBúsqueda.ResetText();
            textBoxFiltroBúsqueda2.Visible = true;
            if (comboBoxCriterio1.Text != "Playlists")
            {
                buttonAgregarOtroFiltro2.Visible = true;
            }
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonConfirmarCalificación_Click(object sender, EventArgs e)
        {
            if (comboBoxCalificación.SelectedItem == null)
            {
                MessageBox.Show("No se ha ingresado ningún valor");
            }
            else
            {
                string nota1 = comboBoxCalificación.SelectedItem.ToString();
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (canción.titulo == CanciónSeleccionada.Text)
                    {
                        int nota2 = Convert.ToInt32(nota1);
                        canción.calificación.Add(nota2);
                        string Canción = "Canción";
                        Rankear(canción.titulo, canción.calificación, Canción);
                        MessageBox.Show("Se ha calificado la canción");
                        CalificaciónCanciónSeleccionada.Text = canción.Avg_calificacion.ToString();
                        Serializacion();
                    }
                }
            }
            comboBoxCalificación.Visible = false;
            buttonConfirmarCalificación.Visible = false;
        }

        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            comboBoxCalificación.ResetText();
            comboBoxCalificación.Visible = true;
            buttonConfirmarCalificación.Visible = true;
        }
        public void Rankear(string nombre, List<int> calificaciones, string tipo)
        {
            if (tipo == "Canción")
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (nombre == canción.titulo)
                    {
                        int sum = calificaciones.Sum();
                        int valor = (sum / calificaciones.Count());
                        canción.Avg_calificacion = valor;
                    }
                }
            }
            else if (tipo == "Película")
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (nombre == película.titulo)
                    {
                        int sum = calificaciones.Sum();
                        int valor = (sum / calificaciones.Count());
                        película.Avg_calificación = valor;
                    }
                }
            }
        }

        private void buttonEvaluarPelícul_Click(object sender, EventArgs e)
        {

        }

        private void buttonEvaluarPelícula_Click(object sender, EventArgs e)
        {
            comboBoxCalificaciónPelícula.ResetText();
            comboBoxCalificaciónPelícula.Visible = true;
            buttonConfirmarCalificaciónPelícula.Visible = true;
        }

        private void buttonConfirmarCalificaciónPelícula_Click(object sender, EventArgs e)
        {
            if (comboBoxCalificaciónPelícula.SelectedItem == null)
            {
                MessageBox.Show("No se ha ingresado ningún valor");
            }
            else
            {
                string nota1 = comboBoxCalificaciónPelícula.SelectedItem.ToString();
                foreach (Película película in Archivos.películasApp)
                {
                    if (película.titulo == PelículaSeleccionada.Text)
                    {
                        int nota2 = Convert.ToInt32(nota1);
                        película.Calificación.Add(nota2);
                        string Película = "Película";
                        Rankear(película.titulo, película.Calificación, Película);
                        MessageBox.Show("Se ha calificado la película");
                        CalificaciónPelículaSeleccionada.Text = película.Avg_calificación.ToString();
                        Serializacion();
                    }
                }
            }
            comboBoxCalificaciónPelícula.Visible = false;
            buttonConfirmarCalificaciónPelícula.Visible = false;
        }
        string[] archivo, archivo1, archivo2, archivo3, Ruta, Ruta1, Ruta2, Ruta3;
        string ruta1, ruta2, ruta3;

        private void buttonVolverAgregarCancion_Click(object sender, EventArgs e)
        {
            labelRutaImagenCancion.Visible = false;
            labelRutaCancion.Visible = false;
            textBoxAlbumCancion.Clear();
            textBoxNombreCancion.Clear();
            textBoxArtistaCancion.Clear();
            textBoxResoluciónCancion.Clear();
            textBoxDuracionCancion.Clear();
            textBoxEspacioCancion.Clear();
            textBoxGeneroCancion.Clear();
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void buttonConfrimarAgregarCancion_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombreCancion.Text;
                string artista = textBoxArtistaCancion.Text;
                string album = textBoxAlbumCancion.Text;
                string duracion = textBoxDuracionCancion.Text;
                string genero = textBoxGeneroCancion.Text;
                string espacio = textBoxEspacioCancion.Text;
                string resolucion = textBoxResoluciónCancion.Text;
                string imagen = labelRutaImagenCancion.Text;

                if (labelRutaCancion.Visible == true)
                {
                    string ruta = labelRutaCancion.Text;
                    OnAgregarCancionClicked(nombre, artista, album, genero, "2016", "0", "0", "0", duracion, resolucion, espacio, ruta, imagen);
                    labelRutaImagenCancion.Visible = false;

                }
                else
                {
                    labelDebeAgregarArchivoCancion.Text = "Debe ingresgar un archivo para subir la canción";
                    labelDebeAgregarArchivoCancion.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Por favor ingrese los datos segun el criterio requerido");
            }
            

        }

        private void buttonIrAgregarCancion_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsernamePerfil.Text;
            if (usuario == "admin")
            {
                labelRutaCancion.Visible = false;
                labelFaltanDatosCancion.Visible = false;
                labelDebeAgregarArchivoCancion.Visible = false;
                stackPanels.Add(panels["AgregarCancionpanel"]);
                ShowLastPanel();
            }
            else
            {
                MessageBox.Show("Solo un administrador puede realizar esta acción");
            }
        }

        private void buttonVolverDeCrearPlaylist_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }
        private void OnAgregarPlaylistClicked(string nombre, string tipo_playlist)
        {
            if (nombre == "" || tipo_playlist == "")
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                bool result = AgregarPlaylistClicked(this, new AgregarPlaylistEventArgs() { Nombre = nombre, Tipo_playlist = tipo_playlist});
                if (!result)
                {
                    MessageBox.Show("Esta Playlist ya existe");
                }
                else
                {
                    foreach (Usuario usuario in Archivos.Usuarios)
                    {
                        if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                        {
                            MessageBox.Show("Playlist agregada correctamente");
                            OnPlaylistChecked(nombre);
                            usuario.Playlists.Add(nombre);
                            Serializacion();
                        }
                    }
                }
            }
        }
        private void OnPlaylistChecked(string nombre)
        {
            if (PlaylistChecked != null)
            {
                PlaylistChecked(this, new AgregarPlaylistEventArgs() { Nombre = nombre });
                textBoxNombreCrearPlaylist.ResetText();
                comboBoxTipoDePlaylist.ResetText();
                setNombrePlaylist(nombre);
                foreach (Playlist playlist in Archivos.playlists_Canciones)
                {
                    if (playlist.Nombre == nombre)
                    {
                        playlist.Agregada = true;
                        Serializacion();
                    }
                }
                stackPanels.Add(panels["MenuPanel"]);
                ShowLastPanel();
                Serializacion();
            }
        }
        public void setNombrePlaylist(string nombre)
        {
            textBoxNombreCrearPlaylist.Text = nombre;
        }

        private void buttonCrearPlaylist_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreCrearPlaylist.Text;
            string Tipo_playlist = comboBoxTipoDePlaylist.SelectedItem.ToString();
            if (nombre == ""|| Tipo_playlist == null)
            {
                MessageBox.Show("Debe rellenar todos los campos para crear la Playlist");
            }
            else
            {
                foreach (Usuario usuario in Archivos.Usuarios)
                {
                    if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                    {
                        OnAgregarPlaylistClicked(nombre, Tipo_playlist);
                    }
                }
            }
        }

        private void buttonGoSiguiendo_Click(object sender, EventArgs e)
        {
            panelInfoUsuarioSeguido.Visible = false;
            buttonGoPlaylistsUsuarioSiguiendo.Visible = false;
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Seguidores.Count == 0)
                    {
                        MessageBox.Show("Usted no sigue a ningún usuario");
                    }
                    else
                    {
                        stackPanels.Add(panels["SiguiendoPanel"]);
                        ShowLastPanel();
                        listViewSiguiendo.Clear();
                        ListViewGroup Usuarios = new ListViewGroup("Usuarios", HorizontalAlignment.Left);
                        foreach (String usuarios in usuario.Seguidores)
                        {
                            listViewSiguiendo.Items.Add(new ListViewItem(usuarios, Usuarios));

                        }
                        listViewSiguiendo.Groups.Add(Usuarios);
                    }
                }
            }
        }

        private void buttonConfirmarAgregarVideo_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = textBoxTituloPelicula.Text;
                string categoria = textBoxCategoriaPelicula.Text; ;
                string director = textBoxDirectorPelicula.Text;
                string descripcion = textBoxDecripcionPelicula.Text;
                string año = textBoxAñoPelicula.Text;
                string duracion = textBoxDuracionPelicula.Text;
                string imagen = labelRutaImagenPelicula.Text;

                if (labelRutaPelicula.Visible == true)
                {
                    string ruta = labelRutaPelicula.Text;
                    OnAgregarVideoClicked(titulo, categoria, director, descripcion, duracion, año, "0", "0", imagen, ruta, "0");
                    labelRutaImagenPelicula.Visible = false;

                }
                else
                {
                    labelFaltaArchivoVideo.Text = "Debe ingresgar un archivo para subir la canción";
                    labelFaltaArchivoVideo.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Por favor ingrese los datos segun el criterio requerido");
            }
            
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAñoPelicula_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIrAgregarVideo_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsernamePerfil.Text;
            if (usuario == "admin")
            {
                labelRutaPelicula.Visible = false;
                labelFaltanDatosPelicula.Visible = false;
                labelFaltaArchivoVideo.Visible = false;
                stackPanels.Add(panels["AgregarVideoPanel"]);
                ShowLastPanel();
            }
            else
            {
                MessageBox.Show("Solo un administrador puede realizar esta acción");
            }
        }

        private void panelAgregarVideo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGoEliminarMedia_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (textBoxUsernamePerfil.Text == usuario.Nombre_usuario)
                {
                    if (usuario.Nombre_usuario == "admin")
                    {
                        comboBoxTipoMediaParaEliminar.ResetText();
                        comboBoxMediaParaEliminar.ResetText();
                        comboBoxMediaParaEliminar.Visible = false;
                        labelMediaParaEliminar.Visible = false;
                        buttonEliminarMedia.Visible = false;
                        stackPanels.Add(panels["EliminarMediaPanel"]);
                        ShowLastPanel();
                    }
                    else
                    {
                        MessageBox.Show("Solo el administrador puede acceder a estas funciones");
                    }
                }
            }         
        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVolverDeEliminarMedia_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }
        private void buttonEliminarMedia_Click(object sender, EventArgs e)
        {
            List<Playlist> lista4 = new List<Playlist>();
            lista4 = Archivos.playlists_Canciones;
            List<Usuario> lista3 = new List<Usuario>();
            lista3 = Archivos.Usuarios;
            List<Película> lista2 = new List<Película>();
            lista2 = Archivos.películasApp;
            List <Canción> lista = new List<Canción>();
            lista = Archivos.cancionesApp;
            if (comboBoxMediaParaEliminar.SelectedItem == null)
            {
                MessageBox.Show("Elija un criterio antes de continuar");
            }
            else
            {
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Canción")
                {
                    Canción canción1 = new Canción();
                    foreach (Canción canción in lista)
                    {
                        if (canción.titulo == comboBoxMediaParaEliminar.SelectedItem.ToString())
                        {
                            canción1 = canción;
                        }
                    }
                    Archivos.cancionesApp.Remove(canción1);
                    MessageBox.Show("Se ha eliminado correctamente");


                }
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Película")
                {
                    Película película1 = new Película();
                    foreach (Película película in lista2)
                    {
                        if (película.titulo == comboBoxMediaParaEliminar.SelectedItem.ToString())
                        {
                            película1 = película;
                        }
                    }
                    Archivos.películasApp.Remove(película1);
                    MessageBox.Show("Se ha eliminado correctamente");

                }
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Usuario")
                {
                    Usuario usuario1 = new Usuario();
                    foreach (Usuario usuario in lista3)
                    {
                        if (usuario.Nombre_usuario == comboBoxMediaParaEliminar.SelectedItem.ToString())
                        {
                            usuario1 = usuario;
                        }
                    }
                    Archivos.Usuarios.Remove(usuario1);
                    MessageBox.Show("Se ha eliminado correctamente");

                }
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Playlist")
                {
                    Playlist playlist1 = new Playlist();
                    foreach (Playlist playlist in lista4)
                    {
                        if (playlist.Nombre == comboBoxMediaParaEliminar.SelectedItem.ToString())
                        {
                            playlist1 = playlist;
                        }
                    }
                    Archivos.playlists_Canciones.Remove(playlist1);
                    MessageBox.Show("Se ha eliminado correctamente");

                }
            }
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
            Serializacion();
        }

        private void buttonConfirmarTipoMediaParaEliminar_Click(object sender, EventArgs e)
        {        
            if (comboBoxTipoMediaParaEliminar.SelectedItem == null)
            {
                MessageBox.Show("Elija un criterio antes de continuar");
            }
            else
            {
                labelMediaParaEliminar.Visible = true;
                comboBoxMediaParaEliminar.Visible = true;
                buttonEliminarMedia.Visible = true;
                comboBoxMediaParaEliminar.Items.Clear();
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Canción")
                {
                    foreach (Canción canción in Archivos.cancionesApp)
                    {
                        comboBoxMediaParaEliminar.Items.Add(canción.titulo);
                    }

                }
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Película")
                {
                    foreach (Película película in Archivos.películasApp)
                    {
                        comboBoxMediaParaEliminar.Items.Add(película.titulo);
                    }

                }
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Usuario")
                {
                    foreach (Usuario usuario in Archivos.Usuarios)
                    {
                        comboBoxMediaParaEliminar.Items.Add(usuario.Nombre_usuario);
                    }

                }
                if (comboBoxTipoMediaParaEliminar.SelectedItem.ToString() == "Playlist")
                {
                    foreach (Playlist playlist in Archivos.playlists_Canciones)
                    {
                        comboBoxMediaParaEliminar.Items.Add(playlist.Nombre);
                    }

                }
            }
        }

        private void buttonInfoPelícula_Click(object sender, EventArgs e)
        {

        }

        private void buttonGoTopCanciones_Click(object sender, EventArgs e)
        {
            panelInfoPelículaTop.Visible = false;
            PelículaSeleccionadaTop.Visible = false;
            panelInfoCanciónTop.Visible = false;
            CanciónSeleccionadaTop.Visible = false;
            stackPanels.Add(panels["TopMediaPanel"]);
            ShowLastPanel();
            listViewTopPelículas.Clear();
            listViewTopCanciones.Clear();
            IEnumerable<Canción> listaOrdenada = Archivos.cancionesApp.OrderByDescending(canción => canción.Avg_calificacion);
            IEnumerable<Película> listaOrdenada2 = Archivos.películasApp.OrderByDescending(película => película.Avg_calificación);
            ListViewGroup Canciones = new ListViewGroup("Canciones", HorizontalAlignment.Left);
            foreach (Canción canción in listaOrdenada.Take(5))
            {
                listViewTopCanciones.Items.Add(new ListViewItem(canción.Titulo, Canciones));

            }
            listViewTopCanciones.Groups.Add(Canciones);
            ListViewGroup Películas = new ListViewGroup("Películas", HorizontalAlignment.Left);
            foreach (Película película in listaOrdenada2.Take(5))
            {
                listViewTopPelículas.Items.Add(new ListViewItem(película.Titulo, Películas));

            }
            listViewTopPelículas.Groups.Add(Películas);
        }

        private void buttonVolverDeTopMedia_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewTopPelículas_MouseClick(object sender, MouseEventArgs e)
        {
            panelInfoPelículaTop.Visible = true;
            panelInfoCanciónTop.Visible = false;
            PelículaSeleccionadaTop.Text = listViewTopPelículas.SelectedItems[0].SubItems[0].Text;
            foreach (Película película in Archivos.películasApp)
            {
                if (película.titulo == PelículaSeleccionadaTop.Text)
                {
                    panel2.Visible = true;
                    AñoPeliculaSeleccionadaTop.Text = película.añoPublicacion.ToString();
                    DuraciónPeliculaSeleccionadaTop.Text = película.duracion.ToString();
                    CalificaciónPeliculaSeleccionadaTop.Text = película.Avg_calificación.ToString();
                    ReproduccionesPeliculaSeleccionadaTop.Text = película.reproducciones.ToString();

                }
            }
        }

        private void listViewTopCanciones_MouseClick(object sender, MouseEventArgs e)
        {
            panelInfoPelículaTop.Visible = false;
            panelInfoCanciónTop.Visible = true;
            CanciónSeleccionadaTop.Text = listViewTopCanciones.SelectedItems[0].SubItems[0].Text;
            foreach (Canción canción in Archivos.cancionesApp)
            {
                if (canción.titulo == CanciónSeleccionadaTop.Text)
                {
                    AlbumCanciónSeleccionadaTop.Text = canción.album.Nombre;
                    ArtistaCanciónSeleccionadaTop.Text = canción.artista.Apellido;
                    DuraciónCanciónSeleccionadaTop.Text = canción.duración.ToString();
                    ReproduccionesCanciónSeleccionadaTop.Text = canción.reproducciones.ToString();
                    CalificaciónCanciónSeleccionadaTop.Text = canción.Avg_calificacion.ToString();
                }
            }
        }
        int b = 0;
        private void buttonAgregarColaCanción_Click(object sender, EventArgs e)
        {
            foreach (Canción canción in Archivos.cancionesApp)
            {
                if (canción.titulo == CanciónSeleccionada.Text)
                {
                    colaCanciones.Insert(b, canción);
                    MessageBox.Show("Se ha añadido a la cola");
                }
            }
            b += 1;
        }
        int i = 0;
        private void buttonNext1_Click(object sender, EventArgs e)
        {
            try
            {
                buttonNext1.Visible = false;
                buttonNext2.Visible = true;
                EncontrarArchivo(colaCanciones[i].titulo);
                axWindowsMediaPlayer1.URL = this.ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                colaCanciones[i].reproducciones += 1;
                ReproduccionesCanciónSeleccionada.Text = colaCanciones[i].reproducciones.ToString();
                labelCanciónReproducida.Text = colaCanciones[i].titulo;
                i += 1;
                foreach (Usuario usuario in Archivos.Usuarios)
                {
                    if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                    {
                        usuario.Historial.Add(colaCanciones[i].titulo);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Al parecer la cola esta vacía");
            }
        }
        private void buttonNext2_Click(object sender, EventArgs e)
        {
            try
            {
                buttonNext1.Visible = false;
                buttonNext2.Visible = true;
                EncontrarArchivo(colaCanciones[i].titulo);
                axWindowsMediaPlayer1.URL = this.ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                colaCanciones[i].reproducciones += 1;
                ReproduccionesCanciónSeleccionada.Text = colaCanciones[i].reproducciones.ToString();
                labelCanciónReproducida.Text = colaCanciones[i].titulo;
                i += 1;
                foreach (Usuario usuario in Archivos.Usuarios)
                {
                    if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                    {
                        usuario.Historial.Add(colaCanciones[i].titulo);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Agregue más canciones a la cola");
            }
        }
        
        
        int c = 0;
        private void buttonAgregarColaPelícula_Click(object sender, EventArgs e)
        {
            foreach (Película película in Archivos.películasApp)
            {
                if (película.titulo == PelículaSeleccionada.Text)
                {
                    colaPelículas.Insert(c, película);
                    MessageBox.Show("Se ha añadido a la cola");
                }
            }
            c += 1;
        }
        int u = 0;
        private void buttonNext1Películas_Click_1(object sender, EventArgs e)
        {
            try
            {
                buttonNext1Películas.Visible = false;
                buttonNext2Películas.Visible = true;
                EncontrarArchivo(colaPelículas[u].titulo);
                axWindowsMediaPlayer2.URL = this.ruta;
                axWindowsMediaPlayer2.Ctlcontrols.play();
                colaPelículas[u].reproducciones += 1;
                NumeroReproduccionesPelículaSeleccionada.Text = colaPelículas[u].reproducciones.ToString();
                u += 1;
            }
            catch
            {
                MessageBox.Show("Al parecer la cola esta vacía");
            }
        }

        private void buttonNext2Películas_Click_1(object sender, EventArgs e)
        {
            try
            {
                buttonNext1Películas.Visible = false;
                buttonNext2Películas.Visible = true;
                EncontrarArchivo(colaPelículas[u].titulo);
                axWindowsMediaPlayer2.URL = this.ruta;
                axWindowsMediaPlayer2.Ctlcontrols.play();
                colaPelículas[u].reproducciones += 1;
                NumeroReproduccionesPelículaSeleccionada.Text = colaPelículas[u].reproducciones.ToString();
                u += 1;
            }
            catch
            {
                MessageBox.Show("Agregue más películas a la cola");
            }
        }

        private void pictureBoxSalirReproducirPelicula_Click_1(object sender, EventArgs e)
        {
            buttonAgregarPelículaAMisPlaylist.Visible = true;
            panel2.Visible = true;
            buttonVolverDeVerPelícula.Visible = true;
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Visible = false;
            pictureBoxSalirReproducirPelicula.Visible = false;
            PelículaSeleccionada.Visible = false;
            buttonNext1Películas.Visible = false;
            buttonNext2Películas.Visible = false;
        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerInformacionPerfil_Click(object sender, EventArgs e)
        {
            string usuario = UsernameEditarPerfil.Text;
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario == usuario1.Nombre_usuario)
                {
                    labelMailUsuario.Text = usuario1.Email;
                    labelPrivacidadUsuario.Text = usuario1.Privacidad;
                    labelGeneroUsuario.Text = usuario1.Genero;
                    labelNacionalidadUsuario.Text = usuario1.Nacionalidad;
                    labelFechaDeNacimiento.Text = usuario1.FechaNac;
                    labelSeguidoresUsuario.Text = Convert.ToString(usuario1.NúmeroSeguidores);
                    labelTipoDeUsuario.Text = usuario1.Tipo_usuario;

                }
            }
            panelInformacionPerfil.Visible = true;
            btnConfirmarCambiarDatosPerfil.Visible = false;
            btnEditarDatosPerfil.Visible = true;
            comboBoxEditarGeneroUsuario.Visible = false;
            comboBoxEditarPrivacidadUsuario.Visible = false;
            textBoxEditarFechaNacimiento.Visible = false;
            textBoxEditarNacionalidad.Visible = false;
            labelPrivacidadUsuario.Visible = true;
            labelGeneroUsuario.Visible = true;
            labelFechaDeNacimiento.Visible = true;
            labelNacionalidadUsuario.Visible = true;

        }

        private void btnEditarDatosPerfil_Click(object sender, EventArgs e)
        {
            btnConfirmarCambiarDatosPerfil.Visible = true;
            btnEditarDatosPerfil.Visible = false;
            comboBoxEditarGeneroUsuario.Visible = true;
            comboBoxEditarPrivacidadUsuario.Visible = true;
            textBoxEditarFechaNacimiento.Visible = true;
            textBoxEditarNacionalidad.Visible = true;
            labelPrivacidadUsuario.Visible = false;
            labelGeneroUsuario.Visible = false;
            labelFechaDeNacimiento.Visible = false;
            labelNacionalidadUsuario.Visible = false;
            comboBoxEditarPrivacidadUsuario.Text = labelPrivacidadUsuario.Text;
            if (labelGeneroUsuario.Text == "")
            {
                comboBoxEditarGeneroUsuario.Text = "Prefiero no especificar";
            }
            else
            {
                comboBoxEditarGeneroUsuario.Text = labelGeneroUsuario.Text;
            }
            
        }

        private void btnConfirmarCambiarDatosPerfil_Click(object sender, EventArgs e)
        {
            btnConfirmarCambiarDatosPerfil.Visible = false;
            btnEditarDatosPerfil.Visible = true;
            string usuario = UsernameEditarPerfil.Text;
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario == usuario1.Nombre_usuario)
                {
                    usuario1.Privacidad = comboBoxEditarPrivacidadUsuario.SelectedItem.ToString();
                    usuario1.Genero = comboBoxEditarGeneroUsuario.SelectedItem.ToString();
                    usuario1.Nacionalidad = textBoxEditarNacionalidad.Text;
                    usuario1.FechaNac = textBoxEditarFechaNacimiento.Text;

                }
            }
            comboBoxEditarGeneroUsuario.Visible = false;
            comboBoxEditarPrivacidadUsuario.Visible = false;
            textBoxEditarFechaNacimiento.Visible = false;
            textBoxEditarNacionalidad.Visible = false;
            labelPrivacidadUsuario.Text = comboBoxEditarPrivacidadUsuario.SelectedItem.ToString(); 
            labelGeneroUsuario.Text = comboBoxEditarGeneroUsuario.SelectedItem.ToString();
            labelNacionalidadUsuario.Text = textBoxEditarNacionalidad.Text;
            labelFechaDeNacimiento.Text = textBoxEditarFechaNacimiento.Text;
            labelPrivacidadUsuario.Visible = true;
            labelGeneroUsuario.Visible = true;
            labelFechaDeNacimiento.Visible = true;
            labelNacionalidadUsuario.Visible = true;
            Serializacion();
        }
        int d = 0;
        private void buttonAgregarCancionAPlaylist_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Tipo_usuario == "Gratis")
                    {
                        MessageBox.Show("Esta función solo es válida para usuarios Premium");
                    }
                    else
                    {
                        foreach (Canción canción in Archivos.cancionesApp)
                        {
                            if (canción.titulo == CanciónSeleccionada.Text)
                            {
                                if (usuario.PlaylistC.Contains(canción.titulo))
                                {
                                    MessageBox.Show("Esta canción ya está en su lista");
                                }
                                else
                                {
                                    usuario.PlaylistC.Insert(d, canción.titulo);
                                    d += 1;
                                    MessageBox.Show("Se ha añadido a su PlayList de canciones");
                                }
                            }
                        }
                    }
                }
            }
            Serializacion();
        }
        int p = 0;
        private void buttonAgregarPelículaAPlaylist_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Tipo_usuario == "Gratis")
                    {
                        MessageBox.Show("Esta función solo es válida para usuarios Premium");
                    }
                    else
                    {
                        foreach (Película película in Archivos.películasApp)
                        {
                            if (película.titulo == PelículaSeleccionada.Text)
                            {
                                if (usuario.PlaylistV.Contains(película.titulo))
                                {
                                    MessageBox.Show("Esta película ya está en su lista");
                                }
                                else
                                {
                                    usuario.PlaylistV.Insert(p, película.titulo);
                                    p += 1;
                                    MessageBox.Show("Se ha añadido a su PlayList de películas");
                                }
                            }
                        }
                    }
                }
            }
            Serializacion();
        }

        private void panelMisPlaylist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVolverDeHistorial_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void buttonGoHistorial_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Historial.Count == 0)
                    {
                        MessageBox.Show("El historial de reproducción está vacío");
                    }
                    else
                    {
                        listViewHistorial.Clear();
                        stackPanels.Add(panels["HistorialPanel"]);
                        ShowLastPanel();
                        ListViewGroup Historial = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                        foreach (String historial in usuario.Historial)
                        {
                            listViewHistorial.Items.Add(new ListViewItem(historial, Historial));

                        }
                        listViewHistorial.Groups.Add(Historial);
                    }
                }
            }
        }

        private void buttonVolverDeUsuarios_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void buttonGoUsuarios_Click(object sender, EventArgs e)
        {
            buttonSeguirUsuario.Visible = false;
            listViewUsuarios.Clear();
            stackPanels.Add(panels["UsuariosPanel"]);
            ShowLastPanel();
            ListViewGroup Usuarios = new ListViewGroup("Usuarios", HorizontalAlignment.Left);
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario != textBoxUsernamePerfil.Text && usuario.Nombre_usuario != "admin")
                {
                    listViewUsuarios.Items.Add(new ListViewItem(usuario.Nombre_usuario, Usuarios));
                }
            }
            listViewUsuarios.Groups.Add(Usuarios);
        }

        private void buttonVolverDeSeguidores_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void listViewUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            buttonSeguirUsuario.Visible = true;
            UsuarioSeleccionado.Text = listViewUsuarios.SelectedItems[0].SubItems[0].Text;
        }
        
        private void buttonSeguirUsuario_Click(object sender, EventArgs e)
        {
            string nombre = UsuarioSeleccionado.Text;
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Seguidores.Contains(nombre))
                    {
                        MessageBox.Show("Usted ya sigue a este usuario");
                    }
                    else
                    {
                        foreach (Usuario usuario1 in Archivos.Usuarios)
                        {
                            if (usuario1.Nombre_usuario == nombre)
                            {
                                if (usuario1.Privacidad == "Privada")
                                {
                                    if (usuario1.Solicitudes.Contains(usuario.Nombre_usuario))
                                    {
                                        MessageBox.Show("Solicitud de seguimiento en proceso");
                                    }
                                    else
                                    {
                                        usuario1.Solicitudes.Add(usuario.Nombre_usuario);
                                        MessageBox.Show("Este usuario es privado, se le ha enviado una solictud de seguimiento");
                                    }
                                }
                                else
                                {
                                    usuario.Seguidores.Add(nombre);
                                    MessageBox.Show("¡Siguiendo!");
                                    usuario1.NúmeroSeguidores += 1;
                                }
                            }
                        }
                    }
                }
            }
            Serializacion();
        }

        private void listViewSiguiendo_MouseClick(object sender, MouseEventArgs e)
        {
            panelInfoUsuarioSeguido.Visible = true;
            buttonGoPlaylistsUsuarioSiguiendo.Visible = true;
            UsuarioSeguidoSeleccionado.Text = listViewSiguiendo.SelectedItems[0].SubItems[0].Text;
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == UsuarioSeguidoSeleccionado.Text)
                {
                    labelGéneroUsuarioSiguiendo.Text = usuario.Genero;
                    labelPrivacidadUsuarioSiguiendo.Text = usuario.Privacidad;
                    labelTipoUsuarioSiguiendo.Text = usuario.Tipo_usuario;
                    labelNacionalidadUsuarioSiguiendo.Text = usuario.Nacionalidad;
                    labelFechaNacimientoUsuarioSiguiendo.Text = usuario.FechaNac;
                }
            }
        }

        private void buttonGoPlaylistsUsuarioSiguiendo_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == UsuarioSeguidoSeleccionado.Text)
                {
                    if (usuario1.Tipo_usuario == "Premium" || usuario1.Nombre_usuario == "admin")
                    {
                        buttonEliminarPlaylist.Visible = false;
                        axWindowsMediaPlayer5.Visible = false;
                        axWindowsMediaPlayer6.Visible = false;
                        buttonNextPlaylistPelículas.Visible = false;
                        buttonNextPlaylistCanciones.Visible = false;
                        buttonReproducirPlaylistCanciones.Visible = false;
                        pictureBoxSalirPelículaTodasMisPlaylist.Visible = false;
                        listViewPelículasDeMisPlaylist.Visible = false;
                        listViewCancionesDeMisPlaylist.Visible = false;
                        labelPelículasTodasMisPlaylist.Visible = false;
                        labelCancionesTodasMisPlaylist.Visible = false;
                        stackPanels.Add(panels["TodasMisPlaylistsPanel"]);
                        ShowLastPanel();
                        labelUsuarioTodaMisPlaylist.Text = UsuarioSeguidoSeleccionado.Text;
                        foreach (Usuario usuario in Archivos.Usuarios)
                        {
                            if (usuario.Nombre_usuario == labelUsuarioTodaMisPlaylist.Text)
                            {
                                listViewTodasMisPlaylists.Clear();
                                ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                                foreach (String película in usuario.Playlists)
                                {
                                    listViewTodasMisPlaylists.Items.Add(new ListViewItem(película, Playlists));

                                }
                                listViewTodasMisPlaylists.Groups.Add(Playlists);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este usuario es Gratis y no posee listas");
                    }
                }
            }
        }

        private void buttonReproducirPlaylistCanción_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == labelUsuarioPlaylist.Text)
                {
                    try
                    {
                        axWindowsMediaPlayer3.Visible = true;
                        EncontrarArchivo(usuario1.PlaylistC[0]);
                        axWindowsMediaPlayer3.URL = this.ruta;
                        axWindowsMediaPlayer3.Ctlcontrols.play();
                        usuario1.Historial.Add(usuario1.PlaylistC[0]);
                    }
                    catch
                    {
                        MessageBox.Show("Al parecer la playlist esta vacía");
                    }
                }
            }
        }
        int cuenta = 1;
        private void buttonNextPlaylistCanción_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == labelUsuarioPlaylist.Text)
                {
                    try
                    {
                        EncontrarArchivo(usuario1.PlaylistC[cuenta]);
                        axWindowsMediaPlayer3.URL = this.ruta;
                        axWindowsMediaPlayer3.Ctlcontrols.play();
                        usuario1.Historial.Add(usuario1.PlaylistC[cuenta]);
                        cuenta += 1;
                    }
                    catch
                    {
                        MessageBox.Show("Agregue mas canciones a su playlist");
                    }
                }
            }
        }

        private void buttonReproducirPlaylistPelícula_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Visible = false;
            axWindowsMediaPlayer3.Ctlcontrols.pause();
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == labelUsuarioPlaylist.Text)
                {
                    try
                    {
                        EncontrarArchivo(usuario1.PlaylistV[0]);
                        axWindowsMediaPlayer4.Visible = true;
                        buttonNextPlaylistPelícula.Visible = true;
                        buttonReproducirPlaylistPelícula.Visible = false;
                        axWindowsMediaPlayer4.URL = this.ruta;
                        pictureBoxSalirPelículaPlaylist.SizeMode = PictureBoxSizeMode.StretchImage;
                        axWindowsMediaPlayer4.Dock = DockStyle.Fill;
                        pictureBoxSalirPelículaPlaylist.Visible = true;
                        axWindowsMediaPlayer4.Ctlcontrols.play();
                        usuario1.Historial.Add(usuario1.PlaylistV[0]);
                    }
                    catch
                    {
                        MessageBox.Show("Al parecer la playlist esta vacía");
                    }
                }
            }
        }

        private void pictureBoxSalirPelículaPlaylist_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.pause();
            axWindowsMediaPlayer4.Visible = false;
            pictureBoxSalirPelículaPlaylist.Visible = false;
            buttonNextPlaylistPelícula.Visible = false;
            buttonReproducirPlaylistPelícula.Visible = true;
        }
        int cuenta2 = 1;
        private void buttonNextPlaylistPelícula_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == labelUsuarioPlaylist.Text)
                {
                    try
                    {
                        EncontrarArchivo(usuario1.PlaylistV[cuenta2]);
                        axWindowsMediaPlayer4.URL = this.ruta;
                        axWindowsMediaPlayer4.Ctlcontrols.play();
                        usuario1.Historial.Add(usuario1.PlaylistV[cuenta2]);
                        cuenta2 += 1;
                    }
                    catch
                    {
                        MessageBox.Show("Agregue mas películas a su playlist");
                    }
                }
            }
        }

        private void buttonVolverDeTodasMisPlaylists_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
            axWindowsMediaPlayer5.Ctlcontrols.pause();
            CuentaTodasPlaylistCanciones = 0;
            CuentaTodasPlaylistPelículas = 0;
        }

        private void buttonGoTodasMisPlaylists_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario1.Tipo_usuario == "Premium" || usuario1.Nombre_usuario == "admin")
                    {
                        buttonEliminarPlaylist.Visible = false;
                        axWindowsMediaPlayer5.Visible = false;
                        axWindowsMediaPlayer6.Visible = false;
                        buttonNextPlaylistPelículas.Visible = false;
                        buttonNextPlaylistCanciones.Visible = false;
                        buttonReproducirPlaylistCanciones.Visible = false;
                        pictureBoxSalirPelículaTodasMisPlaylist.Visible = false;
                        listViewPelículasDeMisPlaylist.Visible = false;
                        listViewCancionesDeMisPlaylist.Visible = false;
                        labelPelículasTodasMisPlaylist.Visible = false;
                        labelCancionesTodasMisPlaylist.Visible = false;
                        stackPanels.Add(panels["TodasMisPlaylistsPanel"]);
                        ShowLastPanel();
                        labelUsuarioTodaMisPlaylist.Text = textBoxUsernamePerfil.Text;
                        foreach (Usuario usuario in Archivos.Usuarios)
                        {
                            if (usuario.Nombre_usuario == labelUsuarioTodaMisPlaylist.Text)
                            {
                                listViewTodasMisPlaylists.Clear();
                                ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                                foreach (String película in usuario.Playlists)
                                {
                                    listViewTodasMisPlaylists.Items.Add(new ListViewItem(película, Playlists));

                                }
                                listViewTodasMisPlaylists.Groups.Add(Playlists);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo los usuarios Premium pueden acceder a esta función");
                    }
                }
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGoCrearPlaylist_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Tipo_usuario == "Premium" || usuario.Nombre_usuario == "admin")
                    {
                        stackPanels.Add(panels["CrearPlaylistPanel"]);
                        ShowLastPanel();
                        textBoxNombreCrearPlaylist.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Solo los usuarios Premium pueden acceder a esta función");
                    }
                }
            }
        }

        private void listViewTodasMisPlaylists_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer5.Visible = false;
            axWindowsMediaPlayer5.Ctlcontrols.pause();
            buttonNextPlaylistCanciones.Visible = false;
            buttonEliminarPlaylist.Visible = true;
            string nombre = listViewTodasMisPlaylists.SelectedItems[0].SubItems[0].Text;
            foreach (Playlist playlist in Archivos.playlists_Canciones)
            {
                if (playlist.Nombre == nombre)
                {
                    if (playlist.Tipo_playlist == "De Canciones")
                    {
                        buttonReproducirPlaylistCanciones.Visible = true;
                        listViewPelículasDeMisPlaylist.Visible = false;
                        labelPelículasTodasMisPlaylist.Visible = false;
                        labelCancionesTodasMisPlaylist.Text = nombre;
                        labelCancionesTodasMisPlaylist.Visible = true;
                        listViewCancionesDeMisPlaylist.Visible = true;
                        listViewCancionesDeMisPlaylist.Clear();
                        ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                        foreach (String película in playlist.ListaCanciones)
                        {
                            listViewCancionesDeMisPlaylist.Items.Add(new ListViewItem(película, Playlists));

                        }
                        listViewCancionesDeMisPlaylist.Groups.Add(Playlists);
                    }
                    if (playlist.Tipo_playlist == "De Películas")
                    {
                        buttonReproducirPlaylistCanciones.Visible = true;
                        buttonNextPlaylistCanción.Visible = true;
                        listViewCancionesDeMisPlaylist.Visible = false;
                        labelCancionesTodasMisPlaylist.Visible = false;
                        labelPelículasTodasMisPlaylist.Text = nombre;
                        labelPelículasTodasMisPlaylist.Visible = true;
                        listViewPelículasDeMisPlaylist.Visible = true;
                        listViewPelículasDeMisPlaylist.Clear();
                        ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                        foreach (String película in playlist.ListaPelículas)
                        {
                            listViewPelículasDeMisPlaylist.Items.Add(new ListViewItem(película, Playlists));

                        }
                        listViewPelículasDeMisPlaylist.Groups.Add(Playlists);
                    }
                }
            }
        }

        private void buttonAgregarAMisPlaylists_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario1.Tipo_usuario == "Premium" || usuario1.Nombre_usuario == "admin")
                    {
                        buttonConfirmarAgregarCanciónAPlaylist.Visible = true;
                        comboBoxPlaylistParaAgregarCanción.ResetText();
                        comboBoxPlaylistParaAgregarCanción.Items.Clear();
                        comboBoxPlaylistParaAgregarCanción.Visible = true;
                        foreach (Usuario usuario in Archivos.Usuarios)
                        {
                            if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                            {
                                foreach (String película in usuario.Playlists)
                                {
                                    foreach (Playlist playlist in Archivos.playlists_Canciones)
                                    {
                                        if (película == playlist.Nombre)
                                        {
                                            if (playlist.Tipo_playlist == "De Canciones")
                                            {
                                                comboBoxPlaylistParaAgregarCanción.Items.Add(película);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo los usuarios Premium pueden acceder a esta función");
                    }
                }
            }
        }
        private void buttonConfirmarAgregarCanciónAPlaylist_Click(object sender, EventArgs e)
        {
            if (comboBoxPlaylistParaAgregarCanción.Text != "")
            {
                string nombre1 = comboBoxPlaylistParaAgregarCanción.Text;
                string nombre2 = CanciónSeleccionada.Text;
                foreach (Playlist playlist in Archivos.playlists_Canciones)
                {
                    if (playlist.Nombre == nombre1)
                    {
                        if (playlist.ListaCanciones.Contains(nombre2))
                        {
                            MessageBox.Show("Esta canción ya fue agregada a esta lista");
                        }
                        else
                        {
                            if (playlist.ListaCanciones.Count() == 0)
                            {
                                playlist.ListaCanciones.Insert(0, nombre2);
                            }
                            else
                            {
                                int contador = playlist.ListaCanciones.Count();
                                playlist.ListaCanciones.Insert(contador, nombre2);
                            }
                            MessageBox.Show("Canción agregada correctamente");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese una playlist para agregar la canción");
            }
            comboBoxPlaylistParaAgregarCanción.Visible = false;
            buttonConfirmarAgregarCanciónAPlaylist.Visible = false;
            Serializacion();
        }

        private void buttonAgregarPelículaAMisPlaylist_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario1.Tipo_usuario == "Premium" || usuario1.Nombre_usuario == "admin")
                    {
                        buttonConfirmarAgregarPelículaAPlaylist.Visible = true;
                        comboBoxPlaylistParaAgregarPelícula.ResetText();
                        comboBoxPlaylistParaAgregarPelícula.Items.Clear();
                        comboBoxPlaylistParaAgregarPelícula.Visible = true;
                        foreach (Usuario usuario in Archivos.Usuarios)
                        {
                            if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                            {
                                foreach (String película in usuario.Playlists)
                                {
                                    foreach (Playlist playlist in Archivos.playlists_Películas)
                                    {
                                        if (película == playlist.Nombre)
                                        {
                                            if (playlist.Tipo_playlist == "De Películas")
                                            {
                                                comboBoxPlaylistParaAgregarPelícula.Items.Add(película);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo los usuarios Premium pueden acceder a esta función");
                    }
                }
            }
        }
        private void buttonConfirmarAgregarPelículaAPlaylist_Click(object sender, EventArgs e)
        {
            if (comboBoxPlaylistParaAgregarPelícula.Text != "")
            {
                string nombre1 = comboBoxPlaylistParaAgregarPelícula.Text;
                string nombre2 = PelículaSeleccionada.Text;
                foreach (Playlist playlist in Archivos.playlists_Películas)
                {
                    if (playlist.Nombre == nombre1)
                    {
                        if (playlist.ListaPelículas.Contains(nombre2))
                        {
                            MessageBox.Show("Esta película ya fue agregada a esta lista");
                        }
                        else
                        {
                            if (playlist.ListaPelículas.Count() == 0)
                            {
                                playlist.ListaPelículas.Insert(0, nombre2);
                            }
                            else
                            {
                                int contador = playlist.ListaPelículas.Count();
                                playlist.ListaPelículas.Insert(contador, nombre2);
                            }
                            MessageBox.Show("Película agregada correctamente");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese una playlist para agregar la película");
            }
            comboBoxPlaylistParaAgregarPelícula.Visible = false;
            buttonConfirmarAgregarPelículaAPlaylist.Visible = false;
            Serializacion();
        }

        private void buttonGoSolicitudes_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario.Solicitudes.Count() == 0)
                    {
                        MessageBox.Show("Usted no tiene solicitudes de amistad");
                    }
                    else
                    {
                        buttonRechazarSolicitud.Visible = false;
                        buttonAceptarSolicitud.Visible = false;
                        label78.Visible = false;
                        labelUsuarioSolicitud.Visible = false;
                        stackPanels.Add(panels["SolicitudesPanel"]);
                        ShowLastPanel();
                        listViewSolicitudes.Clear();
                        ListViewGroup Solicitudes = new ListViewGroup("Solicitudes", HorizontalAlignment.Left);
                        foreach (String solicitud in usuario.Solicitudes)
                        {
                            listViewSolicitudes.Items.Add(new ListViewItem(solicitud, Solicitudes));

                        }
                        listViewSolicitudes.Groups.Add(Solicitudes);
                    }
                }
            }
        }

        private void buttonVolverDeSolicitudes_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void listViewSolicitudes_MouseClick(object sender, MouseEventArgs e)
        {
            string usuario = listViewSolicitudes.SelectedItems[0].SubItems[0].Text;
            labelUsuarioSolicitud.Text = usuario;
            buttonAceptarSolicitud.Visible = true;
            buttonRechazarSolicitud.Visible = true;
            label78.Visible = true;
            labelUsuarioSolicitud.Visible = true;
        }

        private void buttonAceptarSolicitud_Click(object sender, EventArgs e)
        {
            string usuario1 = textBoxUsernamePerfil.Text;
            string usuario3 = labelUsuarioSolicitud.Text;
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == labelUsuarioSolicitud.Text)
                {
                    usuario.Seguidores.Add(usuario1);
                    MessageBox.Show("Solicitud aceptada");
                    buttonAceptarSolicitud.Visible = false;
                    buttonRechazarSolicitud.Visible = false;
                }
            }
            foreach (Usuario usuario2 in Archivos.Usuarios)
            {
                if (usuario2.Nombre_usuario == usuario1)
                {
                    usuario2.NúmeroSeguidores += 1;
                    usuario2.Solicitudes.Remove(usuario3);
                    listViewSolicitudes.Clear();
                    ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                    foreach (String solicitud in usuario2.Solicitudes)
                    {
                        listViewSolicitudes.Items.Add(new ListViewItem(solicitud, Playlists));

                    }
                    listViewSolicitudes.Groups.Add(Playlists);
                }
            }
            buttonRechazarSolicitud.Visible = false;
            buttonAceptarSolicitud.Visible = false;
            label78.Visible = false;
            labelUsuarioSolicitud.Visible = false;
            Serializacion();
        }

        private void buttonRechazarSolicitud_Click(object sender, EventArgs e)
        {
            string usuario1 = labelUsuarioSolicitud.Text;
            foreach (Usuario usuario in Archivos.Usuarios)
            {
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    usuario.Solicitudes.Remove(usuario1);
                    MessageBox.Show("Solicitud rechazada");
                    listViewSolicitudes.Clear();
                    ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                    foreach (String solicitud in usuario.Solicitudes)
                    {
                        listViewSolicitudes.Items.Add(new ListViewItem(solicitud, Playlists));

                    }
                    listViewSolicitudes.Groups.Add(Playlists);
                }
            }
            buttonRechazarSolicitud.Visible = false;
            buttonAceptarSolicitud.Visible = false;
            label78.Visible = false;
            labelUsuarioSolicitud.Visible = false;
            Serializacion();
        }
        private void buttonAgregarOtroFiltro1_Click_1(object sender, EventArgs e)
        {
            comboBoxFiltro2.Items.Clear();
            comboBoxFiltro2.ResetText();
            comboBoxFiltro2.Visible = true;
            if (comboBoxCriterio1.Text == "Playlists")
            {
                comboBoxFiltro2.Items.Add("De películas");
                comboBoxFiltro2.Items.Add("De Canciones");
                comboBoxFiltro2.Items.Remove(comboBoxFiltro1.Text);
            }
            if (comboBoxCriterio1.Text == "Canciones")
            {
                comboBoxFiltro2.Items.Add("Título");
                comboBoxFiltro2.Items.Add("Álbum");
                comboBoxFiltro2.Items.Add("Artista");
                comboBoxFiltro2.Items.Add("Género");
                comboBoxFiltro2.Items.Remove(comboBoxFiltro1.Text);
            }
            if (comboBoxCriterio1.Text == "Películas")
            {
                comboBoxFiltro2.Items.Add("Título");
                comboBoxFiltro2.Items.Add("Categoría");
                comboBoxFiltro2.Items.Add("Director");
                comboBoxFiltro2.Items.Remove(comboBoxFiltro1.Text);
            }
            buttonAgregarOtroFiltro1.Visible = false;
        }

        private void buttonAgregarOtroFiltro2_Click(object sender, EventArgs e)
        {
            comboBoxFiltro3.Items.Clear();
            comboBoxFiltro3.ResetText();
            comboBoxFiltro3.Visible = true;
            if (comboBoxCriterio1.Text == "Canciones")
            {
                comboBoxFiltro3.Items.Add("Título");
                comboBoxFiltro3.Items.Add("Álbum");
                comboBoxFiltro3.Items.Add("Artista");
                comboBoxFiltro3.Items.Add("Género");
                comboBoxFiltro3.Items.Remove(comboBoxFiltro1.Text);
                comboBoxFiltro3.Items.Remove(comboBoxFiltro2.Text);
            }
            if (comboBoxCriterio1.Text == "Películas")
            {
                comboBoxFiltro3.Items.Add("Título");
                comboBoxFiltro3.Items.Add("Categoría");
                comboBoxFiltro3.Items.Add("Director");
                comboBoxFiltro3.Items.Remove(comboBoxFiltro1.Text);
                comboBoxFiltro3.Items.Remove(comboBoxFiltro2.Text);
            }
            buttonAgregarOtroFiltro2.Visible = false;
        }


        private void panelBúsqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonReproducirPlaylistCanciones_Click(object sender, EventArgs e)
        {
            CuentaTodasPlaylistCanciones = 1;
            CuentaTodasPlaylistPelículas = 1;
            string nombre = listViewTodasMisPlaylists.SelectedItems[0].SubItems[0].Text;
            foreach (Playlist playlist in Archivos.playlists_Canciones)
            {
                if (playlist.Nombre == nombre)
                {
                    if (playlist.Tipo_playlist == "De Canciones")
                    {
                        foreach (Usuario usuario1 in Archivos.Usuarios)
                        {
                            if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                            {
                                try
                                {
                                    buttonNextPlaylistCanciones.Visible = true;
                                    EncontrarArchivo(playlist.ListaCanciones[0]);
                                    axWindowsMediaPlayer5.Visible = true;
                                    axWindowsMediaPlayer5.URL = this.ruta;
                                    axWindowsMediaPlayer5.Ctlcontrols.play();
                                    usuario1.Historial.Add(playlist.ListaCanciones[0]);
                                }
                                catch
                                {
                                    MessageBox.Show("Al parecer la playlist esta vacía");
                                }
                            }
                        }
                    }
                    if (playlist.Tipo_playlist == "De Películas")
                    {
                        foreach (Usuario usuario1 in Archivos.Usuarios)
                        {
                            if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                            {
                                try
                                {
                                    buttonEliminarPlaylist.Visible = false;
                                    EncontrarArchivo(playlist.ListaPelículas[0]);
                                    axWindowsMediaPlayer6.Visible = true;
                                    buttonNextPlaylistPelículas.Visible = true;
                                    buttonReproducirPlaylistCanciones.Visible = false;
                                    axWindowsMediaPlayer6.URL = this.ruta;
                                    pictureBoxSalirPelículaTodasMisPlaylist.SizeMode = PictureBoxSizeMode.StretchImage;
                                    axWindowsMediaPlayer6.Dock = DockStyle.Fill;
                                    pictureBoxSalirPelículaTodasMisPlaylist.Visible = true;
                                    axWindowsMediaPlayer6.Ctlcontrols.play();
                                    usuario1.Historial.Add(playlist.ListaPelículas[0]);
                                }
                                catch
                                {
                                    buttonEliminarPlaylist.Visible = true;
                                    MessageBox.Show("Al parecer la playlist esta vacía");
                                }
                            }
                        }
                    }
                }
            }
        }
        int CuentaTodasPlaylistCanciones = 1;
        private void buttonNextPlaylistCanciones_Click(object sender, EventArgs e)
        {
            string nombre = listViewTodasMisPlaylists.SelectedItems[0].SubItems[0].Text;
            foreach (Playlist playlist in Archivos.playlists_Canciones)
            {
                if (playlist.Nombre == nombre)
                {
                    foreach (Usuario usuario1 in Archivos.Usuarios)
                    {
                        if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                        {
                            try
                            {
                                EncontrarArchivo(playlist.ListaCanciones[CuentaTodasPlaylistCanciones]);
                                axWindowsMediaPlayer5.URL = this.ruta;
                                axWindowsMediaPlayer5.Ctlcontrols.play();
                                usuario1.Historial.Add(playlist.ListaCanciones[CuentaTodasPlaylistCanciones]);
                                CuentaTodasPlaylistCanciones += 1;
                            }
                            catch
                            {
                                MessageBox.Show("Agregue mas canciones a su playlist");
                            }
                        }
                    }
                }
            }
        }
        int CuentaTodasPlaylistPelículas = 1;
        private void buttonNextPlaylistPelículas_Click(object sender, EventArgs e)
        {
            string nombre = listViewTodasMisPlaylists.SelectedItems[0].SubItems[0].Text;
            foreach (Playlist playlist in Archivos.playlists_Canciones)
            {
                if (playlist.Nombre == nombre)
                {
                    foreach (Usuario usuario1 in Archivos.Usuarios)
                    {
                        if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                        {
                            try
                            {
                                EncontrarArchivo(playlist.ListaPelículas[CuentaTodasPlaylistPelículas]);
                                axWindowsMediaPlayer6.URL = this.ruta;
                                axWindowsMediaPlayer6.Ctlcontrols.play();
                                usuario1.Historial.Add(playlist.ListaPelículas[CuentaTodasPlaylistPelículas]);
                                CuentaTodasPlaylistPelículas += 1;
                            }
                            catch
                            {
                                MessageBox.Show("Agregue mas películas a su playlist");
                            }
                        }
                    }
                }
            }
        }

        private void pictureBoxSalirPelículaTodasMisPlaylist_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer6.Ctlcontrols.pause();
            axWindowsMediaPlayer6.Visible = false;
            pictureBoxSalirPelículaTodasMisPlaylist.Visible = false;
            buttonNextPlaylistPelículas.Visible = false;
            buttonReproducirPlaylistCanciones.Visible = true;
        }

        private void buttonEliminarPlaylist_Click(object sender, EventArgs e)
        {
            if (labelUsuarioTodaMisPlaylist.Text == textBoxUsernamePerfil.Text)
            {
                List<Playlist> lista1 = new List<Playlist>();
                lista1 = Archivos.playlists_Canciones;
                List<Playlist> lista2 = new List<Playlist>();
                lista1 = Archivos.playlists_Películas;
                string nombre = listViewTodasMisPlaylists.SelectedItems[0].SubItems[0].Text;
                Playlist EliminarPlaylist = new Playlist();
                Usuario usuario = new Usuario();
                foreach (Playlist playlist in lista1)
                {
                    if (playlist.Nombre == nombre)
                    {
                        if (playlist.Tipo_playlist == "De Canciones")
                        {
                            foreach (Usuario usuario1 in Archivos.Usuarios)
                            {
                                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                                {
                                    usuario = usuario1;
                                    EliminarPlaylist = playlist;
                                }
                            }
                        }
                        if (playlist.Tipo_playlist == "De Películas")
                        {
                            foreach (Usuario usuario1 in Archivos.Usuarios)
                            {
                                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                                {
                                    usuario = usuario1;
                                    EliminarPlaylist = playlist;
                                }
                            }
                        }
                    }
                }
                if (usuario.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    usuario.Playlists.Remove(nombre);
                    Archivos.playlists_Películas.Remove(EliminarPlaylist);
                    Archivos.playlists_Canciones.Remove(EliminarPlaylist);
                    MessageBox.Show("PlayList eliminada correctamente");
                    listViewTodasMisPlaylists.Clear();
                    ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                    foreach (String película in usuario.Playlists)
                    {
                        listViewTodasMisPlaylists.Items.Add(new ListViewItem(película, Playlists));

                    }
                    listViewTodasMisPlaylists.Groups.Add(Playlists);
                    buttonReproducirPlaylistCanciones.Visible = false;
                    buttonEliminarPlaylist.Visible = false;
                    listViewPelículasDeMisPlaylist.Visible = false;
                    listViewCancionesDeMisPlaylist.Visible = false;
                    labelCancionesTodasMisPlaylist.Visible = false;
                    labelPelículasTodasMisPlaylist.Visible = false;
                    Serializacion();
                }
            }
            else
            {
                MessageBox.Show("Solo el creador de la playlist puede eliminarla");
            }
        }

        private void panelCrearPlaylist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTuBiblioteca_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTuBiblioteca_Click(object sender, EventArgs e)
        {
            panelTuBiblioteca.Visible = true;
            if (panelSocial.Visible == true)
            {
                panelSocial.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelTuBiblioteca.Visible = false;
        }

        private void buttonSocial_Click(object sender, EventArgs e)
        {
            panelSocial.Visible = true;
            if (panelTuBiblioteca.Visible == true)
            {
                panelTuBiblioteca.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelSocial.Visible = false;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoMisPlaylists_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario1 in Archivos.Usuarios)
            {
                if (usuario1.Nombre_usuario == textBoxUsernamePerfil.Text)
                {
                    if (usuario1.Tipo_usuario == "Premium" || usuario1.Nombre_usuario == "admin")
                    {
                        labelUsuarioPlaylist.Text = textBoxUsernamePerfil.Text;
                        cuenta = 1;
                        cuenta2 = 1;
                        stackPanels.Add(panels["MisPlaylistPanel"]);
                        ShowLastPanel();
                        buttonNextPlaylistPelícula.Visible = false;
                        axWindowsMediaPlayer4.Visible = false;
                        axWindowsMediaPlayer3.Visible = false;
                        foreach (Usuario usuario in Archivos.Usuarios)
                        {
                            if (usuario.Nombre_usuario == labelUsuarioPlaylist.Text)
                            {
                                listViewVerMisPlaylistCanción.Clear();
                                listViewVerMisPlaylistPelícula.Clear();
                                VerPlaylists(usuario.PlaylistC);
                                ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
                                foreach (String película in usuario.PlaylistV)
                                {
                                    listViewVerMisPlaylistPelícula.Items.Add(new ListViewItem(película, Playlists));

                                }
                                listViewVerMisPlaylistPelícula.Groups.Add(Playlists);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo los usuarios Premium pueden acceder a esta función");
                    }
                }
            }
        }
        private void VerPlaylists(List<String> playlists)
        {
            ListViewGroup Playlists = new ListViewGroup("Playlists", HorizontalAlignment.Left);
            foreach (String canción in playlists)
            {
                listViewVerMisPlaylistCanción.Items.Add(new ListViewItem(canción, Playlists));

            }
            listViewVerMisPlaylistCanción.Groups.Add(Playlists);
        }

        private void buttonAgregarArchivoPelicula_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo3 = openFileDialog.SafeFileNames;
                Ruta3 = openFileDialog.FileNames;

                for (int i = 0; i < archivo3.Length; i++)
                {
                    ruta3 = Ruta3[i];
                    labelRutaPelicula.Text = ruta3;
                    labelRutaPelicula.Visible = true;
                }
            }
        }

        private void buttonVolverDeMisPlaylist_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
            axWindowsMediaPlayer3.Ctlcontrols.pause();
            axWindowsMediaPlayer4.Ctlcontrols.pause();
        }

        private void buttonVolverAgregarPelicula_Click(object sender, EventArgs e)
        {
            stackPanels.Add(panels["MenuPanel"]);
            ShowLastPanel();
        }

        private void buttonAgregarImagenPelicula_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo2 = openFileDialog.SafeFileNames;
                Ruta2 = openFileDialog.FileNames;

                for (int i = 0; i < archivo2.Length; i++)
                {
                    ruta2 = Ruta2[i];
                    labelRutaImagenPelicula.Text = ruta2;
                    labelRutaImagenPelicula.Visible = true;
                }
            }
        }

        private void pictureBoxSalirReproducirPelicula_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            buttonVolverDeVerPelícula.Visible = true;
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Visible = false;
            pictureBoxSalirReproducirPelicula.Visible = false;
            PelículaSeleccionada.Visible = false;
        }

        private void btnAgregarImagenACancion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo1 = openFileDialog.SafeFileNames;
                Ruta1 = openFileDialog.FileNames;

                for (int i = 0; i < archivo1.Length; i++)
                {
                    ruta1 = Ruta1[i];
                    labelRutaImagenCancion.Text = ruta1;
                    labelRutaImagenCancion.Visible = true;
                }
            }
        }

        private void btnBuscarArchivoCancion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo = openFileDialog.SafeFileNames;
                Ruta = openFileDialog.FileNames;

                for (int i = 0; i < archivo.Length; i++)
                {
                    ruta = Ruta[i];
                    labelRutaCancion.Text = Ruta[i];
                    labelRutaCancion.Visible = true;
                }
            }
        }
    }
}

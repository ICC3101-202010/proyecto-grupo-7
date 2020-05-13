using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entrega2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Spotiflix");
            App app = new App();
            MailSender mailSender = new MailSender();
            SMSSender smsSender = new SMSSender();
            Usuario usuario = new Usuario();
            mailSender.EmailSent += usuario.OnEmailSent;
            usuario.EmailVerified += app.OnEmailVerified;
            app.Registered += mailSender.OnRegistered;
            app.PasswordChanged += mailSender.OnPasswordChanged;
            app.PasswordChanged += smsSender.OnPasswordChanged;
            Console.WriteLine("1) Iniciar Sesión");
            Console.WriteLine("   Modificar su cuenta");
            Console.WriteLine("   Registrarse");
            Console.WriteLine("");
            Console.WriteLine("2) Salir de Spotiflix");
            string input_usuario = Console.ReadLine();
            int i = 1;
            while (i !=0)
            if (input_usuario == "1")
            {
                int índice = 1;
                List<string> registrado = new List<string>();
                while (índice != 0)
                {
                    Console.WriteLine("1) Iniciar Sesión");
                    Console.WriteLine("2) Suscribirse de usuario gratis a premium");
                    Console.WriteLine("3) Cambiar la contraseña de mi cuenta");
                    Console.WriteLine("4) Registarse");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        Console.Write("Nombre de usuario: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Contraseña: ");
                        string contraseña = Console.ReadLine();
                        string login = Archivos.LogIn(nombre, contraseña);
                        if (login == null)
                        {
                            foreach (Usuario usuario1 in Archivos.usuarios)
                            {
                                if (usuario1.Nombre_usuario == nombre && usuario1.Contraseña == contraseña)
                                {
                                    registrado.Add(usuario1.Nombre_usuario);
                                    registrado.Add(usuario1.Contraseña);
                                    índice = 0;
                                }
                            }
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Usuario o Contraseña incorrectos");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }
                    else if (option == "4")
                    {
                        Console.Clear();
                        app.Register();
                        usuario.OnEmailSent(new object(), new EventArgs());
                        Save(usuario);
                    }
                    else if (option == "3")
                    {
                        Console.Clear();
                        app.ChangePassword();
                    }
                    else if (option == "2")
                    {
                        Console.Clear();
                        app.hacerse_premium();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Criterio ingresado no válido");
                    }
                }
                int u = 1;
                while (u != 0)
                {
                    Usuario usuario1 = new Usuario();
                    foreach (Usuario usuario2 in Archivos.usuarios)
                    {
                        if (usuario1.Nombre_usuario == registrado[0] && usuario2.Contraseña == registrado[1])
                        {
                            usuario1 = usuario2;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Menú Spotiflix");
                    Console.WriteLine("1) Ver todas las canciones");
                    Console.WriteLine("2) Ver todas las películas");
                    Console.WriteLine("3) Buscar");
                    Console.WriteLine("4) Mis Playlists");
                    Console.WriteLine("5) Crear playlists");
                    Console.WriteLine("6) Salir de Spotiflix");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        app.Ver_Canciones(usuario1, app);
                    }
                    else if (option == "2")
                    {
                        app.Ver_Películas(usuario1, app);
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("¿Qué desea buscar?");
                        Console.WriteLine("1) Película");
                        Console.WriteLine("2) Canción");
                        Console.WriteLine("3) Playlist");
                        string input = Console.ReadLine();
                        Búsqueda búsqueda = new Búsqueda();
                        if (input == "1")
                        {
                             búsqueda.buscar_pelicula_por_tipo();
                        }
                        else if (input == "2")
                        {
                             búsqueda.buscar_cancion_por_tipo();
                        }
                        else if (input == "3")
                        {
                             búsqueda.buscar_playlist_por_tipo();
                        }
                        else
                        {
                             Console.WriteLine("Criterio ingresado no válido");
                        }
                    }
                     else if (option == "4")
                    {
                        app.Ver_opciones_playlist(usuario, app);
                    }
                    else if (option == "5")
                    {
                        if (usuario.Tipo_usuario == "Premium")
                        {
                                usuario.CrearPlaylist();
                        }
                        else if(usuario.Tipo_usuario == "Gratis")
                        {
                                Console.WriteLine("Usuario gratis no permite crear listas, para poder hacerlo debe suscribirse");
                        }
                    }
                    else if (option == "6")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Criterio ingresado no válido");
                    }
                    Thread.Sleep(1000);
                }
            }
            else if (input_usuario == "2")
            {
                i = 0;
            }
            else
            {
                Console.WriteLine("Criterio ingresado no válido");
            }

            static private void Save(List<Usuario> people)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, people);
                stream.Close();
            }
        }

        
    }
}


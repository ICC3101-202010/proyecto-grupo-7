using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Entrega2
{
    public class App
    {
        public List<Canción> top_Canciones()
        {
            List<Canción> ranking = new List<Canción>();
            List<Canción> canciones = new List<Canción>();
            foreach (Canción canción in Archivos.cancionesApp)
            {
                canciones.Add(canción);
            }
            var canciones_ordenadas = canciones.OrderByDescending(canción => canción.Rating).ToList();
            for (int i = 0; i < 10; i++)
            {
                ranking.Add(canciones_ordenadas[i]);
            }
            return ranking;
        }

        public void AddQueue(Canción canciones)
        {
            List<Canción> cola = new List<Canción>();
            cola.Add(canciones);
        }
        public List<Película> top_Películas()
        {
            List<Película> ranking = new List<Película>();
            List<Película> películas = new List<Película>();
            foreach (Película película in Archivos.películasApp)
            {
                películas.Add(película);
            }
            var películas_ordenadas = películas.OrderByDescending(película => película.Rating).ToList();
            for (int i = 0; i < 10; i++)
            {
                ranking.Add(películas_ordenadas[i]);
            }
            return ranking;

        }

        public delegate void RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler Registered;
       
        protected virtual void OnRegistered(string username, string password, string verificationlink, string email)
        {
            // Verifica si hay alguien suscrito al evento
            if (Registered != null)
            {
                // Engatilla el evento
                Registered(this, new RegisterEventArgs() { VerificationLink = verificationlink, Password = password, Username = username, Email = email });
            }
        }

        // Paso 1: Creamos el delegate para el evento del cambio de contrasena
        public delegate void ChangePasswordEventHandler(object source, ChangePasswordEventArgs args);
        // Paso 2: Creamos el evento que se engatilla cuando se cambia la contrasena
        public event ChangePasswordEventHandler PasswordChanged;
        // Paso 3: Publicamos el evento. Notar que cuando se quiere engatillar el evento, se llama OnPasswordChanged(). 
        // Por definicion, debe ser protected virtual. Los parametros que recibe son los necesarios para crear una instancia
        // de la clase ChangePasswordEventArgs
        protected virtual void OnPasswordChanged(string username, string email)
        {
            if (PasswordChanged != null)
            {
                PasswordChanged(this, new ChangePasswordEventArgs() { Username = username, Email = email});
            }
        }
        public bool Register()
        {
            // Pedimos todos los datos necesarios
            Console.Write("Bienvenido! Ingrese sus datos de registro\nUsuario: ");
            string usr = Console.ReadLine();
            Console.Write("Correo: ");
            string email = Console.ReadLine();
            Console.Write("Contraseña: ");
            string psswd = Console.ReadLine();

            Console.WriteLine("¿Qué tipo de usuario quieres crear?");
            Console.WriteLine("1) Gratis");
            Console.WriteLine("2) Premium");
            string input = Console.ReadLine();
            string tipo_usuario;
            if (input == "1")
            {
                tipo_usuario = "Gratis";
            }
            else if (input == "2")
            {
                tipo_usuario = "Premium";
            }
            else
            {
                Console.WriteLine("El criterio ingresado no es válido");
                return false;
            }

            // Genera el link de verificacion para el usuario
            string verificationLink = GenerateLink(usr);
            // Intenta agregar el usuario a la bdd. Si retorna null, se registro correctamente,
            // sino, retorna un string de error, que es el que se muestra al usuario
            string result = Archivos.AddUser(new List<string>()
                {usr, email, psswd, verificationLink, Convert.ToString(DateTime.Now), tipo_usuario});
            if (result == null)
            {
                // Disparamos el evento
               
                OnRegistered(usr, psswd, verificationlink: verificationLink, email: email);
                OnEmailSent(new Object(), new EventArgs());
                return true;
            }
            else
            {
                // Mostramos el error
                Console.WriteLine("[!] ERROR: " + result + "\n");
                return false;
            }
        }

        // Realiza el cambio de contrasena
        public void ChangePassword()
        {
            // Pedimos todos los datos necesarios
            Console.WriteLine("Ingresa tu nombre de usuario: ");
            string usr = Console.ReadLine();
            Console.WriteLine("Ingresa tu contrasena: ");
            string pswd = Console.ReadLine();
            // Intenta realizar el login, si retorna null se logeo correctamente,
            // sino, retorna un string de error que se le muestra al usuario
            string result = Archivos.LogIn(usr, pswd);
            if (result == null)
            {
                // Pedimos y cambiamos la contrasena
                Console.Write("Ingrese la nueva contrasena: ");
                string newPsswd = Console.ReadLine();
                Archivos.ChangePassword(usr, newPsswd);
                // Obtenemos los datos del usuario que se logueo y disparamos el evento con los datos necesarios
                List<string> data = Archivos.GetData(usr);
                OnPasswordChanged(data[0], data[1]);
            }
            else
            {
                // Mostramos el error
                Console.WriteLine("[!] ERROR: " + result + "\n");
            }
        }

        // Metodo que genera un link de verificacion, dado un usuario
        private string GenerateLink(string usr)
        {
            Random rnd = new Random();
            string result = "";
            for (int ctr = 0; ctr <= 99; ctr++)
            {
                char rndom = (char)rnd.Next(33, 126);
                result += rndom;
            }
            return "http://spotiflix.com/verificar-correo.php?=" + usr + "_" + result;
        }
        public void OnEmailVerified(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Se verificó correctamente el correo");
            Thread.Sleep(2000);
        }
        public void OnEmailSent(object source, EventArgs args)
        {

        }
        public void Rankear(string nombre, List<int> rate, int pelicula_o_cancion)
        {
            if (pelicula_o_cancion == 2)
            {
                foreach (Canción canción in Archivos.cancionesApp)
                {
                    if (nombre == canción.titulo)
                    {
                        int sum = rate.Sum();
                        int value = (sum / rate.Count());
                        canción.Avg_calificacion = value;
                    }
                }
            }
            else if (pelicula_o_cancion == 1)
            {
                foreach (Película película in Archivos.películasApp)
                {
                    if (nombre == película.titulo)
                    {
                        int sum = rate.Sum();
                        int valor = (sum / rate.Count());
                        película.Avg_Ranking = valor;
                    }
                }
            }
           
            else
            {
                Console.WriteLine("Criterio ingresado no válido");
            }
        }




    }
}
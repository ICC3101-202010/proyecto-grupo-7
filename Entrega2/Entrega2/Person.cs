using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entrega2
{
    public class Person
    {
        protected string Nombre;
        protected string Apellido;
        protected string Sexo;
        protected int Age;
        protected string Nacionalidad;
        public Person(string nombre, string apellido, string sexo, int age, string nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Age = age;
            this.Nacionalidad = nacionalidad;
        }
    }

}

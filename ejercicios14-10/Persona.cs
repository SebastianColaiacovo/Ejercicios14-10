using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Persona
    {
        protected int idPersona { get; set; }
        protected string nombre { get; set; }
        protected int edad { get; set; }

        public Persona()
        {
        }

        public Persona(int idPersona, string nombre, int edad)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.edad = edad;
        }
        public virtual void mostrarInfo()
        {
            Console.WriteLine($"La persona tiene ID: {this.idPersona}, Nombre: {this.nombre}, Edad: {this.edad}");
        }
    }
}

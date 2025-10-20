using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class PersonaAlumno : Persona
    {
        protected int legajo { get; set; }
        protected double promedio { get; set; }

        public PersonaAlumno()
        {
        }

        public PersonaAlumno(int idPersona, string nombre, int edad, int legajo, double promedio)
            : base(idPersona, nombre, edad)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"Legajo: {this.legajo}, Promedio: {this.promedio}");
        }

    }
}

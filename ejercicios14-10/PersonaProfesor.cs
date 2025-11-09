using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class PersonaProfesor : Persona
    {
        protected string materia { get; set; }
        protected double sueldo { get; set; }

        public string Getmateria() => materia;
        public double Getsueldo() => sueldo;

        public void Setmateria(string Materia) => materia = Materia;
        public void Setsueldo(double Sueldo) => sueldo = Sueldo;


        public PersonaProfesor()
        {
        }

        public PersonaProfesor(int idPersona, string nombre, int edad, string materia, double sueldo)
            :base(idPersona, nombre, edad)
        {
            this.materia = materia;
            this.sueldo = sueldo;
        }
        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"Materia: {this.materia}, Sueldo: {this.sueldo}");
        }
    }
}

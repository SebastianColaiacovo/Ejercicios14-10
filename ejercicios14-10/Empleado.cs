using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Empleado
    {

        protected int IdEmpleado { get; set; }
        protected string nombre { get; set; }
        protected string apellido { get; set; }
        protected double sueldoBase { get; set; } = 10000000.00;

        public Empleado()
        {
        }

        public Empleado(int IdEmpleado, string nombre, string apellido)
        {
            this.IdEmpleado = IdEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            
        }

        public virtual double calcularSalario()
        {
            return this.sueldoBase;
        }
        public virtual void mostrarInfo()
        {
            Console.WriteLine($"El empleado tiene ID: {this.IdEmpleado}, Nombre: {this.nombre}, Apellido: {this.apellido}, Salario Base: {this.calcularSalario}");
        }
    }
}

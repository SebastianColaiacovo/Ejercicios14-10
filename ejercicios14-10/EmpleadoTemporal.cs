using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class EmpleadoTemporal : Empleado
    {
        protected int horasTrabajadas { get; set; }
        protected double valorHora { get; set; } = 10000.00;


        public int GethorasTrabajadas() => horasTrabajadas;
        public void SethorasTrabajadas(int HorasTrabajadas) => horasTrabajadas = HorasTrabajadas;


        public EmpleadoTemporal()
        {
        }

        public EmpleadoTemporal(int IdEmpleado, string nombre, string apellido, int horasTrabajadas)
            : base(IdEmpleado, nombre, apellido)
        {
            this.horasTrabajadas = horasTrabajadas;
            
        }

        public override double calcularSalario()
        {
            return horasTrabajadas * valorHora;
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"El empleado temporal tiene ID: {this.IdEmpleado}, Nombre: {this.nombre}, Apellido: {this.apellido}, sueldo total: {this.calcularSalario()} y ha trabajado {this.horasTrabajadas} horas");
        }

    }
}

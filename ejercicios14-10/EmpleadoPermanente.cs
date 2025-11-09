using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejercicios14_10
{
    internal class EmpleadoPermanente : Empleado
    { 
        protected int anioAntiguedad { get; set; }
        protected double extra { get; set; } = 40000.00;

        public int GetanioAntiguedad() => anioAntiguedad;
        public void SetanioAntiguedad(int AnioAntiguedad) => anioAntiguedad = AnioAntiguedad;

        public EmpleadoPermanente()
        {
        }

        public EmpleadoPermanente(int IdEmpleado, string nombre, string apellido, int anioAntiguedad)
            : base(IdEmpleado, nombre, apellido)
        {
            this.anioAntiguedad = anioAntiguedad;
            
        }

        public override double calcularSalario()
        {
            return sueldoBase + (anioAntiguedad * extra);
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"El empleado permanente tiene ID: {this.IdEmpleado}, Nombre: {this.nombre}, Apellido: {this.apellido}, sueldo total: {this.calcularSalario()} y tiene {this.anioAntiguedad} años de antiguedad");
        }

    }
}

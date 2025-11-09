using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Auto : Vehiculo
    {
        protected int CantPuertas { get; set; }

        public int GetCantPuertas() => CantPuertas;
        public void SetCantPuertas(int CANTPuertas) => CantPuertas = CANTPuertas;

        


        public Auto()
        {
        }

        public Auto(int  IdVehiculo, string marca, string modelo, int anio, int cantPuertas) : base(IdVehiculo, marca, modelo, anio)
        {
            this.CantPuertas = cantPuertas;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();

            Console.WriteLine($"El auto tiene {this.CantPuertas} puertas");
        }
    }
}

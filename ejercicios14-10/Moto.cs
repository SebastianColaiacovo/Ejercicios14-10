using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Moto : Vehiculo
    {

        protected int cilindrada { get; set; }

        public int GetCilindrada() => cilindrada;
        public void SetCilindrada(int Cilindrada) => cilindrada = Cilindrada;
        public Moto()
        {
        }

        public Moto(int IdVehiculo, string marca, string modelo, int anio, int cilindrada) : base(IdVehiculo, marca, modelo, anio)
        {
            this.cilindrada = cilindrada;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo(); 
            Console.WriteLine($"La moto tiene una cilindrada de {this.cilindrada}");
        }
    }
}

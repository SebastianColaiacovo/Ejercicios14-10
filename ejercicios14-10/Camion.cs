using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Camion : Vehiculo
    {
        protected int capacidadCarga { get; set; }

        public int GetcapacidadCarga() => capacidadCarga;
        public void SetcapacidadCarga(int CapacidadCarga) => capacidadCarga = CapacidadCarga;

        public Camion()
        {
        }

        public Camion(int IdVehiculo, string marca, string modelo, int anio, int capacidadCarga) : base(IdVehiculo, marca, modelo, anio)
        {
            this.capacidadCarga = capacidadCarga;
        }

        public override void mostrarInfo()
        {
          base.mostrarInfo();
            Console.WriteLine($"El camion tiene una capacidad de carga de {this.capacidadCarga} toneladas");
        }
    }
}

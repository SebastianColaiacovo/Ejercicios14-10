using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Vehiculo
    {

        protected int IdVehiculo { get; set; }
        protected string marca { get; set; }
        protected string modelo { get; set; }
        protected int anio { get; set; }

        public Vehiculo()
        {
           
        }
        public Vehiculo(int IdVehiculo, string marca, string modelo, int anio)
        {
            this.IdVehiculo = IdVehiculo;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        public virtual void mostrarInfo()
        {
            Console.WriteLine($"EL vehiculo tiene ID: {this.IdVehiculo}, Marca: {this.marca}, Modelo: {this.modelo}, Año: {this.anio}");
        }

    }
}

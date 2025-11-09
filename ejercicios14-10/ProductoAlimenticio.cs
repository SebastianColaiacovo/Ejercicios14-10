using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class ProductoAlimenticio : Producto
    {
        protected DateTime fechaCaducidad { get; set; }

        public DateTime GetfechaCaducidad() => fechaCaducidad;

        public void SetId(DateTime FechaCaducidad) => fechaCaducidad = FechaCaducidad;


        public ProductoAlimenticio()
        {
        }

        public ProductoAlimenticio(int idProducto, string nombreProducto, double precioBase, DateTime fechaCaducidad)
            : base(idProducto, nombreProducto, precioBase)
        {
            this.fechaCaducidad = fechaCaducidad;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"Fecha de caducidad: {this.fechaCaducidad} ");
        }

    }
}

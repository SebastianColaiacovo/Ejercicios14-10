using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class ProductoElectronico : Producto
    {
        protected int MesesDeGarantia { get; set; }

        public ProductoElectronico()
        {
        }

        public ProductoElectronico(int idProducto, string nombreProducto, double precioBase, int MesesDeGarantia)
            : base(idProducto, nombreProducto, precioBase)
        {
            this.MesesDeGarantia = MesesDeGarantia;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine($"Meses de garantia: {this.MesesDeGarantia} ");
        }
    }
}

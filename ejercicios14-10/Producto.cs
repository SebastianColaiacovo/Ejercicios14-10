using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Producto
    {
        protected int idProducto { get; set; }
        protected string nombreProducto { get; set; }
        protected double precioBase { get; set; }

        public Producto()
        {
        }

        public Producto(int idProducto, string nombreProducto, double precioBase)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precioBase = precioBase;
        }

        public virtual void mostrarInfo()
        {
            Console.WriteLine($"El producto tiene ID: {this.idProducto}, Nombre: {this.nombreProducto}, Precio Base: {this.precioBase}");
        }   
    }
}

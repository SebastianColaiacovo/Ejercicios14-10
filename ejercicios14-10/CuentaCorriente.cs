using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class CuentaCorriente : Cuenta
    {
        private double limiteDescubierto;

        public CuentaCorriente(int numeroCuenta, string titular, double limiteDescubierto)
            : base(numeroCuenta, titular)
        {
            this.limiteDescubierto = limiteDescubierto;
        }

        public override void extraccion(double monto)
        {
            if (monto > 0 && saldo - monto >= -limiteDescubierto)
            {
                saldo -= monto;
                Console.WriteLine($"Extraccion realizada el nuevo saldo es: ${saldo}");
            }
            else
            {
                Console.WriteLine("No se puede realizar la extraccion, supera el limite de descubierto");
            }
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"Cuenta Corriente N°: {numeroCuenta}, Titular: {titular}, Saldo: ${saldo}, Limite descubierto: ${limiteDescubierto}");
        }
    }
}

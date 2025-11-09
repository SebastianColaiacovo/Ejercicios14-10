using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class Cuenta
    {
        protected int numeroCuenta { get; set; }
        protected string titular { get; set; }
        protected double saldo { get; set; } = 0.00;

        public int GetNumeroCuenta() => numeroCuenta;
        public string GetTitular() => titular;
        public double GetSaldo() => saldo;
        public Cuenta()
        {
        }
        public Cuenta(int numeroCuenta, string titular)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            
        }

        public virtual void depositar(double monto)
        {
            if (monto > 0)
            {
                this.saldo += monto;
                Console.WriteLine($"Deposito realizado tu nuevo saldo es: ${saldo}");
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser mayor a cero");
            }
        }

        public virtual void extraccion(double monto)
        {
            if (monto > 0 && monto <= this.saldo)
            {
                this.saldo -= monto;
                Console.WriteLine($"Extraccion realizada  tu nuevo saldo es : ${saldo}");
            }
            else
            {
                Console.WriteLine("El monto a retirar debe ser mayor a cero y no puede exceder el saldo disponible");
            }
        }

        public virtual void actualizarSaldo()
        { }

        public virtual void mostrarInfo()
        {
            Console.WriteLine($"Cuenta N°: {this.numeroCuenta}, Titular: {this.titular}, Saldo: {this.saldo}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios14_10
{
    internal class CajaAhorro : Cuenta
    {
        protected double tasaInteres ;

        public double GetTasaInteres() => tasaInteres;
        public void SetTasaInteres(double tasa) => tasaInteres = tasa;


        public CajaAhorro(int numeroCuenta, string titular, double tasaInteres)
            : base(numeroCuenta, titular)
        {
            this.tasaInteres = tasaInteres;
        }

        public override void actualizarSaldo()
        {
            double interes = saldo * (tasaInteres / 100);
            saldo += interes;
            Console.WriteLine($"Interes aplicado: ${interes}, el  nuevo saldo es: ${saldo}");
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"[Caja de Ahorro] N°: {numeroCuenta}, Titular: {titular}, Saldo: ${saldo}, Tasa: {tasaInteres}%");
        }
    }
}

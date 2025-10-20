namespace ejercicios14_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Auto(1, "Toyota", "Corolla", 2020, 4));
            vehiculos.Add(new Moto(2, "kawasaki", "ninja", 2025, 2));
            vehiculos.Add(new Camion(3, "Volvo", "FH16", 2019, 20));

        }
    }
}

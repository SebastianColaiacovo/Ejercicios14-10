using System.ComponentModel;

namespace ejercicios14_10
{
    internal class Program
    {
        static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        static List<Empleado> listaEmpleados = new List<Empleado>();
        static List<Producto> listaProductos = new List<Producto>();
        static List<Persona> listaPersonas = new List<Persona>();
        static List<Cuenta> listaCuentas = new List<Cuenta>();
        static void Main(string[] args)
        {

            /*      EJERCICIO 1 
            AgregarVehiculo(new Auto(1, "Toyota", "Corolla", 2020, 4));
            AgregarVehiculo(new Moto(2, "kawasaki", "ninja", 2025, 2));
            AgregarVehiculo(new Camion(3, "Volvo", "FH16", 2019, 20));


            ListarVehiculos();

            ModificarVehiculo(2, "Yamaha", "R1", 2023,2);

            EliminarVehiculo(1);

            ListarVehiculos();

            */

            /* EJERCICIO 2 
            AgregarEmpleado(new EmpleadoPermanente(1, "Juan", "Pérez", 3));
            AgregarEmpleado(new EmpleadoTemporal(2, "Ana", "Gómez", 750));
            AgregarEmpleado(new EmpleadoPermanente(3, "Carlos", "López", 10));

            Console.WriteLine("=== LISTADO INICIAL ===");
            ListarEmpleados();

            ModificarEmpleado(2, "Ana María", "Gómez", 90000); 
            Console.WriteLine("\n=== TRAS MODIFICAR ===");
            ListarEmpleados();

            EliminarEmpleado(1); 
            Console.WriteLine("\n=== LISTADO FINAL ===");
            ListarEmpleados();
            */

            /* EJERCICIO 3 
            
            AgregarProducto(new ProductoAlimenticio(1, "Leche", 1500, new DateTime(2025, 12, 10)));
            AgregarProducto(new ProductoElectronico(2, "Auriculares", 25000, 12));
            AgregarProducto(new ProductoAlimenticio(3, "Pan", 800, new DateTime(2025, 10, 30)));

            Console.WriteLine("=== LISTADO INICIAL ===");
            ListarProductos();

            
            ModificarProducto(2, "Auriculares Bluetooth", 27000);

            Console.WriteLine("\n=== TRAS MODIFICAR ===");
            ListarProductos();

            
            EliminarProducto(3);

            Console.WriteLine("\n=== LISTADO FINAL ===");
            ListarProductos();
            */


            /* EJERCICIO 4 
            
            AgregarPersona(new PersonaAlumno(1, "Lucia Fernandez", 20, 1050, 8.5));
            AgregarPersona(new PersonaProfesor(2, "Carlos Lopez", 45, "Matematica", 250000));
            AgregarPersona(new PersonaAlumno(3, "Martin Diaz", 22, 1103, 7.9));
            AgregarPersona(new PersonaProfesor(4, "Ana Gomez", 38, "Historia", 220000));

            Console.WriteLine("=== LISTADO INICIAL ===");
            ListarPersonas();


            ModificarPersona(3, "Martin Diaz", 23);
            Console.WriteLine("\n=== TRAS MODIFICAR ===");
            ListarPersonas();


            EliminarPersona(1);
            Console.WriteLine("\n=== LISTADO FINAL ===");
            ListarPersonas();
            */

            AgregarCuenta(new CajaAhorro(1001, "Juan Perez", 5.00));
            AgregarCuenta(new CuentaCorriente(2001, "Maria Lopez", 20000));
            AgregarCuenta(new CajaAhorro(1002, "Ana Torres", 3));

            Console.WriteLine("=== LISTADO INICIAL ===");
            ListarCuentas();

            
            listaCuentas[0].depositar(40000);
            listaCuentas[1].depositar(15000);

            
            listaCuentas[0].extraccion(50000);
            listaCuentas[1].extraccion(65000); 

            
            Console.WriteLine("\n=== ACTUALIZANDO SALDOS ===");
            foreach (var c in listaCuentas)
                c.actualizarSaldo();

            
            Console.WriteLine("\n=== LISTADO FINAL ===");
            ListarCuentas();

        }

        // EJERCICIO 1 
        static void AgregarVehiculo(Vehiculo v)
        {
            listaVehiculos.Add(v);
        }

        static void ListarVehiculos()
        {
            foreach (var v in listaVehiculos)
                v.mostrarInfo();
        }

        static void ModificarVehiculo(int id, string nuevaMarca, string nuevoModelo, int nuevoAnio, int x)
        {
            var vehiculo = listaVehiculos.Find(v => v.GetIdVehiculo() == id);
            if (vehiculo != null)
            {
                vehiculo.SetMarca(nuevaMarca);
                vehiculo.SetModelo(nuevoModelo);
                vehiculo.SetAnio(nuevoAnio);

                if (vehiculo is Auto auto)
                {

                    auto.SetCantPuertas(x);
                }
                else if (vehiculo is Moto moto)
                {

                    moto.SetCilindrada(x);
                }
                else if (vehiculo is Camion camion)
                {

                    camion.SetcapacidadCarga(x);
                }

                Console.WriteLine($"Vehiculo ID {id} modificado correctamente.");
            }
            else
            {
                Console.WriteLine($"No se encontro el vehiculo con ID {id}");
            }
        }

        static void EliminarVehiculo(int id)
        {
            var vehiculo = listaVehiculos.Find(v => v.GetIdVehiculo() == id);
            if (vehiculo != null)
            {
                listaVehiculos.Remove(vehiculo);
                Console.WriteLine($"Vehiculo ID {id} eliminado.");
            }
            else
            {
                Console.WriteLine($"No se encontro el vehiculo con ID {id}");
            }
        }

        // EJERCICIO 2
        static void AgregarEmpleado(Empleado e)
        {
            listaEmpleados.Add(e);
        }

        static void ListarEmpleados()
        {
            foreach (var e in listaEmpleados)
                e.mostrarInfo();
        }

        static void ModificarEmpleado(int id, string nuevoNombre, string nuevoApellido, double nuevoSueldo)
        {
            var empleado = listaEmpleados.Find(e => e.GetId() == id);
            if (empleado != null)
            {
                empleado.SetNombre(nuevoNombre);
                empleado.SetApellido(nuevoApellido);
                empleado.SetSueldoBase(nuevoSueldo);
                Console.WriteLine($"Empleado ID {id} modificado correctamente");
            }
            else
            {
                Console.WriteLine($"No se encontro el empleado con ID {id}");
            }
        }

        static void EliminarEmpleado(int id)
        {
            var empleado = listaEmpleados.Find(e => e.GetId() == id);
            if (empleado != null)
            {
                listaEmpleados.Remove(empleado);
                Console.WriteLine($"Empleado ID {id} eliminado");
            }
            else
            {
                Console.WriteLine($"No se encontro el empleado con ID {id}");
            }
        }


        // EJERCICIO 3

        static void AgregarProducto(Producto p)
        {
            listaProductos.Add(p);
        }

        static void ListarProductos()
        {
            foreach (var p in listaProductos)
                p.mostrarInfo();
        }

        static void ModificarProducto(int id, string nuevoNombre, double nuevoPrecio)
        {
            var producto = listaProductos.Find(p => p.GetId() == id);
            if (producto != null)
            {
                producto.SetNombre(nuevoNombre);
                producto.SetPrecioBase(nuevoPrecio);
                Console.WriteLine($"Producto ID {id} modificado correctamente");
            }
            else
            {
                Console.WriteLine($"No se encontro el producto con ID {id}");
            }
        }

        static void EliminarProducto(int id)
        {
            var producto = listaProductos.Find(p => p.GetId() == id);
            if (producto != null)
            {
                listaProductos.Remove(producto);
                Console.WriteLine($"Producto ID {id} eliminado");
            }
            else
            {
                Console.WriteLine($"No se encontro el producto con ID {id}");
            }
        }

        // EJERCICIO 4


        static void AgregarPersona(Persona p)
        {
            listaPersonas.Add(p);
        }

        static void ListarPersonas()
        {
            foreach (var p in listaPersonas)
                p.mostrarInfo();
        }

        static void ModificarPersona(int id, string nuevoNombre, int nuevaEdad)
        {
            var persona = listaPersonas.Find(p => p.GetId() == id);
            if (persona != null)
            {
                persona.SetNombre(nuevoNombre);
                persona.SetEdad(nuevaEdad);
                Console.WriteLine($"Persona ID {id} modificada correctamente");
            }
            else
            {
                Console.WriteLine($"No se encontro la persona con ID {id}");
            }
        }

        static void EliminarPersona(int id)
        {
            var persona = listaPersonas.Find(p => p.GetId() == id);
            if (persona != null)
            {
                listaPersonas.Remove(persona);
                Console.WriteLine($"Persona ID {id} eliminada");
            }
            else
            {
                Console.WriteLine($"No se encontro la persona con ID {id}");
            }
        }

        // EJERCICIO 5

        static void AgregarCuenta(Cuenta c)
        {
            listaCuentas.Add(c);
        }

        static void ListarCuentas()
        {
            foreach (var c in listaCuentas)
                c.mostrarInfo();
        }

        static void EliminarCuenta(int numeroCuenta)
        {
            var cuenta = listaCuentas.Find(c => c.GetNumeroCuenta() == numeroCuenta);
            if (cuenta != null)
            {
                listaCuentas.Remove(cuenta);
                Console.WriteLine($"Cuenta N° {numeroCuenta} eliminada.");
            }
            else
            {
                Console.WriteLine($"No se encontró la cuenta N° {numeroCuenta}");
            }
        }
    }
}

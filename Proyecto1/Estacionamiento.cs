using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Estacionamiento
    {
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        List<Cliente>listaClientes= new List<Cliente>();
        public int EspaciosDisponibles { get; set; }

        public Estacionamiento(int espaciosDisponibles)
        {
            EspaciosDisponibles = espaciosDisponibles;
        }
        public static void RegistrarEstacionamiento ()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTIÓN Y COBRO DE ESTACIONAMIENTO");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Para registrar el estacionamiento, indique la cantidad de espacios que posee.");
            Console.Write("Cantidad de espacios:");
            int espaciosDisponibles = Convert.ToInt32(Console.ReadLine());
            Estacionamiento estacionamiento = new Estacionamiento(espaciosDisponibles);
            Console.WriteLine("Se ha registrado el estacionamiento.");
            Console.ReadKey();
            Console.Clear();
        }
        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
            Console.WriteLine("Se ha registrado el vehículo.");
            Console.ReadKey();
        }
        public void RegistrarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("REGISTRAR CLIENTES");
            Console.WriteLine("-------------------");
            Console.Write("o DPI:");
            int iD= Convert.ToInt32(Console.ReadLine());
            Console.Write("o Nombre:");
            string nombre= Console.ReadLine();
            Cliente cliente= new Cliente(iD, nombre);
            listaClientes.Add(cliente);
            Console.WriteLine("Se ha registrado el cliente.");
        }
        public void RegisrarAutomovil()
        {
            Console.Clear ();
            Console.WriteLine("-------------------");
            Console.WriteLine("REGISTRAR AUTOMOVIL");
            Console.WriteLine("-------------------");
            Console.Write("o Propietario:");
            string propietarioBuscar = Console.ReadLine();
            Cliente propietario=listaClientes.Find(p=>p.Nombre==propietarioBuscar);
            if (propietario != null)
            {
                Console.Write("o Estacionamiento asignado:");
                string estacionamientoAsignado = Console.ReadLine();
                Console.Write("o Matrícula:");
                string matricula = Console.ReadLine();
                Console.Write("o Marca:");
                string marca = Console.ReadLine();
                Console.Write("o Modelo:");
                string modelo = Console.ReadLine();
                Console.Write("o Color:");
                string color = Console.ReadLine();
                Console.WriteLine("Se ha registrado el cliente.");
                Automovil automovil= new Automovil(estacionamientoAsignado, matricula, marca,modelo,color, propietario);
                listaVehiculos.Add(automovil);
            }
            else
            {
                Console.WriteLine("No se ha encontrado el automóvil.");
            }
            Console.ReadKey();
        }
    }
}

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
        public void RegisrarAutomovil()
        {
            Console.Clear ();
            Console.WriteLine("-------------------");
            Console.WriteLine("REGISTRAR AUTOMOVIL");
            Console.WriteLine("-------------------");
            Console.Write("o Estacionamiento asignado:");
            Console.Write("o Matrícula:");
            Console.Write("o Marca:");
            Console.Write("o Modelo:");
            Console.Write("o Color:");
            Console.Write("o Matrícula:");
            Console.Write("o Propietario:");
            RegistrarVehiculo();

        }
    }
}

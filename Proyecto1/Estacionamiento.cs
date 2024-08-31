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
        public Estacionamiento RegistrarEstacionamiento ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTIÓN Y COBRO DE ESTACIONAMIENTO");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Para registrar el estacionamiento, indique la cantidad de espacios que posee.");
            Console.Write("Cantidad de espacios: ");
            int espaciosDisponibles = Convert.ToInt32(Console.ReadLine());
            Estacionamiento estacionamiento = new Estacionamiento(espaciosDisponibles);
            Console.WriteLine("Se ha registrado el estacionamiento.");
            Console.ReadKey();
            Console.Clear();
            return estacionamiento;
        }
        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
             if (EspaciosDisponibles > 0)
        {
            listaVehiculos.Add(vehiculo);
            EspaciosDisponibles--;
            Console.WriteLine("Se ha registrado el vehículo.");
            Console.WriteLine($"Estacionamientos disponibles: {EspaciosDisponibles}.");
            }
        else
        {
            Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
        }
        Console.ReadKey();
        }
        public void RegistrarCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------");
            Console.WriteLine("REGISTRAR CLIENTES");
            Console.WriteLine("-------------------");
            Console.ResetColor();
            Console.Write("o DPI:");
            int iD= Convert.ToInt32(Console.ReadLine());
            Console.Write("o Nombre:");
            string nombre= Console.ReadLine();
            Cliente cliente= new Cliente(iD, nombre);
            listaClientes.Add(cliente);
            Console.WriteLine("Se ha registrado el cliente.");
            Console.WriteLine("Pulse cualquier tecla para continuar.");
        }
        public void RegistrarAutomovil(Estacionamiento estacionamiento)
        {
            if (EspaciosDisponibles > 0)
            {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------");
            Console.WriteLine("REGISTRAR AUTOMOVIL");
            Console.WriteLine("-------------------");
            Console.ResetColor();
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
                    Automovil automovil = new Automovil(estacionamientoAsignado, matricula, marca, modelo, color, propietario);
                    RegistrarVehiculo(automovil);
            }
                else
                {
                    Console.WriteLine("No se ha encontrado al propietario, regístrelo si no lo está.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
                Console.ReadKey();
            }
        }
        public void RegistrarMotocicleta(Estacionamiento estacionamiento)
        {
            if (EspaciosDisponibles > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-------------------");
                Console.WriteLine("REGISTRAR MOTOCICLETA");
                Console.WriteLine("-------------------");
                Console.ResetColor();
                Console.Write("o Propietario:");
                string propietarioBuscar = Console.ReadLine();
                Cliente propietario = listaClientes.Find(p => p.Nombre == propietarioBuscar);
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
                    Motocicleta motocicleta = new Motocicleta(estacionamientoAsignado, matricula, marca, modelo, color, propietario);
                    RegistrarVehiculo(motocicleta);
                }
                else
                {
                    Console.WriteLine("No se ha encontrado al propietario, regístrelo si no lo está.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
                Console.ReadKey();
            }
        }
        public void RegistrarCamion(Estacionamiento estacionamiento)
        {
            if (EspaciosDisponibles > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-------------------");
                Console.WriteLine("REGISTRAR CAMIÓN");
                Console.WriteLine("-------------------");
                Console.ResetColor();
                Console.Write("o Propietario:");
                string propietarioBuscar = Console.ReadLine();
                Cliente propietario = listaClientes.Find(p => p.Nombre == propietarioBuscar);
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
                    Camion camion = new Camion(estacionamientoAsignado, matricula, marca, modelo, color, propietario);
                    RegistrarVehiculo(camion);
                }
                else
                {
                    Console.WriteLine("No se ha encontrado al propietario, regístrelo si no lo está.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
                Console.ReadKey();
            }
        }
        public void RetirarVehiculo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------");
            Console.WriteLine("RETIRO DE VEHÍCULOS");
            Console.WriteLine("-------------------");
            Console.ResetColor();
            Console.Write("o Ingrese la matrícula del vehículo: ");
            string matricula = Console.ReadLine();

            Vehiculo vehiculo = listaVehiculos.Find(v => v.Matricula == matricula);
            if (vehiculo != null)
            {
                TimeSpan tiempoEstacionado = DateTime.Now - vehiculo.HoraRegistro;
                double tarifaPorHora = 15.0;
                double costo = Math.Ceiling(tiempoEstacionado.TotalHours) * tarifaPorHora;
                Console.WriteLine($"El vehículo estuvo estacionado por {tiempoEstacionado.TotalHours:F2} horas.");
                Console.WriteLine($"El costo total es: Q. {costo}.");
                listaVehiculos.Remove(vehiculo);
                EspaciosDisponibles++;
            }
            else
            {
                Console.WriteLine("No se encontró un vehículo con esa matrícula.");
            }
            Console.ReadKey();
        }
    }
}

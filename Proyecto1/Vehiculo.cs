using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Vehiculo
    {
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Cliente Propietario { get; set; }
        public Vehiculo(string matricula, string marca, string modelo, string color, Cliente propietario)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Propietario = propietario;
        }
        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
            Console.WriteLine("Se ha registrado el vehículo.");
            Console.ReadKey();
        }
    }
}

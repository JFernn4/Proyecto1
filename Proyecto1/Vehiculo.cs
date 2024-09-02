using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Vehiculo
    {
        public string EstacionamientoAsignado {  get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Cliente Propietario { get; set; }
        public DateTime HoraRegistro { get; set; }
        public Vehiculo(string estacionamientoAsignado, string matricula, string marca, string modelo, string color, Cliente propietario)
        {
            EstacionamientoAsignado= estacionamientoAsignado;
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Propietario = propietario;
            HoraRegistro = DateTime.Now;
        }
        public virtual string MostrarDetalles()
        {
            return $" Estacionamiento: {EstacionamientoAsignado}, Matrícula: {Matricula}, Marca: {Marca}, Modelo: {Modelo}, Color: {Color}, Propietario: {Propietario.Nombre}.";
        }
    }
}

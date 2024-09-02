using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Camion : Vehiculo
    {
        public Camion(string estacionamientoAsignado, string matricula, string marca, string modelo, string color, Cliente propietario) : base(estacionamientoAsignado, matricula, marca, modelo, color, propietario)
        {
        }
        public override string MostrarDetalles()
        {
            return base.MostrarDetalles() + $"(Camión, Q.20.00 por hora)";
        }
    }
}

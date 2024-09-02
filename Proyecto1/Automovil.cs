using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Automovil : Vehiculo
    {
        public Automovil(string estacionamientoAsignado, string matricula, string marca, string modelo, string color, Cliente propietario) : base(estacionamientoAsignado, matricula, marca, modelo, color, propietario)
        {
        }
        public override string MostrarDetalles()
        {
            return base.MostrarDetalles()+ $"(Automóvil, Q.15.00 por hora)";
        }
    }
}

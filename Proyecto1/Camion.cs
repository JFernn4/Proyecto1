using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Camion : Vehiculo
    {
        public Camion(string matricula, string marca, string modelo, string color) : base(matricula, marca, modelo, color)
        {
        }
    }
}

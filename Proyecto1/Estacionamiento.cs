using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Estacionamiento
    {
        public int EspaciosDisponibles { get; set; }

        public Estacionamiento(int espaciosDisponibles)
        {
            this.espaciosDisponibles = espaciosDisponibles;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Cliente
    {
        public string ID {  get; set; }
        public string Nombre { get; set; }
        private TarjetaDeCredito TarjetaDeCredito { get; set; }

        public Cliente(string iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }
    }
}

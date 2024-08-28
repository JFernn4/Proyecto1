using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class TarjetaDeCredito
    {
        private string NumeroTarjeta {  get; set; }
        private string NombreDeTitular { get; set; }
        private string FechaVencimiento { get; set; }
        private string CVV {  get; set; }

        public TarjetaDeCredito(string numeroTarjeta, string nombreDeTitular, string fechaVencimiento, string cVV)
        {
            NumeroTarjeta = numeroTarjeta;
            NombreDeTitular = nombreDeTitular;
            FechaVencimiento = fechaVencimiento;
            CVV = cVV;
        }
    }
}

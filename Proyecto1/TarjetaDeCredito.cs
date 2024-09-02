using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class TarjetaDeCredito
    {
        private string NumeroTarjeta;
        private string NombreDeTitular;
        private string FechaVencimiento;
        private int CVV;

        public TarjetaDeCredito(string numeroTarjeta, string nombreDeTitular, string fechaVencimiento, int cVV)
        {
            this.NumeroTarjeta = numeroTarjeta;
            this.NombreDeTitular = nombreDeTitular;
            this.FechaVencimiento = fechaVencimiento;
            this.CVV = cVV;
        }
        public bool Validar()
        {
            if (NumeroTarjeta.Length == 16 && CVV.ToString().Length == 3 && ValidarFecha())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidarFecha()
        {
            string[] dividirFecha = FechaVencimiento.Split('/');
            int mM = int.Parse(dividirFecha[0]);
            int aA = int.Parse(dividirFecha[1]);
            if (aA < 1 || mM < 1 || mM > 12)
            {
                return false;
            }
            if (mM <= 09 && aA <= 24)
            {
                return false; ;
            }
            return true;
        }
    }
}

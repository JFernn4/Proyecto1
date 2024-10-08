﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Motocicleta : Vehiculo
    {
        public Motocicleta(string estacionamientoAsignado, string matricula, string marca, string modelo, string color, Cliente propietario) : base(estacionamientoAsignado,matricula, marca, modelo, color, propietario)
        {
        }
        public override string MostrarDetalles()
        {
            return base.MostrarDetalles() + $"(Motocicleta, Q.10.00 por hora)";
        }
    }
}

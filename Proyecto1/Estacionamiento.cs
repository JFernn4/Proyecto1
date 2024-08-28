﻿using System;
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
            EspaciosDisponibles = espaciosDisponibles;
        }
        public static void RegistrarEstacionamiento ()
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTIÓN Y COBRO DE ESTACIONAMIENTO");
            Console.WriteLine("Para registrar el estacionamiento, indique la cantidad de espacios que posee.");
            Console.Write("Canitdad de espacios:");
            int espaciosDisponibles = Convert.ToInt32(Console.ReadLine());
            Estacionamiento estacionamiento = new Estacionamiento(espaciosDisponibles);
            Console.WriteLine("Se ha registrado el estacionamiento.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

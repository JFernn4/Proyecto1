﻿using Proyecto1;

bool menu= true;
int opcion= 0;
Estacionamiento estacionamiento= new Estacionamiento(0);
estacionamiento= estacionamiento.RegistrarEstacionamiento();
while (menu)
{
    try
    {
        MostrarMenu();
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                {
                    estacionamiento.RegistrarCliente();
                    break;
                }
            case 2:
                {
                    MostrarMenuVehiculos(estacionamiento);
                    break;
                }
            case 3:
                {
                    estacionamiento.RetirarVehiculo();
                    break;
                }
            case 4:
                {
                    estacionamiento.MostrarVehiculos();
                    break;
                }
            case 5:
                {
                    estacionamiento.MostrarEspaciosDisponibles();
                    break;
                }
            case 6:
                {
                    estacionamiento.BuscarVehiculo();
                    break;
                }
            case 7:
                {
                    Console.Clear();
                    menu = false;
                    break;
                }
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingresa un número del 1 al 7.");
        Console.ResetColor();
        Console.ReadKey();
    }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("SISTEMA DE GESTIÓN Y COBRO DE ESTACIONAMIENTO");
    Console.WriteLine("---------------------------------------------");
    Console.ResetColor();
    Console.WriteLine("(1) Registo de clientes.");
    Console.WriteLine("(2) Registo de vehículos.");
    Console.WriteLine("(3) Retiro de vehículos.");
    Console.WriteLine("(4) Visualización de vehículos estacionados.");
    Console.WriteLine("(5) Visualización de espacios disponibles.");
    Console.WriteLine("(6) Buscar vehículo.");
    Console.WriteLine("(7) Salir.");
}
static void MostrarMenuVehiculos(Estacionamiento estacionamiento)
{ 
    bool menuVehiculos = true;
    int opcion = 0;
    while (menuVehiculos)
    {
        try
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------");
            Console.WriteLine("REGISTRO DE VEHÍCULOS");
            Console.WriteLine("----------------------");
            Console.ResetColor();
            Console.WriteLine("(1) Automóvil.");
            Console.WriteLine("(2) Motocicleta.");
            Console.WriteLine("(3) Camión.");
            Console.WriteLine("(4) Salir.");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        estacionamiento.RegistrarAutomovil();
                        break;
                    }
                case 2:
                    {
                        estacionamiento.RegistrarMotocicleta();
                        break;
                    }
                case 3:
                    {
                        estacionamiento.RegistrarCamion();
                        break;
                    }
                case 4:
                    {
                        menuVehiculos = false;
                        break;
                    }
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ingresa un número del 1 al 4.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
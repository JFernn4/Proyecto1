﻿using Proyecto1;

bool menu= true;
int opcion= 0;
Estacionamiento estacionamiento= new Estacionamiento(0);
Estacionamiento.RegistrarEstacionamiento();
while (menu)
{
    MostrarMenu();
    opcion= Convert.ToInt32(Console.ReadLine());
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
                MostrarMenuRetirarVehiculos();
                break;
            }
        case 4:
            {
                break;
            }
        case 5:
            {
                Console.Clear();
                menu = false;
                break;
            }
    }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("SISTEMA DE GESTIÓN Y COBRO DE ESTACIONAMIENTO");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("(1) Registo de clientes.");
    Console.WriteLine("(2) Registo de vehículos.");
    Console.WriteLine("(3) Retiro de vehículos.");
    Console.WriteLine("(4) Visualización de vehículos estacionados.");
    Console.WriteLine("(5) Visualización de espacios disponibles.");
    Console.WriteLine("(6) Salir.");
}
static void MostrarMenuVehiculos(Estacionamiento estacionamiento)
{ 
    bool menuVehiculos = true;
    int opcion = 0;
    while (menuVehiculos)
    {
        Console.Clear();
        Console.WriteLine("----------------------");
        Console.WriteLine("REGISTRO DE VEHÍCULOS");
        Console.WriteLine("----------------------");
        Console.WriteLine("(1) Automóvil.");
        Console.WriteLine("(2) Motocicleta.");
        Console.WriteLine("(3) Camión.");
        Console.WriteLine("(4) Salir.");
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                {
                    estacionamiento.RegisrarAutomovil();
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    menuVehiculos = false;
                    break;
                }
        }
    }
}
static void MostrarMenuRetirarVehiculos()
{
        bool menuRetirar=true;
        int opcion = 0;
        while (menuRetirar)
        {
        Console.Clear();
        Console.WriteLine("----------------------");
        Console.WriteLine("RETIRO DE VEHÍCULOS");
        Console.WriteLine("----------------------");
        Console.WriteLine("Seleccione el método de pago.");
        Console.WriteLine("(1) Pago con efectivo.");
        Console.WriteLine("(2) Pago con tarjeta.");
        Console.WriteLine("(3) Salir.");
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                {
                    break;
                }
            case 2:
                {
                    break;  
                }
            case 3:
                {
                    menuRetirar = false;
                    break;
                }
        }
    }
        
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Estacionamiento
    {
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        List<Cliente>listaClientes= new List<Cliente>();
        public int EspaciosDisponibles { get; set; }

        public Estacionamiento(int espaciosDisponibles)
        {
            EspaciosDisponibles = espaciosDisponibles;
        }
        public Estacionamiento RegistrarEstacionamiento()
        {
            Estacionamiento estacionamiento = null;
            bool espaciosValidos = false;

            while (!espaciosValidos)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTIÓN Y COBRO DE ESTACIONAMIENTO");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("Para registrar el estacionamiento, indique la cantidad de espacios que posee.");
                    Console.Write("Cantidad de espacios: ");
                    int espaciosDisponibles = Convert.ToInt32(Console.ReadLine());

                    if (espaciosDisponibles > 0)
                    {
                        estacionamiento = new Estacionamiento(espaciosDisponibles);
                        Console.WriteLine("Se ha registrado el estacionamiento.");
                        espaciosValidos = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese una cantidad válida (mayor que 0).");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese una cantidad válida.");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número ingresado es demasiado grande o demasiado pequeño.");
                    Console.ResetColor();
                }
                Console.ReadKey();
                Console.Clear();
            }

            return estacionamiento;
        }
        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
             if (EspaciosDisponibles > 0)
        {
            listaVehiculos.Add(vehiculo);
            EspaciosDisponibles--;
            Console.WriteLine("Se ha registrado el vehículo.");
            Console.WriteLine($"Estacionamientos disponibles: {EspaciosDisponibles}.");
            }
        else
        {
            Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
        }
        Console.ReadKey();
        }
        public void RegistrarCliente()
        {
            Console.Clear();
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-------------------");
                Console.WriteLine("REGISTRAR CLIENTES");
                Console.WriteLine("-------------------");
                Console.ResetColor();
                Console.Write("o DPI:");
                string iD = Console.ReadLine();
                Console.Write("o Nombre:");
                string nombre = Console.ReadLine();
                Cliente cliente = new Cliente(iD, nombre);
                listaClientes.Add(cliente);
                Console.WriteLine("Se ha registrado el cliente.");
                Console.WriteLine("Pulse cualquier tecla para continuar.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingresa un DPI .");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public void RegistrarAutomovil()
        {
            if (EspaciosDisponibles > 0)
            {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------");
            Console.WriteLine("REGISTRAR AUTOMOVIL");
            Console.WriteLine("-------------------");
            Console.ResetColor();
            Console.Write("o Propietario:");
            string propietarioBuscar = Console.ReadLine();
            Cliente propietario=listaClientes.Find(p=>p.Nombre==propietarioBuscar);
            if (propietario != null)
            {
                    Console.Write("o Estacionamiento asignado:");
                    string estacionamientoAsignado = Console.ReadLine();
                    Console.Write("o Matrícula:");
                    string matricula = Console.ReadLine();
                    Console.Write("o Marca:");
                    string marca = Console.ReadLine();
                    Console.Write("o Modelo:");
                    string modelo = Console.ReadLine();
                    Console.Write("o Color:");
                    string color = Console.ReadLine();
                    Automovil automovil = new Automovil(estacionamientoAsignado, matricula, marca, modelo, color, propietario);
                    RegistrarVehiculo(automovil);
            }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("REGISTRAR AUTOMOVIL");
                    Console.WriteLine("-------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se ha encontrado al propietario, regístrelo si no lo está.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-------------------");
                Console.WriteLine("REGISTRAR AUTOMOVIL");
                Console.WriteLine("-------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public void RegistrarMotocicleta()
        {
            if (EspaciosDisponibles > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---------------------");
                Console.WriteLine("REGISTRAR MOTOCICLETA");
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.Write("o Propietario:");
                string propietarioBuscar = Console.ReadLine();
                Cliente propietario = listaClientes.Find(p => p.Nombre == propietarioBuscar);
                if (propietario != null)
                {
                    Console.Write("o Estacionamiento asignado:");
                    string estacionamientoAsignado = Console.ReadLine();
                    Console.Write("o Matrícula:");
                    string matricula = Console.ReadLine();
                    Console.Write("o Marca:");
                    string marca = Console.ReadLine();
                    Console.Write("o Modelo:");
                    string modelo = Console.ReadLine();
                    Console.Write("o Color:");
                    string color = Console.ReadLine();
                    Motocicleta motocicleta = new Motocicleta(estacionamientoAsignado, matricula, marca, modelo, color, propietario);
                    RegistrarVehiculo(motocicleta);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------");
                    Console.WriteLine("REGISTRAR MOTOCICLETA");
                    Console.WriteLine("---------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se ha encontrado al propietario, regístrelo si no lo está.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---------------------");
                Console.WriteLine("REGISTRAR MOTOCICLETA");
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public void RegistrarCamion()
        {
            if (EspaciosDisponibles > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------");
                Console.WriteLine("REGISTRAR CAMIÓN");
                Console.WriteLine("----------------");
                Console.ResetColor();
                Console.Write("o Propietario:");
                string propietarioBuscar = Console.ReadLine();
                Cliente propietario = listaClientes.Find(p => p.Nombre == propietarioBuscar);
                if (propietario != null)
                {
                    Console.Write("o Estacionamiento asignado:");
                    string estacionamientoAsignado = Console.ReadLine();
                    Console.Write("o Matrícula:");
                    string matricula = Console.ReadLine();
                    Console.Write("o Marca:");
                    string marca = Console.ReadLine();
                    Console.Write("o Modelo:");
                    string modelo = Console.ReadLine();
                    Console.Write("o Color:");
                    string color = Console.ReadLine();
                    Camion camion = new Camion(estacionamientoAsignado, matricula, marca, modelo, color, propietario);
                    RegistrarVehiculo(camion);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------------");
                    Console.WriteLine("REGISTRAR CAMIÓN");
                    Console.WriteLine("----------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se ha encontrado al propietario, regístrelo si no lo está.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------");
                Console.WriteLine("REGISTRAR CAMIÓN");
                Console.WriteLine("----------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay espacios disponibles para registrar el vehículo.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public void RetirarVehiculo()
        {
            double costo = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------");
            Console.WriteLine("RETIRO DE VEHÍCULOS");
            Console.WriteLine("-------------------");
            Console.ResetColor();
            Console.Write("o Ingrese la matrícula del vehículo: ");
            string matricula = Console.ReadLine();

            Vehiculo vehiculo = listaVehiculos.Find(v => v.Matricula == matricula);
            if (vehiculo != null)
            {
                if (vehiculo is Motocicleta motocicleta)
                {
                    TimeSpan tiempoEstacionado = DateTime.Now - vehiculo.HoraRegistro;
                    double tarifaPorHora = 10.0;
                    costo = Math.Ceiling(tiempoEstacionado.TotalHours) * tarifaPorHora;
                    Console.WriteLine($"El vehículo estuvo estacionado por {tiempoEstacionado.TotalHours:F2} horas.");
                    Console.WriteLine($"El costo total es: Q. {costo}.00");
                    Console.ReadKey();
                }
                if (vehiculo is Automovil automovil)
                {
                    TimeSpan tiempoEstacionado = DateTime.Now - vehiculo.HoraRegistro;
                    double tarifaPorHora = 15.0;
                    costo = Math.Ceiling(tiempoEstacionado.TotalHours) * tarifaPorHora;
                    Console.WriteLine($"El vehículo estuvo estacionado por {tiempoEstacionado.TotalHours:F2} horas.");
                    Console.WriteLine($"El costo total es: Q. {costo}.00");
                    Console.ReadKey();
                }
                if (vehiculo is Camion camion)
                {
                    TimeSpan tiempoEstacionado = DateTime.Now - vehiculo.HoraRegistro;
                    double tarifaPorHora = 20.0;
                    costo = Math.Ceiling(tiempoEstacionado.TotalHours) * tarifaPorHora;
                    Console.WriteLine($"El vehículo estuvo estacionado por {tiempoEstacionado.TotalHours:F2} horas.");
                    Console.WriteLine($"El costo total es: Q. {costo}.00");
                    Console.ReadKey();
                }
                bool menuRetirar = true;
                int opcion = 0;
                while (menuRetirar)
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-------------------");
                        Console.WriteLine("RETIRO DE VEHÍCULOS");
                        Console.WriteLine("-------------------");
                        Console.ResetColor();
                        Console.WriteLine("Seleccione el método de pago.");
                        Console.WriteLine("(1) Pago con efectivo.");
                        Console.WriteLine("(2) Pago con tarjeta.");
                        Console.WriteLine("(3) Salir.");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("----------------");
                                        Console.WriteLine("PAGO EN EFECTIVO");
                                        Console.WriteLine("----------------");
                                        Console.ResetColor();
                                        Console.WriteLine($"El total es de Q. {costo}, ingrese el efectivo.");
                                        double pago = Convert.ToInt32(Console.ReadLine());
                                        double cambio = pago - costo;
                                        if (cambio < 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Ingrese un monto válido.");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            break;
                                        }
                                        Console.WriteLine($"Su cambio es de Q.{cambio}");

                                        int div200 = (int)cambio / 200;
                                        int mod200 = (int)cambio % 200;
                                        int div100 = mod200 / 100;
                                        int mod100 = mod200 % 100;
                                        int div50 = mod100 / 50;
                                        int mod50 = mod100 % 50;
                                        int div20 = mod50 / 20;
                                        int mod20 = mod50 % 20;
                                        int div10 = mod20 / 10;
                                        int mod10 = mod20 % 10;
                                        int div5 = mod10 / 5;
                                        int mod5 = mod10 % 5;
                                        int div1 = mod5 / 1;

                                        if (div200 > 0) Console.WriteLine($"- {div200} billetes de Q.200");
                                        if (div100 > 0) Console.WriteLine($"- {div100} billetes de Q.100");
                                        if (div50 > 0) Console.WriteLine($"- {div50} billetes de Q.50");
                                        if (div20 > 0) Console.WriteLine($"- {div20} billetes de Q.20");
                                        if (div10 > 0) Console.WriteLine($"- {div10} billetes de Q.10");
                                        if (div5 > 0) Console.WriteLine($"- {div5} billetes de Q.5");
                                        if (div1 > 0) Console.WriteLine($"- {div1} monedas de Q.1");

                                        listaVehiculos.Remove(vehiculo);
                                        EspaciosDisponibles++;
                                        Console.ReadKey();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ingrese un monto válido.");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("----------------");
                                    Console.WriteLine("PAGO CON TARJETA");
                                    Console.WriteLine("----------------");
                                    Console.ResetColor();
                                    Console.Write("o Número de la tarjeta (16 dígitos):");
                                    string numeroTarjeta = Console.ReadLine();
                                    Console.Write("o Nombre del titular:");
                                    string nombreTitular = Console.ReadLine();
                                    Console.Write("o Fecha de vencimiento (MM/AA):");
                                    string fechaVencimiento = Console.ReadLine();
                                    Console.Write("o CVV (3 dígitos):");
                                    string cVV = Console.ReadLine();
                                    TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito(numeroTarjeta, nombreTitular, fechaVencimiento, cVV);
                                    if (tarjetaDeCredito.Validar() == true)
                                    {
                                        Console.WriteLine("Se ha realizado el pago.");
                                        listaVehiculos.Remove(vehiculo);
                                        EspaciosDisponibles++;
                                        Console.ReadKey();

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Los datos de la tarjeta son inválidos, inténtelo de nuevo.");
                                        Console.ResetColor();
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    menuRetirar = false;
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingresa un número del 1 al 3.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se encontró un vehículo con esa matrícula.");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public void MostrarVehiculos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("VISUALIZACIÓN DE VEHÍCULOS ESTACIONADOS");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("o");
                Console.ResetColor();
                Console.WriteLine(vehiculo.MostrarDetalles());
            }
            Console.ReadKey (); 
        }
        public void MostrarEspaciosDisponibles()
        {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("VISUALIZACIÓN DE ESPACIOS DISPONIBLES");
            Console.WriteLine("-------------------------------------");
            Console.ResetColor();
            Console.WriteLine($"Quedan {EspaciosDisponibles} espacios restantes. ");
            Console.ReadKey();
        }
        public void BuscarVehiculo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("BUSCAR VEHÍCULO POR MATRÍCULA");
            Console.WriteLine("-----------------------------");
            Console.ResetColor();
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("o");
                Console.ResetColor();
                Console.WriteLine(vehiculo.Matricula);
            }
            Console.Write("o Matrícula:");
            string buscarMatricula= Console.ReadLine();
            Vehiculo buscar = listaVehiculos.Find(p =>p.Matricula == buscarMatricula);
            if (buscar != null)
            {
                Console.WriteLine(buscar.MostrarDetalles());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se encontró un vehículo con esa matrícula.");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}

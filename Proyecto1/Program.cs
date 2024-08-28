using Proyecto1;

bool menu= true;
int opcion= 0;
Estacionamiento.RegistrarEstacionamiento();
while (menu)
{
    MostrarMenu();
    opcion= Convert.ToInt32(Console.ReadLine());
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
                break;
            }
        case 4:
            {
                break;
            }
        case 5:
            {
                break;
            }
    }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("1. Registo de vehículos.");
    Console.WriteLine("2. Retiro de vehículos.");
    Console.WriteLine("3. Visualización de vehículos estacionados.");
    Console.WriteLine("4. Visualización de espacios disponibles.");
    Console.WriteLine("5. Salir.");
}
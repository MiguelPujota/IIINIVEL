uusing System;
using System;

class Program
{
    static void Main()
    {
        ListaVehiculos lista = new ListaVehiculos();
        int opcion;

        do
        {
            Console.WriteLine("=== Menú de Registro de Vehículos ===");
            Console.WriteLine("1. Agregar vehículo");
            Console.WriteLine("2. Buscar vehículo por placa");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Placa: ");
                    string placa = Console.ReadLine();
                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Año: ");
                    int año = int.Parse(Console.ReadLine());
                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    lista.AgregarVehiculo(placa, modelo, año, precio);
                    break;

                case 2:
                    Console.Write("Ingrese la placa a buscar: ");
                    string buscarPlaca = Console.ReadLine();
                    lista.BuscarPorPlaca(buscarPlaca);
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }

        } while (opcion != 3);
    }
}
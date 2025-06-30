using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Elige un ejercicio para ejecutar (1-5) o 0 para salir:");
            Console.WriteLine("1 - Ejercicio 1");
            Console.WriteLine("2 - Ejercicio 2");
            Console.WriteLine("3 - Ejercicio 3");
            Console.WriteLine("4 - Ejercicio 4");
            Console.WriteLine("5 - Ejercicio 5");
            Console.WriteLine("0 - Salir");
            Console.Write("Opción: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int opcion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ReadKey();
                continue;
            }

            if (opcion == 0)
            {
                Console.WriteLine("Saliendo...");
                break;
            }

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    EjecutarEjercicio1();
                    break;
                case 2:
                    Ejercicio2.Ejecutar();
                    break;
                case 3:
                    Ejercicio3.Ejecutar();
                    break;
                case 4:
                    Ejercicio4.Ejecutar();
                    break;
                case 5:
                    Ejercicio5.Ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona una tecla para volver al menú...");
            Console.ReadKey();
        }
    }

    private static void EjecutarEjercicio1()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}

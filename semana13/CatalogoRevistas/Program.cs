using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Lista que almacena los títulos de revistas
        static List<string> catalogo = new List<string>
        {
            "Cocina Sana",
            "Viajes y Sabores",
            "Arte y Alma",
            "Naturaleza Viva",
            "Historias que Sanan",
            "Panadería Creativa",
            "Bienestar Integral",
            "Familia y Hogar",
            "Inspiración Visual",
            "Recetas del Corazón"
        };

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Catálogo de Revistas");
                Console.WriteLine("1. Buscar título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        BuscarTitulo();
                        break;
                    case "2":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Método que permite buscar un título en el catálogo
        static void BuscarTitulo()
        {
            Console.Clear();
            Console.Write("Ingrese el título a buscar: ");
            string tituloBuscado = Console.ReadLine();

            bool encontrado = BuscarIterativo(tituloBuscado);

            if (encontrado)
                Console.WriteLine("Resultado: Encontrado");
            else
                Console.WriteLine(" Resultado: No encontrado");

            Console.WriteLine("Presione una tecla para volver al menú...");
            Console.ReadKey();
        }

        // Algoritmo de búsqueda iterativa
        static bool BuscarIterativo(string titulo)
        {
            foreach (string revista in catalogo)
            {
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
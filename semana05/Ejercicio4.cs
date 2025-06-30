using System;
using System.Collections.Generic;

public class Ejercicio4
{
    public static void Ejecutar()
    {
        List<int> numerosLoteria = new List<int>();

        Console.WriteLine("Introduce los 6 números ganadores de la lotería:");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"Número {i}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numerosLoteria.Add(numero);
        }

        numerosLoteria.Sort();

        Console.WriteLine("Números ganadores ordenados:");
        foreach (int num in numerosLoteria)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;

public class Ejercicio5
{
    public static void Ejecutar()
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        numeros.Reverse();

        Console.WriteLine("Números del 10 al 1:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}

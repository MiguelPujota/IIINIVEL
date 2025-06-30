using System;
using System.Collections.Generic;

public class Ejercicio3
{
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Dictionary<string, double> notas = new Dictionary<string, double>();

        foreach (string asignatura in asignaturas)
        {
            Console.Write($"¿Qué nota sacaste en {asignatura}? ");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas[asignatura] = nota;
        }

        Console.WriteLine("\nResumen de notas:");
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}

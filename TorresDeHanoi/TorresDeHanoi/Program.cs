using System;                      // Permite el uso de funciones básicas como Console.WriteLine.
using System.Collections.Generic; // Permite trabajar con colecciones como Stack (pilas).

class Program
{
    // Se definen tres pilas que representarán las torres: origen, auxiliar y destino.
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    // Función recursiva que resuelve el problema de Hanoi.
    static void Resolver(int n, Stack<int> desde, Stack<int> hacia, Stack<int> ayuda,
                         string nombreDesde, string nombreHacia, string nombreAyuda)
    {
        // Caso base: si hay un solo disco, lo movemos directamente.
        if (n == 1)
        {
            int disco = desde.Pop();          // Sacamos el disco superior de la pila origen.
            hacia.Push(disco);                // Lo colocamos en la pila destino.
            Console.WriteLine($"Mover disco {disco} de {nombreDesde} a {nombreHacia}");
        }
        else
        {
            // Paso 1: mover n-1 discos a la torre auxiliar usando la torre destino como ayuda.
            Resolver(n - 1, desde, ayuda, hacia, nombreDesde, nombreAyuda, nombreHacia);

            // Paso 2: mover el disco restante al destino.
            Resolver(1, desde, hacia, ayuda, nombreDesde, nombreHacia, nombreAyuda);

            // Paso 3: mover los n-1 discos desde auxiliar a destino usando origen como ayuda.
            Resolver(n - 1, ayuda, hacia, desde, nombreAyuda, nombreHacia, nombreDesde);
        }
    }

    static void Main()
    {
        int numDiscos = 3; // Número de discos a mover (puedes cambiarlo para probar otros casos).

        // Se apilan los discos en la torre origen de mayor a menor.
        for (int i = numDiscos; i >= 1; i--)
            origen.Push(i);

        // Muestra título de los pasos que se van a ejecutar.
        Console.WriteLine("Secuencia de movimientos para resolver las Torres de Hanoi:\n");

        // Llama a la función recursiva para resolver el problema.
        Resolver(numDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> lista = new LinkedList<int>();
        Random rand = new Random();

        for (int i = 0; i < 50; i++)
        {
            lista.AddLast(rand.Next(1, 1000));
        }

        Console.WriteLine("Lista original:");
        MostrarLista(lista);

        Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        LinkedListNode<int> nodo = lista.First;
        while (nodo != null)
        {
            LinkedListNode<int> siguiente = nodo.Next;
            if (nodo.Value < min || nodo.Value > max)
            {
                lista.Remove(nodo);
            }
            nodo = siguiente;
        }

        Console.WriteLine("\nLista después de eliminar valores fuera del rango:");
        MostrarLista(lista);
    }

    static void MostrarLista(LinkedList<int> lista)
    {
        foreach (int valor in lista)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }
}
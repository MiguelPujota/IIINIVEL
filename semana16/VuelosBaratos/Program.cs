using System;
using System.Collections.Generic;

class Arista
{
    public string Destino { get; set; }
    public int Costo { get; set; }

    public Arista(string destino, int costo)
    {
        Destino = destino;
        Costo = costo;
    }
}

class Grafo
{
    private Dictionary<string, List<Arista>> mapa = new Dictionary<string, List<Arista>>();

    public void AgregarVuelo(string origen, string destino, int costo)
    {
        if (!mapa.ContainsKey(origen))
            mapa[origen] = new List<Arista>();
        mapa[origen].Add(new Arista(destino, costo));
    }

    public void EncontrarRutaMasBarata(string origen, string destino)
    {
        var dist = new Dictionary<string, int>();
        var prev = new Dictionary<string, string>();
        var cola = new PriorityQueue<string, int>();

        foreach (var ciudad in mapa.Keys)
            dist[ciudad] = int.MaxValue;

        dist[origen] = 0;
        cola.Enqueue(origen, 0);

        while (cola.Count > 0)
        {
            var ciudadActual = cola.Dequeue();

            if (!mapa.ContainsKey(ciudadActual)) continue;

            foreach (var arista in mapa[ciudadActual])
            {
                int nuevoCosto = dist[ciudadActual] + arista.Costo;
                if (nuevoCosto < dist.GetValueOrDefault(arista.Destino, int.MaxValue))
                {
                    dist[arista.Destino] = nuevoCosto;
                    prev[arista.Destino] = ciudadActual;
                    cola.Enqueue(arista.Destino, nuevoCosto);
                }
            }
        }

        if (!dist.ContainsKey(destino) || dist[destino] == int.MaxValue)
        {
            Console.WriteLine("No hay ruta disponible.");
            return;
        }

        Console.WriteLine($"Costo mínimo: ${dist[destino]}");
        Console.Write("Ruta: ");
        var ruta = new Stack<string>();
        string actual = destino;
        while (actual != null)
        {
            ruta.Push(actual);
            prev.TryGetValue(actual, out actual);
        }
        Console.WriteLine(string.Join(" → ", ruta));
    }
}

class Program
{
    static void Main()
    {
        var vuelos = new Grafo();

        // Simulación de base de datos ficticia
        vuelos.AgregarVuelo("Quito", "Guayaquil", 45);
        vuelos.AgregarVuelo("Guayaquil", "Cuenca", 30);
        vuelos.AgregarVuelo("Quito", "Cuenca", 70);
        vuelos.AgregarVuelo("Cuenca", "Loja", 25);

        // Consulta
        vuelos.EncontrarRutaMasBarata("Quito", "Loja");
    }
}
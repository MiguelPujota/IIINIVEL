// Clase que representa a una persona
public class Persona
{
    public string Nombre { get; set; }
    public int Numero { get; set; }

    public Persona(string nombre, int numero)
    {
        Nombre = nombre;
        Numero = numero;
    }
}

// Clase que representa la atracción
public class Atraccion
{
    private Queue<Persona> fila = new Queue<Persona>();
    private const int CAPACIDAD = 30;

    public void AgregarPersona(Persona persona)
    {
        if (fila.Count < CAPACIDAD)
        {
            fila.Enqueue(persona);
            Console.WriteLine($"{persona.Nombre} ha sido asignado al asiento {persona.Numero}.");
        }
        else
        {
            Console.WriteLine($"Lo siento, {persona.Nombre}, no hay asientos disponibles.");
        }
    }

    public void IniciarAtraccion()
    {
        Console.WriteLine("\n🎢 ¡La atracción comienza! Suben en orden:");
        while (fila.Count > 0)
        {
            Persona siguiente = fila.Dequeue();
            Console.WriteLine($"→ {siguiente.Nombre} ocupa el asiento {siguiente.Numero}");
        }
    }
}
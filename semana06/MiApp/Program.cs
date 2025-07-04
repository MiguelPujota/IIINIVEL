class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(20);
        lista.AgregarAlFinal(30);

        Console.WriteLine("Contenido de la lista:");
        lista.Imprimir();

        Console.WriteLine("Longitud de la lista: " + lista.Longitud());
    }
}
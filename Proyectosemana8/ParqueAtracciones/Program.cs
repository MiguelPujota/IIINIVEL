public class Program
{
    public static void Main(string[] args)
    {
        Atraccion atraccion = new Atraccion();

        for (int i = 1; i <= 35; i++) // Intenta agregar 35 personas para probar el límite
        {
            string nombre = $"Persona{i}";
            Persona p = new Persona(nombre, i);
            atraccion.AgregarPersona(p);
        }

        atraccion.IniciarAtraccion();
    }
}
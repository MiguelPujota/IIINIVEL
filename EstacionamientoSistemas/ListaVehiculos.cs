using System;

public class ListaVehiculos
{
    // b. Buscar vehículo por placa
public void BuscarPorPlaca(string placa)
{
    Vehiculo actual = cabeza;
    while (actual != null)
    {
        if (actual.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
        {
            MostrarVehiculo(actual);
            return;
        }
        actual = actual.Siguiente;
    }
    Console.WriteLine("Vehículo no encontrado.\n");
}

// Método auxiliar para mostrar un vehículo
private void MostrarVehiculo(Vehiculo v)
{
    Console.WriteLine($"Placa: {v.Placa}, Modelo: {v.Modelo}, Año: {v.Año}, Precio: ${v.Precio}\n");
}
    private Vehiculo cabeza;

    // a. Agregar vehículo
    public void AgregarVehiculo(string placa, string modelo, int año, decimal precio)
    {
        Vehiculo nuevo = new Vehiculo
        {
            Placa = placa,
            Modelo = modelo,
            Año = año,
            Precio = precio,
            Siguiente = cabeza
        };
        cabeza = nuevo;
        Console.WriteLine("Vehículo agregado correctamente.\n");
    }
    
}

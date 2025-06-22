import java.util.Scanner;

public class Proyectosemana4 {
    public static void main(String[] args) {
        AgendaTelefonica agenda = new AgendaTelefonica();
        Scanner sc = new Scanner(System.in);
        int opcion;

        do {
            System.out.println("----- Agenda Telefonica -----");
            System.out.println("1. Agregar contacto");
            System.out.println("2. Mostrar contactos");
            System.out.println("3. Buscar por nombre");
            System.out.println("4. Salir");
            System.out.print("Seleccione una opcion: ");
            opcion = sc.nextInt();
            sc.nextLine(); // limpiar buffer

            switch (opcion) {
                case 1:
                    System.out.print("Nombre: ");
                    String nombre = sc.nextLine();
                    System.out.print("Telefono: ");
                    String telefono = sc.nextLine();
                    System.out.print("Correo: ");
                    String correo = sc.nextLine();
                    System.out.print("Direccion: ");
                    String direccion = sc.nextLine();
                    agenda.agregarContacto(new Contacto(nombre, telefono, correo, direccion));
                    break;
                case 2:
                    agenda.mostrarContactos();
                    break;
                case 3:
                    System.out.print("Ingrese nombre a buscar: ");
                    String buscar = sc.nextLine();
                    agenda.buscarPorNombre(buscar);
                    break;
                case 4:
                    System.out.println("Saliendo...");
                    break;
                default:
                    System.out.println("Opcion invalida.");
            }
        } while (opcion != 4);
    }
}

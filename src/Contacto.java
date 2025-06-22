public class Contacto {
    private String nombre;
    private String telefono;
    private String correo;
    private String direccion;

    public Contacto(String nombre, String telefono, String correo, String direccion) {
        this.nombre = nombre;
        this.telefono = telefono;
        this.correo = correo;
        this.direccion = direccion;
    }
    public String getNombre() {
        return nombre;
    }
    public void mostrarContacto() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Telefono: " + telefono);
        System.out.println("Correo: " + correo);
        System.out.println("Direccion: " + direccion);
        System.out.println("----------------------");
    }
}
import java.util.ArrayList;

public class AgendaTelefonica {
    private ArrayList<Contacto> contactos = new ArrayList<>();

    public void agregarContacto(Contacto contacto) {
        contactos.add(contacto);
    }

    public void mostrarContactos() {
        if (contactos.isEmpty()) {
            System.out.println("La agenda esta vacia.");
        } else {
            for (Contacto c : contactos) {
                c.mostrarContacto();
            }
        }
    }

    public void buscarPorNombre(String nombre) {
        boolean encontrado = false;
        for (Contacto c : contactos) {
            if (c.getNombre().equalsIgnoreCase(nombre)) {
                c.mostrarContacto();
                encontrado = true;
            }
        }
        if (!encontrado) {
            System.out.println("Contacto no encontrado.");
        }
    }
}
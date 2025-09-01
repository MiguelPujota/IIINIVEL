import java.util.*;

public class TraductorBasico {
    static Map<String, String> diccionario = new HashMap<>();

    public static void main(String[] args) {
        inicializarDiccionario();
        Scanner scanner = new Scanner(System.in);
        int opcion;

        do {
            System.out.println("\n==================== MENÚ ====================");
            System.out.println("1. Traducir una frase");
            System.out.println("2. Agregar palabras al diccionario");
            System.out.println("0. Salir");
            System.out.print("Seleccione una opción: ");
            opcion = scanner.nextInt();
            scanner.nextLine(); // Limpiar buffer

            switch (opcion) {
                case 1:
                    traducirFrase(scanner);
                    break;
                case 2:
                    agregarPalabra(scanner);
                    break;
                case 0:
                    System.out.println("¡Hasta pronto!");
                    break;
                default:
                    System.out.println("Opción inválida.");
            }
        } while (opcion != 0);
    }

    static void inicializarDiccionario() {
        diccionario.put("tiempo", "time");
        diccionario.put("persona", "person");
        diccionario.put("año", "year");
        diccionario.put("camino", "way");
        diccionario.put("forma", "way");
        diccionario.put("día", "day");
        diccionario.put("cosa", "thing");
        diccionario.put("hombre", "man");
        diccionario.put("mundo", "world");
        diccionario.put("vida", "life");
        diccionario.put("mano", "hand");
        diccionario.put("parte", "part");
        diccionario.put("niño", "child");
        diccionario.put("niña", "child");
        diccionario.put("ojo", "eye");
        diccionario.put("mujer", "woman");
        diccionario.put("lugar", "place");
        diccionario.put("trabajo", "work");
        diccionario.put("semana", "week");
        diccionario.put("caso", "case");
        diccionario.put("punto", "point");
        diccionario.put("tema", "point");
        diccionario.put("gobierno", "government");
        diccionario.put("empresa", "company");
        diccionario.put("compañía", "company");
    }

    static void traducirFrase(Scanner scanner) {
        System.out.print("\nIngrese una frase en español: ");
        String frase = scanner.nextLine().toLowerCase();
        String[] palabras = frase.split("\\s+");

        System.out.println("\nTraducción parcial:");
        for (String palabra : palabras) {
            String limpia = palabra.replaceAll("[^a-záéíóúñ]", ""); // Eliminar signos
            if (diccionario.containsKey(limpia)) {
                System.out.print(diccionario.get(limpia) + " ");
            } else {
                System.out.print(palabra + " ");
            }
        }
        System.out.println();
    }

    static void agregarPalabra(Scanner scanner) {
        System.out.print("\nIngrese la palabra en español: ");
        String esp = scanner.nextLine().toLowerCase();
        System.out.print("Ingrese su traducción al inglés: ");
        String ing = scanner.nextLine().toLowerCase();

        if (!diccionario.containsKey(esp)) {
            diccionario.put(esp, ing);
            System.out.println("Palabra agregada correctamente.");
        } else {
            System.out.println("La palabra ya existe en el diccionario.");
        }
    }
}
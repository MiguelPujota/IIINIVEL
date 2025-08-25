import java.util.*;

public class App {
    public static void main(String[] args) {
        Set<String> todos = new HashSet<>();
        Set<String> pfizer = new HashSet<>();
        Set<String> astra = new HashSet<>();

        // Generar 500 ciudadanos
        for (int i = 1; i <= 500; i++) {
            todos.add("Ciudadano " + i);
        }

        // Pfizer: Ciudadano 1 al 75
        for (int i = 1; i <= 75; i++) {
            pfizer.add("Ciudadano " + i);
        }

        // AstraZeneca: Ciudadano 50 al 124
        for (int i = 50; i <= 124; i++) {
            astra.add("Ciudadano " + i);
        }

        // No vacunados
        Set<String> noVacunados = new HashSet<>(todos);
        noVacunados.removeAll(pfizer);
        noVacunados.removeAll(astra);

        // Ambas dosis
        Set<String> ambasDosis = new HashSet<>(pfizer);
        ambasDosis.retainAll(astra);

        // Solo Pfizer
        Set<String> soloPfizer = new HashSet<>(pfizer);
        soloPfizer.removeAll(astra);

        // Solo AstraZeneca
        Set<String> soloAstra = new HashSet<>(astra);
        soloAstra.removeAll(pfizer);

        // Mostrar resultados
        System.out.println("No vacunados: " + noVacunados.size());
        System.out.println("Ambas dosis: " + ambasDosis.size());
        System.out.println("Solo Pfizer: " + soloPfizer.size());
        System.out.println("Solo AstraZeneca: " + soloAstra.size());
    }
}
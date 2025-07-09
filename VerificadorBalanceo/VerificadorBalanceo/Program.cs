using System;                      // Importa funcionalidades básicas como entrada/salida por consola.
using System.Collections.Generic; // Permite usar colecciones como Stack (pila).

class Program
{
    // Función que recibe una expresión y verifica si los símbolos están balanceados.
    public static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Se crea una pila para almacenar los símbolos de apertura.

        foreach (char c in expresion)         // Recorremos cada caracter de la expresión.
        {
            // Si encontramos un símbolo de apertura, lo apilamos.
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);
            // Si encontramos un símbolo de cierre...
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no hay símbolo para emparejar ⇒ desbalanceado.
                if (pila.Count == 0) return false;

                char tope = pila.Pop(); // Sacamos el último símbolo de apertura guardado.

                // Verificamos que el símbolo de apertura coincida con el símbolo de cierre.
                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                    return false; // Si no coinciden, la fórmula está desbalanceada.
            }
        }

        // Si al final de la expresión la pila está vacía, todos los símbolos están emparejados.
        return pila.Count == 0;
    }

    static void Main()
    {
        // Ejemplo de expresión matemática con diferentes símbolos.
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        // Se llama a la función y se muestra si está balanceada o no.
        Console.WriteLine(EstaBalanceado(expresion) ? "Fórmula balanceada." : "Fórmula desbalanceada.");
    }
}

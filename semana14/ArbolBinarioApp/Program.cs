using System;

class Nodo {
    public int dato;
    public Nodo izquierda;
    public Nodo derecha;

    public Nodo(int valor) {
        dato = valor;
        izquierda = null;
        derecha = null;
    }
}

class ArbolBinario {
    public Nodo raiz;

    public void Insertar(int valor) {
        raiz = InsertarRecursivo(raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor) {
        if (nodo == null) return new Nodo(valor);
        if (valor < nodo.dato)
            nodo.izquierda = InsertarRecursivo(nodo.izquierda, valor);
        else if (valor > nodo.dato)
            nodo.derecha = InsertarRecursivo(nodo.derecha, valor);
        return nodo;
    }

    public void Inorden() => RecorrerInorden(raiz);
    private void RecorrerInorden(Nodo nodo) {
        if (nodo != null) {
            RecorrerInorden(nodo.izquierda);
            Console.Write(nodo.dato + " ");
            RecorrerInorden(nodo.derecha);
        }
    }

    public void Preorden() => RecorrerPreorden(raiz);
    private void RecorrerPreorden(Nodo nodo) {
        if (nodo != null) {
            Console.Write(nodo.dato + " ");
            RecorrerPreorden(nodo.izquierda);
            RecorrerPreorden(nodo.derecha);
        }
    }

    public void Postorden() => RecorrerPostorden(raiz);
    private void RecorrerPostorden(Nodo nodo) {
        if (nodo != null) {
            RecorrerPostorden(nodo.izquierda);
            RecorrerPostorden(nodo.derecha);
            Console.Write(nodo.dato + " ");
        }
    }

    public bool Buscar(int valor) => BuscarRecursivo(raiz, valor);
    private bool BuscarRecursivo(Nodo nodo, int valor) {
        if (nodo == null) return false;
        if (valor == nodo.dato) return true;
        return valor < nodo.dato
            ? BuscarRecursivo(nodo.izquierda, valor)
            : BuscarRecursivo(nodo.derecha, valor);
    }

    public void Eliminar(int valor) {
        raiz = EliminarRecursivo(raiz, valor);
    }

    private Nodo EliminarRecursivo(Nodo nodo, int valor) {
        if (nodo == null) return null;
        if (valor < nodo.dato)
            nodo.izquierda = EliminarRecursivo(nodo.izquierda, valor);
        else if (valor > nodo.dato)
            nodo.derecha = EliminarRecursivo(nodo.derecha, valor);
        else {
            if (nodo.izquierda == null) return nodo.derecha;
            if (nodo.derecha == null) return nodo.izquierda;
            Nodo sucesor = EncontrarMinimo(nodo.derecha);
            nodo.dato = sucesor.dato;
            nodo.derecha = EliminarRecursivo(nodo.derecha, sucesor.dato);
        }
        return nodo;
    }

    private Nodo EncontrarMinimo(Nodo nodo) {
        while (nodo.izquierda != null)
            nodo = nodo.izquierda;
        return nodo;
    }
}

class Programa {
    static void Main() {
        ArbolBinario arbol = new ArbolBinario();
        int opcion;

        do {
            Console.WriteLine("\n--- MENÚ ÁRBOL BINARIO ---");
            Console.WriteLine("1. Insertar nodo");
            Console.WriteLine("2. Recorrido Inorden");
            Console.WriteLine("3. Recorrido Preorden");
            Console.WriteLine("4. Recorrido Postorden");
            Console.WriteLine("5. Buscar elemento");
            Console.WriteLine("6. Eliminar nodo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.Write("Ingrese valor a insertar: ");
                    int valorInsertar = int.Parse(Console.ReadLine());
                    arbol.Insertar(valorInsertar);
                    break;
                case 2:
                    Console.WriteLine("Recorrido Inorden:");
                    arbol.Inorden();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Recorrido Preorden:");
                    arbol.Preorden();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Recorrido Postorden:");
                    arbol.Postorden();
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Ingrese valor a buscar: ");
                    int valorBuscar = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valorBuscar)
                        ? "Elemento encontrado."
                        : "Elemento no encontrado.");
                    break;
                case 6:
                    Console.Write("Ingrese valor a eliminar: ");
                    int valorEliminar = int.Parse(Console.ReadLine());
                    arbol.Eliminar(valorEliminar);
                    Console.WriteLine("Nodo eliminado si existía.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }
}

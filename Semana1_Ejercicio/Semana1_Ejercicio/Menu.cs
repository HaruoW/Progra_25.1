using System;

class Menu
{
    private Personaje personaje;

    public void Ejecutar()
    {
        Console.WriteLine("¡Bienvenido a la aventura de texto!");
        CrearPersonaje();
        IniciarHistoria();
    }

    private void CrearPersonaje()
    {
        Console.Write("Elige un nombre para tu personaje: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Elige tu clase:");
        Console.WriteLine("1. Guerrero");
        Console.WriteLine("2. Mago");

        string opcion = Console.ReadLine();

        if (opcion == "1") personaje = new Guerrero(nombre);
        else personaje = new Mago(nombre);

        Console.WriteLine($"¡Has creado a {personaje.Nombre}!");
    }

    private void IniciarHistoria()
    {
        Console.WriteLine("\n Elige tu camino:");
        Console.WriteLine("1. Explorar un bosque misterioso");
        Console.WriteLine("2. Entrar a una cueva oscura");
        Console.WriteLine("3. Ir a una aldea en ruinas");
        Console.WriteLine("4. Cruzar un puente antiguo");
        Console.WriteLine("5. Entrar a un castillo abandonado");

        string opcion = Console.ReadLine();
        string enemigo = "";

        switch (opcion)
        {
            case "1":
                Console.WriteLine("\n Te adentras en el bosque y de repente un bandido te ataca.");
                enemigo = "Bandido";
                break;
            case "2":
                Console.WriteLine("\n Dentro de la cueva, una araña gigante salta hacia ti.");
                enemigo = "Araña Gigante";
                break;
            case "3":
                Console.WriteLine("\n En la aldea en ruinas, un espíritu maligno te acecha.");
                enemigo = "Espíritu Maligno";
                break;
            case "4":
                Console.WriteLine("\n Al cruzar el puente antiguo, una gárgola de piedra cobra vida.");
                enemigo = "Gárgola de Piedra";
                break;
            case "5":
                Console.WriteLine("\n En el castillo abandonado, un caballero espectral bloquea tu camino.");
                enemigo = "Caballero Espectral";
                break;
            default:
                Console.WriteLine("\n Opción no válida. Un enemigo desconocido te ataca.");
                enemigo = "Enemigo Desconocido";
                break;
        }

        // El personaje realiza su acción contra el enemigo
        if (personaje is Guerrero g) g.Accion(enemigo);
        else if (personaje is Mago m) m.Accion(enemigo);

        Console.WriteLine("\n ¡Fin de la aventura!\n");
    }
}

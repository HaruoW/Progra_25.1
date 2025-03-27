using System;

class Menu
{
    private Personaje personaje;

    public void Ejecutar()
    {
        Console.WriteLine("¡Bienvenido a la aventura de texto!");
        CrearPersonaje();
        IniciarJuego();
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

    private void IniciarJuego()
    {
        Console.Write("Nombre del enemigo: ");
        string enemigo = Console.ReadLine();

        if (personaje is Guerrero g) g.Accion(enemigo);
        else if (personaje is Mago m) m.Accion(enemigo);

        Console.WriteLine("¡Fin de la aventura!");
    }
}

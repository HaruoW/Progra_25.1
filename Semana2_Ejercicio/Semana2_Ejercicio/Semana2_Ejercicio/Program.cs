using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce la vida del jugador (máx. 100): ");
        int vida = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el daño del jugador (máx. 100): ");
        int daño = int.Parse(Console.ReadLine());

        Juego juego = new Juego(vida, daño);
        juego.Iniciar();
    }
}

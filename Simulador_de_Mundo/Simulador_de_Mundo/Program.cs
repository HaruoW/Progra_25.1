class Program
{
    static void Main(string[] args)
    {
        Planet earth = new Planet { Name = "Tierra" };
        int year = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($" {earth.Name} - Año {year}");
            Console.WriteLine($"Temperatura: {earth.Temperature}°C");
            Console.WriteLine($"Nivel de vida: {earth.LifeLevel}/300");
            Console.WriteLine("\n¿Qué deseas hacer?");
            Console.WriteLine("1. Aumentar temperatura");
            Console.WriteLine("2. Disminuir temperatura");
            Console.WriteLine("3. Plantar vida");
            Console.WriteLine("4. Expande el ecosistema");
            Console.WriteLine("5. Causa un desastre");
            Console.WriteLine("6. Aprende sobre el Planeta");
            Console.WriteLine("7. Observar planeta");

            string input = Console.ReadLine();
            earth.ApplyEffect(input);

            // Avanza el turno
            earth.Update();
            year++;

            Console.WriteLine("\nPresiona una tecla para pasar al siguiente año...");
            Console.ReadKey();

            // Condición de fin
            if (earth.LifeLevel == 0)
            {
                Console.WriteLine("\n Toda la vida se ha extinguido. Fin del juego.");
                break;
            }

            if (earth.LifeLevel >= 300)
            {
                Console.WriteLine("\n Tu planeta está lleno de vida. ¡Has ganado!");
                break;
            }
        }
    }
}

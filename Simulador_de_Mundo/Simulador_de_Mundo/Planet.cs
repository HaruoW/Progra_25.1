public class Planet : SimEntity, IAffectable
{
    public int Temperature { get; set; } = 15;  // Grados Celsius
    public int LifeLevel { get; set; } = 0;     // Nivel de vida 

    public override void Update()
    {
        // Vida aumenta si las condiciones son buenas
        if (Temperature >= 10 && Temperature <= 30)
            LifeLevel += 5;
        else
            LifeLevel -= 5;

        // Limitar valor de Vida
        LifeLevel = Math.Clamp(LifeLevel, 0, 300);
    }

    public void ApplyEffect(string action)
    {
        switch (action)
        {
            case "1":
                Temperature += 5;
                Console.WriteLine("Aumentaste la temperatura.");
                break;

            case "2":
                Temperature -= 5;
                Console.WriteLine("Disminuiste la temperatura.");
                break;

            case "3":
                LifeLevel += 10;
                Console.WriteLine("Plantaste vida.");
                break;

            case "4":
                if (LifeLevel > 50)
                {
                    LifeLevel += 10;
                    Console.WriteLine("Expansión de ecosistemas exitosa.");
                }
                else
                {
                    Console.WriteLine("No hay suficiente vida para expandir.");
                }
                break;

            case "5":
                Temperature += 10;
                LifeLevel -= 20;
                Console.WriteLine("¡Erupción volcánica! Aumento de temperatura, la vida sufre.");
                break;

            case "6":
                Console.WriteLine("Parece que la vida crece mejor entre 10°C y 30°C.");
                break;

            case "7":
                Console.WriteLine("Observando el planeta...");
                Console.WriteLine($"Temperatura: {Temperature}°C | Vida: {LifeLevel}/100");
                break;

            default:
                Console.WriteLine(" Acción no reconocida.");
                break;
        }
    }
}

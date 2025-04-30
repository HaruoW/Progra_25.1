class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- Menú de Figuras ---");
            Console.WriteLine("1. Agregar Rectángulo");
            Console.WriteLine("2. Agregar Cuadrado");
            Console.WriteLine("3. Agregar Círculo");
            Console.WriteLine("4. Agregar Triángulo");
            Console.WriteLine("5. Ver todas las figuras");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Base: ");
                    double baseR = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Altura: ");
                    double alturaR = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Rectangulo(baseR, alturaR));
                    break;
                case "2":
                    Console.Write("Lado: ");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Cuadrado(lado));
                    break;
                case "3":
                    Console.Write("Radio: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Circulo(radio));
                    break;
                case "4":
                    Console.Write("Base: ");
                    double baseT = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Altura: ");
                    double alturaT = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Triangulo(baseT, alturaT));
                    break;
                case "5":
                    Console.WriteLine("\nFiguras agregadas:");
                    foreach (var figura in figuras)
                    {
                        Console.WriteLine(figura);
                    }
                    break;
                case "6":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        Console.WriteLine("¡Programa finalizado!");
    }
}

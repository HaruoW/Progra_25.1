using Estructuras;
using Unidades;

public class Jugador
{
    public int Energia = 50;
    public List<Estructuras.Estructuras> Estructuras = new();
    public List<Unidades.Unidades> Unidades = new();
    public int EstructurasConstruidas = 1;
    public int UnidadesConstruidas = 1;
    public int EnemigosDerrotados = 0;

    public void MostrarBase()
    {
        Console.WriteLine($"\n--- ESTADO DE LA BASE ---");
        Console.WriteLine($"Energía: {Energia}");
        Console.WriteLine("Estructuras:");
        foreach (var e in Estructuras)
            Console.WriteLine($"- {e.Nombre} ({(e.Construida ? "Construida" : $"{e.TurnosRestantes} turnos restantes")})");
        Console.WriteLine("Unidades:");
        foreach (var u in Unidades)
            Console.WriteLine($"- {u.Nombre} (Vida: {u.Vida}, Daño: {u.Daño})");
        Console.WriteLine("-------------------------\n");
    }

    public int EnergiaPorTurno()
    {
        return 20 + Estructuras.OfType<Granja>().Count(g => g.Construida) * 5;
    }

    public List<Casa> CasasDisponibles()
    {
        return Estructuras.OfType<Casa>().Where(c => c.Construida && !c.Ocupada).ToList();
    }

    public void ConstruirEstructura()
    {
        Console.WriteLine("¿Qué deseas construir?\n1. Granja (50 energía)\n2. Torre (100 energía)\n3. Casa (50 energía)");
        string opcion = Console.ReadLine();
        Estructuras.Estructuras nueva = opcion switch
        {
            "1" when Energia >= 50 => new Granja(),
            "2" when Energia >= 100 => new Torre(),
            "3" when Energia >= 50 => new Casa(),
            _ => null
        };

        if (nueva == null)
        {
            Console.WriteLine("No tienes suficiente energía o entrada inválida.");
            return;
        }

        Energia -= nueva.Costo;
        Estructuras.Add(nueva);
        EstructurasConstruidas++;
        Console.WriteLine($"{nueva.Nombre} en construcción.");
    }

    public void ConstruirUnidad()
    {
        var casa = CasasDisponibles().FirstOrDefault();
        if (casa == null)
        {
            Console.WriteLine("No hay casas disponibles para nuevas unidades.");
            return;
        }

        Console.WriteLine("¿Qué unidad deseas construir?\n1. Soldado (gratis)\n2. Arquero (50 energía)");
        string opcion = Console.ReadLine();
        Unidades.Unidades nueva = opcion switch
        {
            "1" => new Soldado(),
            "2" when Energia >= 50 => new Arquero(),
            _ => null
        };

        if (nueva == null)
        {
            Console.WriteLine("Entrada inválida o energía insuficiente.");
            return;
        }

        if (nueva is Arquero) Energia -= 50;
        Unidades.Add(nueva);
        casa.Ocupada = true;
        UnidadesConstruidas++;
        Console.WriteLine($"{nueva.Nombre} reclutado.");
    }

    public void Atacar(Enemigo enemigo)
    {
        foreach (var unidad in Unidades.ToList())
        {
            if (!enemigo.Unidades.Any()) break;
            var objetivo = enemigo.Unidades[0];
            objetivo.Vida -= unidad.Daño;
            if (objetivo.Vida <= 0)
            {
                enemigo.Unidades.Remove(objetivo);
                EnemigosDerrotados++;
            }
        }

        foreach (var torre in Estructuras.OfType<Torre>().Where(t => t.Construida).ToList())
        {
            if (!enemigo.Unidades.Any()) break;
            var objetivo = enemigo.Unidades[0];
            objetivo.Vida -= torre.Daño;
            if (objetivo.Vida <= 0)
            {
                enemigo.Unidades.Remove(objetivo);
                EnemigosDerrotados++;
            }
        }
    }

    public bool SinEstructuras() => !Estructuras.Any(e => e.Construida);
}

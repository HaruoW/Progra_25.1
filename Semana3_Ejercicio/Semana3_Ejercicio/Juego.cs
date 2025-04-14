using System;

public class Juego
{
    private Jugador jugador = new();
    private Enemigo enemigo = new();
    private int turno = 1;

    public void Iniciar()
    {
        while (true)
        {
            Console.WriteLine($"\n== TURNO {turno} ==");
            jugador.Energia += jugador.EnergiaPorTurno();

            foreach (var e in jugador.Estructuras)
                if (e.TurnosRestantes > 0) e.TurnosRestantes--;

            string opcion = "";
            do
            {
                Console.WriteLine("Opciones:\n1. Ver base\n2. Construir estructura\n3. Construir unidad\n4. Iniciar combate y pasar turno");
                opcion = Console.ReadLine();
                if (opcion == "1") jugador.MostrarBase();
                else if (opcion == "2") jugador.ConstruirEstructura();
                else if (opcion == "3") jugador.ConstruirUnidad();
            }
            while (opcion != "4");

            jugador.Atacar(enemigo);
            enemigo.Turno(turno, jugador);

            if (jugador.SinEstructuras())
            {
                Console.WriteLine("¡Has perdido!");
                Console.WriteLine($"Turnos sobrevividos: {turno}");
                Console.WriteLine($"Enemigos derrotados: {jugador.EnemigosDerrotados}");
                Console.WriteLine($"Estructuras construidas: {jugador.EstructurasConstruidas}");
                Console.WriteLine($"Unidades creadas: {jugador.UnidadesConstruidas}");
                break;
            }

            turno++;
        }
    }
}

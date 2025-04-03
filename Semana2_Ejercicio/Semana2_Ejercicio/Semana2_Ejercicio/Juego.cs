using System;
using System.Collections.Generic;

public class Juego
{
    private Jugador jugador;
    private List<Enemigo> enemigos;

    public Juego(int vidaJugador, int dañoJugador)
    {
        jugador = new Jugador(vidaJugador, dañoJugador);
        enemigos = new List<Enemigo>
        {
            new EnemigoMelee(80, 15),
            new EnemigoRango(60, 10, 5),
            new EnemigoMelee(70, 12)
        };
    }

    public void Iniciar()
    {
        while (jugador.ObtenerVida() > 0 && enemigos.Exists(e => e.EstaVivo()))
        {
            Console.WriteLine("\nSelecciona un enemigo para atacar:");
            for (int i = 0; i < enemigos.Count; i++)
            {
                if (enemigos[i].EstaVivo())
                {
                    Console.WriteLine($"{i}: {(enemigos[i] is EnemigoMelee ? "Enemigo Melee" : "Enemigo Rango")} - Vida: {enemigos[i].ObtenerVida()}");
                }
            }

            int eleccion;
            while (!int.TryParse(Console.ReadLine(), out eleccion) || eleccion < 0 || eleccion >= enemigos.Count || !enemigos[eleccion].EstaVivo())
            {
                Console.WriteLine("Selección inválida, intenta de nuevo.");
            }

            enemigos[eleccion].RecibirDaño(jugador.ObtenerDaño());

            foreach (var enemigo in enemigos)
            {
                if (enemigo.EstaVivo())
                {
                    jugador.RecibirDaño(enemigo.ObtenerDaño());
                    break;
                }
            }
        }

        Console.WriteLine(jugador.ObtenerVida() > 0 ? "¡Felicidades! Has ganado." : "Has sido derrotado. Fin del juego.");
    }
}

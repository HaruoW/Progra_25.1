using System;
using System.Collections.Generic;
using System.Linq;
using Estructuras;
using Unidades;

public class Enemigo
{
    public List<Unidades.Unidades> Unidades = new();
    private List<int> primos = new() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
    private List<int> fibonacci = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
    private int fibonacciIndex = 0;

    public void Turno(int turno, Jugador jugador)
    {
        if (turno < 10) return;

        if (primos.Contains(turno))
        {
            int cantidad = fibonacci[fibonacciIndex];
            for (int i = 0; i < cantidad; i++)
                Unidades.Add(new Soldado());
            fibonacciIndex = Math.Min(fibonacciIndex + 1, fibonacci.Count - 1);
        }

        foreach (var enemigo in Unidades.ToList())
        {
           
            var objetivo = jugador.Unidades.FirstOrDefault();

            
            if (objetivo == null)
            {
                objetivo = jugador.Estructuras.OfType<Torre>().FirstOrDefault();
            }

           
            if (objetivo == null)
            {
                objetivo = jugador.Estructuras.FirstOrDefault();
            }

           
            if (objetivo is Unidades u)
            {
                u.Vida -= 10;
                if (u.Vida <= 0)
                    jugador.Unidades.Remove(u);
            }
           
            else if (objetivo is Torre t)
            {
                t.Vida -= 10;
                if (t.Vida <= 0)
                {
                    jugador.Estructuras.Remove(t);  
                }
            }
            
            else if (objetivo is Estructuras.Estructuras e)
            {
               
                if (e is IEstructuraConVida estructuraConVida)
                {
                    estructuraConVida.Vida -= 10;
                    if (estructuraConVida.Vida <= 0)
                    {
                        jugador.Estructuras.Remove(e);
                    }
                }
                else
                {
                    jugador.Estructuras.Remove(e);  
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Estructuras;
using Unidades;

public class Enemigo
{
    public List<Unidades.Unidades> Uni = new();
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
                Uni.Add(new Soldado());
            fibonacciIndex = Math.Min(fibonacciIndex + 1, fibonacci.Count - 1);
        }

        foreach (var enemigo in Uni.ToList())
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

           
            if (objetivo is Unidades.Unidades)
            {
                u.Vida -= 10;
                if (u.Vida <= 0)
                    jugador.Unidades.Remove(u);
            }
           

        }
    }
}

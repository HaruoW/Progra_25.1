namespace Estructuras
{
    public abstract class Estructuras
    {
        public string Nombre;
        public int TurnosRestantes;
        public int Costo;
        public bool Construida => TurnosRestantes <= 0;
    }


    public interface IEstructuraConVida
    {
        int Vida { get; set; }
    }

    public class Granja : Estructuras
    {
        public Granja()
        {
            Nombre = "Granja";
            TurnosRestantes = 5;
            Costo = 50;
        }
    }

    public class Torre : Estructuras, IEstructuraConVida
    {
        public int Vida { get; set; }
        public int Daño = 20;

        public Torre()
        {
            Nombre = "Torre";
            TurnosRestantes = 10;
            Costo = 100;
            Vida = 100; 
        }
    }

    public class Casa : Estructuras
    {
        public bool Ocupada = false;

        public Casa()
        {
            Nombre = "Casa";
            TurnosRestantes = 2;
            Costo = 50;
        }
    }
}

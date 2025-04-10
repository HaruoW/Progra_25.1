namespace Estructuras
{
    public abstract class Estructura
    {
        public string Nombre;
        public int TurnosRestantes;
        public int Costo;
        public bool Construida => TurnosRestantes <= 0;
    }

    public class Granja : Estructura
    {
        public Granja()
        {
            Nombre = "Granja";
            TurnosRestantes = 5;
            Costo = 50;
        }
    }

    public class Torre : Estructura
    {
        public int Vida = 100;
        public int Daño = 20;

        public Torre()
        {
            Nombre = "Torre";
            TurnosRestantes = 10;
            Costo = 100;
        }
    }

    public class Casa : Estructura
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

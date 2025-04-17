public abstract class Figura
{
    public string Nombre { get; set; }

    public Figura(string nombre)
    {
        Nombre = nombre;
    }

    public abstract double CalcularArea();
}

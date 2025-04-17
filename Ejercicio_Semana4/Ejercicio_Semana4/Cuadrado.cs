public class Cuadrado : Rectangulo
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
        : base(lado, lado)
    {
        Lado = lado;
        Nombre = "Cuadrado";
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}

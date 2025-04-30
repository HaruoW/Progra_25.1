class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseT, double altura) : base("Triángulo")
    {
        Base = baseT;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}

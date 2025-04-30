class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double baseR, double altura) : base("Rectángulo")
    {
        Base = baseR;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

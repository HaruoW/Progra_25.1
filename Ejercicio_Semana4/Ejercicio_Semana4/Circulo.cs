using System;

public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
        : base("Círculo")
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

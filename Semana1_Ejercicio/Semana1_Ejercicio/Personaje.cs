using System;

class Personaje
{
    private string nombre;
    private int energia;

    public string Nombre { get { return nombre; } }
    public int Energia { get { return energia; } }

    public Personaje(string nombre, int energia)
    {
        this.nombre = nombre;
        this.energia = energia;
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Nombre: {Nombre}, Energía: {Energia}");
    }
}

class Guerrero : Personaje
{
    public Guerrero(string nombre) : base(nombre, 100) { }

    public void Atacar()
    {
        Console.WriteLine($"{Nombre} ataca con su espada!");
    }
}

class Mago : Personaje
{
    public Mago(string nombre) : base(nombre, 80) { }

    public void LanzarHechizo()
    {
        Console.WriteLine($"{Nombre} lanza un hechizo de fuego!");
    }
}
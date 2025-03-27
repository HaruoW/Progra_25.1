using System;

class Personaje
{
    public string Nombre { get; }
    public int Energia { get; private set; }

    public Personaje(string nombre, int energia)
    {
        Nombre = nombre;
        Energia = energia;
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"{Nombre} tiene {Energia} de energía.");
    }
}
class Guerrero : Personaje
{
    public Guerrero(string nombre) : base(nombre, 100) { }

    public void Accion(string objetivo)
    {
        Console.WriteLine($"{Nombre} ataca a {objetivo} con su espada.");
    }
}

class Mago : Personaje
{
    public Mago(string nombre) : base(nombre, 80) { }

    public void Accion(string objetivo)
    {
        Console.WriteLine($"{Nombre} lanza un hechizo a {objetivo}.");
    }
}


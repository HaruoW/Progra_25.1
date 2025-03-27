using System;



class Mago : Personaje
{
    public Mago(string nombre) : base(nombre, 80) { }

    public void Accion(string objetivo)
    {
        Console.WriteLine($"{Nombre} lanza un hechizo a {objetivo}.");
    }
}


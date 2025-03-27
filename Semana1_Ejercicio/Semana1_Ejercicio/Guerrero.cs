using System;


class Guerrero : Personaje
{
    public Guerrero(string nombre) : base(nombre, 100) { }

    public void Accion(string objetivo)
    {
        Console.WriteLine($"{Nombre} ataca a {objetivo} con su espada.");
    }
}



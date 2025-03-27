using System;

class Clase
{


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


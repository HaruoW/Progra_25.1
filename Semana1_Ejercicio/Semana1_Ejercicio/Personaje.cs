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



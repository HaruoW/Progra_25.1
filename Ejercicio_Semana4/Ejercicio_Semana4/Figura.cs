﻿using System;
using System.Collections.Generic;

abstract class Figura
{
    public string Nombre { get; set; }

    public Figura(string nombre)
    {
        Nombre = nombre;
    }

    public abstract double CalcularArea();

    public override string ToString()
    {
        return $"{Nombre} - Área: {CalcularArea():0.00}";
    }
}

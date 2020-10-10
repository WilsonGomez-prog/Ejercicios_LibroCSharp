using System;

public class Ejercicio10_3
{
    public Ejercicio10_3()
    {

    }
}

class Poligono
{
    public int Lados { get; set; }
    public float MedidaLados { get; set; }

    public Poligono()
    {
        Lados = 0;
        MedidaLados = 0.0f
    }

    public Poligono(int CantLado, float LongitudLado)
    {
        Lados = CantLado;
        MedidaLados = LongitudLado;
    }
}
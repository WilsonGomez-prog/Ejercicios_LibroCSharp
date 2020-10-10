using System;

public class Ejercicio10_4
{
    public Ejercicio10_4()
    {

    }
}

class Poligono
{
    private int Lados;
    private float MedidaLados;

    public Poligono()
    {
        Lados = 0;
        MedidaLados = 0.0f
    }

    public Poligono(int CantLado, float LongitudLado)
    {
        if (CantLado <= 2)
        {
            Lados = CantLado;
        }
        
        if (LongitudLado <= 0)
        {
            MedidaLados = LongitudLado;
        }
    }

    public int Lados
    {
        get
        {
            return Lados;
        }
        set
        {
            if (value <= 0)
            {
                Lados = 3;
            }
            else
            {
                Lados = value;
            }
        }
    }

    public float MedidaLados
    {
        get
        {
            return MedidaLados;
        }
        set
        {
            if (value <= 0)
            {
                MedidaLados = 3;
            }
            else
            {
                MedidaLados = value;
            }
        }
    }
}
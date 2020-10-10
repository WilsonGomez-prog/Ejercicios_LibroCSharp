using System;
using System.Math;

public class Ejercicio10_5
{
    public Ejercicio10_5()
    {

    }
}

class Poligono
{
    private int Lados;
    private double MedidaLados;
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public Poligono()
    {
        Lados = 0;
        MedidaLados = 0.0
    }

    public Poligono(int CantLado, double LongitudLado)
    {
        if (CantLado <= 2)
        {
            Lados = CantLado;
        }
        
        if (LongitudLado <= 0)
        {
            MedidaLados = LongitudLado;
        }

        Perimetro = CalcularPerimetro();
        Area = CalcularArea();
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

    public double MedidaLados
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

    public void CalcularArea()
    {
        double angCentral = 360/Lados;
        double apotema = Lados/(2 * Tan((angCentral/2)));
        
        Area = (Perimetro*apotema)/2;

    }

    public void CalcularPerimetro()
    {
        Perimetro = Lados*MedidaLados;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat($"Poligono: \n\tLados del polígono: {Lados}\n\tMedidas de los lados: {MedidaLados} \n\tÁrea del polígono: {Area}\n\tPerímetro del polígono: {Perimetro}");
        return (sb.ToString());
    }
}
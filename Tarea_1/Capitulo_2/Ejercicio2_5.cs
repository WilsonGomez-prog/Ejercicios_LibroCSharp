using System;
class Ejercicio2_5
{
    public Ejercicio2_5()
    {
        float cambio, monto_dolar, monto_euros;
        var fecha = DateTime.Now;
        Console.WriteLine("Binevenido, este programa esta diseñado para hacer conversion de moneda entre dolar y euro.");
        Console.Write("Ingrese el precio del dolar en euros: ");
        cambio = Convert.ToSingle(Console.ReadLine());
        Console.Write("Ingrese el monto en dolares que desea cambiar: ");
        monto_dolar = Convert.ToSingle(Console.ReadLine());
        monto_euros = monto_dolar * cambio;
        Console.WriteLine("Al dia de hoy ({0}) el valor del dolar en euros es de: {1} EUR \nEl monto en dolares que deseó cambiar USD$ {2} en euros vale: {3} EUR", fecha.Date, cambio, monto_dolar, monto_euros);
    }
}


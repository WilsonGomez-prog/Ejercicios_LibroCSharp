using System;

public class Ejercicio8_5
{
    public Ejercicio8_5()
    {
        Init_class();
    }

    public void Init_class()
    {
        Console.WriteLine("Bienvenido, este es un programa destinado a organizar por orden alfabetico dos candenas que sean ingresadas.");

        string[] cad = new string[2];

        for(int i = 1; i <= cad.Length; i++)
        {
            Console.Write($"Ingrese la palabra para la cadena #{i}: ");
            cad[i-1] = Console.ReadLine();
        }

        Console.WriteLine("Las cadenas ingresadas fueron: ");
        Mostrar(cad);

        Intercambiar(ref cad);

        Console.WriteLine("Aqui estan las cadenas ordenadas alfabeticamente: ");
        Mostrar(cad);
    }

    public void Mostrar(string[] cadena)
    {
        for(int i = 0; i < cadena.Length; i++)
        {
            Console.WriteLine(cadena[i]);
        }
    }

    public void Intercambiar(ref string[] cadena)
    {
        if(String.Compare(cadena[0], cadena[1]) < 0)
        {
            var comodin = cadena[0];
            cadena[0] = cadena[1];
            cadena[1] = comodin;
        }
    }
}
using System;
using System.Collections;

public class Ejercicio7_2
{
    public Ejercicio7_2()
    {
        string palabra = "", definicion = "", res = "";
        Hashtable diccionario = new Hashtable();

        do
        {
            Console.Write("Ingrese la palabra que desee definir: ");
            palabra = Console.ReadLine();

            Console.Write($"Ingrese la definicion de dicha palabra({palabra}): ");
            definicion = Console.ReadLine();

            diccionario.Add(palabra, definicion);

            Console.WriteLine("Desea continuar agregando definiciones al diccionario? (Si/No)");
            res = Console.ReadLine();
        } 
        while (res == "Si" || res == "SI" || res == "si" || res == "sI");

        do
        {
            Console.Write("Ingrese la palabra que desee buscar en el diccionario: ");
            palabra = Console.ReadLine();

            if (diccionario.Contains(palabra))
            {
                definicion = diccionario.Item[palabra];
            }

            Console.WriteLine($"La definicion de {palabra} es: {definicion}");

            Console.WriteLine("Desea continuar buscando definiciones? (Si/No)");
            res = Console.ReadLine();
        } 
        while (res == "Si" || res == "SI" || res == "si" || res == "sI");
    }
}
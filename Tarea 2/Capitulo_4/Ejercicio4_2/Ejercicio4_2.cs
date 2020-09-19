using System;

class Ejercicio4_2
{
    public Ejercicio4_2()
    {
        int base_potencia, exponente, resultado = 1;
        Console.WriteLine("Bienvienido, este es un programa diseñado para calcular la potencia de el numero que ingrese.");
        
        Console.Write("Ingrese el numero que desea elevar: ");
        base_potencia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la potencia a la que lo va a elevar: ");
        exponente = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i <= exponente; i++)
        {
            resultado*=base_potencia;
        }

        Console.WriteLine($"El numero ingresado ({base_potencia}) elevado a la potencia({exponente}) es igual a = {resultado}");
    }
}


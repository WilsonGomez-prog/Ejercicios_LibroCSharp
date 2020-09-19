using System;

class Ejercicio2_4
{
    public Ejercicio2_4()
    {
        float centigrados, fahrenheit;
        
        Console.WriteLine("Bienvenido, este es un programa que convierte de grados centigrados a grados fahrenheit.");
        
        Console.Write("Ingrese la temperatura en grados centigrados que desea convertir: ");
        centigrados = Convert.ToSingle(Console.ReadLine());

        fahrenheit = (float)(centigrados * 1.8) + 32;
        
        Console.WriteLine("La temperatura ingresada({0}), en grados Fahrenheit es: {1}", centigrados, fahrenheit);
    }
}


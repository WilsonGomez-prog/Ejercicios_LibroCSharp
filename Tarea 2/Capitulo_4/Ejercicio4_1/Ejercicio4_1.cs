using System;

class Ejercicio4_1
{
    public Ejercicio4_1()
    {
        int numero;
        Console.WriteLine("Bienvienido, este es un programa diseñado para mostrar \nla tabla de multiplicación del 1 al 10 del numero que desee.");
        
        Console.Write("Ingrese el numero del que desea ver la tabla: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero*i}");
        }
    }
}


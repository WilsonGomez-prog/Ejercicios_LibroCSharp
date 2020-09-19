using System;

class Ejercicio4_5
{
    public Ejercicio4_5()
    {
        int mayor = 0, menor = 123, ac = 0, edad, personas_cant = 0;
        float promedio;
        string res = "";
        Console.WriteLine("Bienvienido, este es un programa diseñado para calcular \nel promedio de edad de un grupo de personas, ademas del mayor y el menor del grupo.");
        
        do
        {
            Console.Write("Ingrese la edad de la persona: ");
            edad = Convert.ToInt32(Console.ReadLine());
            
            if(edad > mayor)
            {
                mayor = edad;
            }
            else if(edad < mayor && edad < menor)
            {
                menor = edad;
            }

            personas_cant++;
            ac+=edad;
            
            Console.Write("¿Desea continuar ingresando edades?(Si/No) ");
            res = Console.ReadLine().Trim();

        } while (res == "Si" || res == "SI" || res == "si" || res == "sI");
        
        promedio = ac/personas_cant;

        Console.WriteLine($"Del grupo de {personas_cant} que ingresó:");
        Console.WriteLine($"\tEl promedio de edad es de: {promedio} años.");
        Console.WriteLine($"\tLa persona mas vieja tiene: {mayor} años.");
        Console.WriteLine($"\tLa persona mas joven tiene: {menor} años.");
    }
}
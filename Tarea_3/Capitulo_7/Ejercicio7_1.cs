using System;
using System.Collections;

public class Ejercicio7_1
{
    public Ejercicio7_1()
    {
        ArrayList salon = new ArrayList();
        int cont = 1;
        float suma = 0.0f, promedio = 0.0f;
        float[] extremos = new float[]{100.0f, 0.0f};
        string res = "";

        do
        {
            Console.Write($"Ingrese la calificacion del alumno {cont}: ");
            salon.Add(Convert.ToSingle(Console.ReadLine()));

            if(Convert.ToSingle(salon[cont-1]) > extremos[1])
            {
                extremos[1] = Convert.ToSingle(salon[cont-1]);
            }
            else if(Convert.ToSingle(salon[cont-1]) < extremos[1] && Convert.ToSingle(salon[cont-1]) < extremos[0])
            {
                extremos[0] = Convert.ToSingle(salon[cont-1]);
            }

            Console.WriteLine("Desea continuar agregando alumnos al salon? (Si/No)");
            res = Console.ReadLine();
        } 
        while (res == "Si" || res == "SI" || res == "si" || res == "sI");

        foreach (var nota in salon)
        {
            suma+=Convert.ToSingle(nota);
        }
        promedio = suma/salon.Count;

        Console.WriteLine($"El promedio de claificacion del curso es de: {promedio} puntos.");
        Console.WriteLine($"La calificacion mas alta del curso es de: {extremos[1]} puntos.");
        Console.WriteLine($"La calificacion mas baja del curso es de: {extremos[0]} puntos.");
    }
}
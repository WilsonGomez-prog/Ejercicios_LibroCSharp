using System;

public class Ejercicio6_2
{
    public Ejercicio6_2()
    {
        int cantidad = 0, salones = 0, ac = 0;

        float promedio = 0.0f, promedioGen = 0.0f, minima = 101.0f;

        Console.Write("Ingrese la cantidad de salones que hay en la escuela: ");
        salones = Convert.ToInt32(Console.ReadLine());

        float[][] calif = new float[salones][];

        for (int i = 0; i < salones; i++)
        {
            Console.Write($"Ingrese la cantidad de alumnos del salon {i+1}: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            calif[i] = new float[cantidad];
        }

        for (int i = 0; i < salones; i++)
        {
            Console.WriteLine($"Salon {i+1}");
            for (int j = 0; j < calif[i].GetLength(0); j++)
            {
                Console.Write($"Ingrese la calificacion del estudiante {i+1}: ");
                calif[i][j] = Convert.ToSingle(Console.ReadLine());
            }
        }

        Console.WriteLine("__Información__");
        for (int i = 0; i < salones; i++)
        {
            Console.WriteLine($"Salon {i+1}");
            for (int j = 0; j < calif[i].GetLength(0); j++)
            {
                Console.Write($"El alumno {j} tiene una calificación de {calif[i][j]} puntos");
            }
        }

        Console.WriteLine("__Promedio por curso__");
        for (int i = 0; i < salones; i++)
        {
            Console.Write($"Salon {i+1}: ");
            for (int j = 0; j < calif[i].GetLength(0); j++)
            {
                promedio+=calif[i][j];
                promedioGen+=calif[i][j];
                ac+=1;

                if(calif[i][j] < minima)
                {
                    minima = calif[i][j];
                }
            }
            Console.WriteLine($"{promedio/calif[i].GetLength(0)} puntos.");
            promedio = 0.0f;
        }
        Console.WriteLine($"El promedio general de la escuela es de {promedioGen/ac} puntos.");
        Console.WriteLine($"La calificacion mas baja de la escuela es: {minima}");
    }  
}
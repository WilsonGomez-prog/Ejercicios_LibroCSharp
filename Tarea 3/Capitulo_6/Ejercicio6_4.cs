using System;

public class Ejercicio6_4
{
    public Ejercicio6_4()
    {
        Init_class();
    }

    public void Init_class()
    {
        int cantidad = 0, salones = 0;

        float suma = 0.0f, promedioGen = 0.0f, minima = 101.0f, maxima = 0.0f;
        float[] promedio;

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


        promedio = PromedioCurso(calif, salones, suma);
        promedioGen = PromedioEscuela(promedio, suma);
        NotasMayorMenor(calif, salones, ref minima, ref maxima);

        Console.WriteLine("El promedio por curso quedo asi: ");
        for (int i = 0; i < promedio.GetLength(0); i++)
        {
            Console.WriteLine($"Salon {i}: {promedio[i]} puntos.");
        }
        Console.WriteLine($"El promedio general de la escuela es: {promedioGen} puntos");
        Console.WriteLine($"La nota mas alta de la escuela es de {maxima} puntos.");
        Console.WriteLine($"La nota mas baja de la escuela es de {minima} puntos.");
    }

    public float PromedioEscuela(float[] cursosProm, float suma)
    {
        Console.WriteLine("__Promedio por curso__");
        for (int i = 0; i < cursosProm.GetLength(0); i++)
        {
            suma+=cursosProm[i];
        }

        return suma/cursosProm.GetLength(0);
    }

    public float[] PromedioCurso(float[][] escuela, int salones, float suma)
    {
        float[] curso = new float[salones];
        int acontador = 0;
        for (int i = 0; i < salones; i++)
        {
            for (int j = 0; j < escuela[i].GetLength(0); j++)
            {
                suma+=escuela[i][j];
                acontador++;
            }
            curso[i] = suma/acontador;
            suma = acontador = 0;
        }
        return curso;
    }

    public void NotasMayorMenor(float[][] escuela, int salones, ref float minima, ref float maxima)
    {
        for (int i = 0; i < salones; i++)
        {
            for (int j = 0; j < escuela[i].GetLength(0); j++)
            {
                if(escuela[i][j] > maxima)
                {
                    maxima = escuela[i][j];
                }
                else if(escuela[i][j] < maxima && escuela[i][j] < minima)
                {
                    minima = escuela[i][j];
                }
            }
        }
    }  
}
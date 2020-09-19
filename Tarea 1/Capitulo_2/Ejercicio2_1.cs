using System;

class Ejercicio2_1
{
    public Ejercicio2_1()
    {
        int cantidad_lado;
        float medida_lado, perimetro;

        Console.WriteLine("Bienvenido, este programa calcula el perimetro de cualquier poligono regular");
        
        Console.Write("Porfavor ingrese el numero de lados del poligono: ");
        cantidad_lado = Convert.ToInt32(Console.ReadLine());
        Console.Write("Porfavor ingrese la medida de lados del poligono: ");
        medida_lado = Convert.ToSingle(Console.ReadLine());

        perimetro = cantidad_lado * medida_lado;

        Console.WriteLine("El perimetro del poligono introducido es: {0}", perimetro);
    }
}


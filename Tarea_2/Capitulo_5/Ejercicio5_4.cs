using System;
class Ejercicio5_4
{
    private int numero;
    private int factorial;

    public Ejercicio5_4()
    {
        Init_class();
    }
    public int Calc_factorial(int factorial)
    {
        int resultado = 1;

        for (int i = 1; i <= factorial; i++)
        {
            resultado*=i;
        }

        return resultado;
    }

    public void Init_class()
    {
        
        Console.WriteLine("Bienvenido, este programa calcula el factorial de el numero que desee.");
        Console.Write("Ingrese el numero que desee calcular: ");
        numero = Convert.ToInt32(Console.ReadLine());
        factorial = Calc_factorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}
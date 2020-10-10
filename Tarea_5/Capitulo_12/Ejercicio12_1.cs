public class Ejercicio12_1
{
    public Ejercicio12_1()
    {
        initClass();
    }

    public void init_Class()
    {
        int numero, factorial;
        Console.WriteLine("Bienvienido, este es un programa diseñado para calcular y mostrar el valor del factorial del numero que ingrese.");
        
        Console.Write("Ingrese el numero del que desea ver el factorial: ");
        numero = Convert.ToInt32(Console.ReadLine());

        CalcFactorial(numero, factorial);

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    public int CalcFactorial(int numero, ref int producto)
    {
        producto = 1;

        for (int i = numero; i >= 1; i--)
        {
            producto*=i;
        }
    }
}
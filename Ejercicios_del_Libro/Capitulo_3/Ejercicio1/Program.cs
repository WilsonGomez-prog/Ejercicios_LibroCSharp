using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Bienvenido, este programa esta diseñado para verificar si un numero es par o impar.");
            Console.Write("Ingrese el numero que desea verificar: ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par.");

            }
            else
            {
                Console.WriteLine("El numero ingresado no es par.");
            }
            Console.WriteLine("Numero ingresado: {0}", num);
        }
    }
}

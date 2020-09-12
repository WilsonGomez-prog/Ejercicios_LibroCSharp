using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float grados, rad;
            Console.WriteLine("Bienvenido, este programa se encarga para convertir un valor en grados a radianes.");
            Console.Write("Ingrese el valor en grados que desea convertir: ");
            grados = Convert.ToSingle(Console.ReadLine());

            rad = (float)(grados * Math.PI)/180;
            Console.WriteLine("La conversion de {0} grados a radianes resulto en {1} radian/nes", grados, rad);
        }
    }
}

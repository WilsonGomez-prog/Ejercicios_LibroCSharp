using System;

namespace Ejercicios_LibroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            Console.WriteLine("Bienvenido al portafolio de tareas del libro C# - Guia total del programador.");
            Console.WriteLine("Creado por: Wilson Alfonso Gómez Santiago  ----------> 2018-0581");
            
            do
            {
                Menu();
                
                Console.Write("¿Desea volver al menu de nuevo?(Si/No) ");
                res = Console.ReadLine().Trim();

            } while (res == "Si" || res == "SI" || res == "si" || res == "sI");
            Console.Clear();
            Console.WriteLine("¡Pase buen resto del dia!.");
        }

        static void Menu()
        {
            string op;
            Console.WriteLine("\t\tMENÚ");
            Console.WriteLine("Tarea #1:");
            Console.WriteLine("\tCapitulo 1:\n\t\t1a - Ejercicio #1\n\t\t1b - Ejercicio #5");
            Console.WriteLine("\tCapitulo 2:\n\t\t2a - Ejercicio #1\n\t\t2b - Ejercicio #3\n\t\t2c - Ejercicio #4\n\t\t2d - Ejercicio #5");
            Console.WriteLine("\tCapitulo 3:\n\t\t3a - Ejercicio #1\n\t\t3b - Ejercicio #4");
            Console.WriteLine("Tarea #2:");
            Console.WriteLine("\tCapitulo 4:\n\t\t4a - Ejercicio #1\n\t\t4b - Ejercicio #2\n\t\t4c - Ejercicio #5");
            Console.WriteLine("\tCapitulo 5:\n\t\t5a - Ejercicio #4\n\t\t5b - Ejercicio #5");
            Console.WriteLine("Tarea #3:");
            Console.WriteLine("\tCapitulo 6:\n\t\t6a - Ejercicio #1\n\t\t6b - Ejercicio #2\n\t\t6c - Ejercicio #3\n\t\t6d - Ejercicio #4\n\t\t6e - Ejercicio #5");
            Console.WriteLine("\tCapitulo 7:\n\t\t7a - Ejercicio #1\n\t\t7b - Ejercicio #2\n\t\t7b - Ejercicio #5");
            Console.WriteLine("Tarea #4:");
            Console.WriteLine("\tCapitulo 8:\n\t\t8a - Ejercicio #3\n\t\t8b - Ejercicio #5");
            Console.WriteLine("\tCapitulo 9:\n\t\t9a - Ejercicio #1\n\t\t9b - Ejercicio #3\n\t\t9c - Ejercicio #4");
            Console.Write("Ingrese la opcion que desee: ");
            op = Console.ReadLine();
            Console.Clear();
            switch (op)
            {
                case "1a":
                    new Ejercicio1_1();
                    break;

                case "1b":
                    new Ejercicio1_5();
                    break;

                case "2a":
                    new Ejercicio2_1();
                    break;

                case "2b":
                    new Ejercicio2_3();
                    break;

                case "2c":
                    new Ejercicio2_4();
                    break;

                case "2d":
                    new Ejercicio2_5();
                    break;

                case "3a":
                    new Ejercicio3_1();
                    break;

                case "3b":
                    new Ejercicio3_4();
                    break;

                case "4a":
                    new Ejercicio4_1();
                    break;

                case "4b":
                    new Ejercicio4_2();
                    break;

                case "4c":
                    new Ejercicio4_5();
                    break;

                case "5a":
                    new Ejercicio5_4();
                    break;
                
                case "5b":
                    new Ejercicio5_5();
                    break;
                
                case "6a":
                    new Ejercicio6_1();
                    break;

                case "6b":
                    new Ejercicio6_2();
                    break;

                case "6c":
                    new Ejercicio6_3();
                    break;
                
                case "6d":
                    new Ejercicio6_4();
                    break;

                case "6e":
                    new Ejercicio6_5();
                    break;

                case "7a":
                    new Ejercicio7_1();
                    break;

                case "7b":
                    new Ejercicio7_2();
                    break;

                case "7c":
                    new Ejercicio7_5();
                    break;

                case "8a":
                    new Ejercicio8_3();
                    break;

                case "8b":
                    new Ejercicio8_5();
                    break;

                case "9a":
                    new Ejercicio9_1();
                    break;

                case "9b":
                    new Ejercicio9_3();
                    break;

                case "9c":
                    new Ejercicio9_4();
                    break;
                default:
                    Console.WriteLine("La opción ingresada aún no esta contemplada dentro de los casos.");
                    break;
            }
        }
    }
}
    
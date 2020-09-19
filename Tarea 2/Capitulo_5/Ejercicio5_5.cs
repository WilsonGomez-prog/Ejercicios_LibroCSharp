using System;

class Ejercicio5_5
{
    private string cadena;
    private int num;
    public Ejercicio5_5()
    {
        Init_class();
    }

    public void cadenas_num(int num, ref string cadena)
    {
        switch (num)
        {
            case 0:
                cadena = "Cero";
                break;

            case 1:
                cadena = "Uno";
                break;

            case 2:
                cadena = "Dos";
                break;

            case 3:
                cadena = "Tres";
                break;

            case 4:
                cadena = "Cuatro";
                break;

            case 5:
                cadena = "Cinco";
                break;

            case 6:
                cadena = "Seis";
                break;

            case 7:
                cadena = "Siete";
                break;

            case 8:
                cadena = "Ocho";
                break;

            case 9:
                cadena = "Nueve";
                break;

            case 10:
                cadena = "Diez";
                break;

            case 11:
                cadena = "Once";
                break;

            case 12:
                cadena = "Doce";
                break;

            default:
                Console.WriteLine("El numero ingresado no esta contemplado en el rango. (0-12)");
                break;
        }
    }

    public void Init_class()
    {
        Console.WriteLine("Bienvenido, este programa devuelve en una cadena el nombre del numero ingresado.");
        Console.Write("Ingrese el numero que desee calcular: ");
        num = Convert.ToInt32(Console.ReadLine());
        cadenas_num(num, ref cadena);
        Console.WriteLine($"El numero ingresado ({num}) es: {cadena}");
    }
}


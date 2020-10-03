using System;

public class Ejercicio9_4
{
    public Ejercicio9_4()
    {
        Init_class();
    }

enum neumaticos {Verano, invierno, TodoTiempo, Todoterreno, ParaCoche, ParaFurgoneta, PerfilBajo, PerfilAncho, RunFlat, Tubuless, Recauchutados, Verdes, Radiales, Diagonales}
    public void Init_class()
    {
        neumaticos llantas = neumaticos.Verano;
        Console.WriteLine("Bienvenido, este es un programa diseñado para dar una lista de los tipos de neumaticos.");
        Console.WriteLine("Ingrese el número que represente el elemento de la lista que desea ver: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                llantas = neumaticos.Verano;
                break;
            
            case 2:
                llantas = neumaticos.invierno;   
                break;
            
            case 3:
                llantas = neumaticos.TodoTiempo;
                break;
            
            case 4:
                llantas = neumaticos.Todoterreno;
                break;
            
            case 5:
                llantas = neumaticos.ParaCoche;
                break;
            
            case 6:
                llantas = neumaticos.ParaFurgoneta;
                break;
            
            case 7:
                llantas = neumaticos.PerfilBajo;
                break;
            
            case 8:
                llantas = neumaticos.PerfilAncho;
                break;
            
            case 9:
                llantas = neumaticos.RunFlat;
                break;
            
            case 10:
                llantas = neumaticos.Tubuless;
                break;
            
            case 11:
                llantas = neumaticos.Recauchutados;
                break;
            
            case 12:
                llantas = neumaticos.Verdes;
                break;
            
            case 13:
                llantas = neumaticos.Radiales;
                break;
            
            case 14:
                llantas = neumaticos.Diagonales;
                break;
            
            default:
                Console.WriteLine("La opción ingresada no esta contemplada, el rango contemplado es 1-14.");
                break;
        }
        
        Console.WriteLine(llantas.ToString());
    }
}
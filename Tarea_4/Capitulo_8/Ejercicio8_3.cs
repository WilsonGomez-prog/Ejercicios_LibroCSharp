using System;

public class Ejercicio8_3
{
    public Ejercicio8_3()
    {
        Init_class();
    }

    public void Init_class()
    {
        Console.WriteLine("Bienvenido, este es un programa destinado a darte la hora actual en formato AM/PM al igual que la fecha actual en formato AA/DD/MM ");
        
        Console.WriteLine(String.Format($"La hora es:{DateTime.Now:h tt} y la fecha es: {DateTime.Now:yyyy ddd MMM}."));
        
        Console.WriteLine("Pase buen resto de su dia.");
    }
}
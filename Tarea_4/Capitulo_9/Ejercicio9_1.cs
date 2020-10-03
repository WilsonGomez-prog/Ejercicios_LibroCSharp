using System;
using System.Collections.Generic;
using System.Text;

public class Ejercicio9_1
{
    public Ejercicio9_1()
    {
        Init_class();
    }

    public void Init_class()
    {
        string res = "";
        int con = 1;
        List<Articulos> MisArticulos = new List<Articulos>();

        do
        {
            Registrar(ref MisArticulos);

            Console.Write("¿Desea volver a registrar un articulo?(Si/No) ");
            res = Console.ReadLine().Trim();
        } 
        while (res == "Si" || res == "SI" || res == "si" || res == "sI");


        Console.WriteLine("Articulos registrados:");

        foreach (Articulos animal in MisArticulos)
        {   
            Console.WriteLine($"Mascota #{con}");
            animal.ToString();
            con++;
        }

    }
    
    public struct Articulos
    {
        string nombre;
        string descripcion;
        double precioUnit; 

        public Articulos(string Nombre, string Descripcion, double Precio)  
        {
            nombre = Nombre;
            descripcion = Descripcion;
            precioUnit = Precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\nNombre del articulo: {nombre} \nDescripcion del articulo: {descripcion} \nPrecio del articulo: {precioUnit}");
            return (sb.ToString());
        }
    }

    public void Registrar(ref List<Articulos> articulos)
    {
        string nombre = "";
        string descripcion = "";
        double precio = 0.0;

        Console.Write("Ingrese el nombre del articulo: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese la descripción del articulo: ");
        descripcion = Console.ReadLine();
        Console.Write("Ingrese el precio del articulo: ");
        precio = Convert.ToDouble(Console.ReadLine());

        articulos.Add(new Articulos(nombre,descripcion, precio));
    }
}
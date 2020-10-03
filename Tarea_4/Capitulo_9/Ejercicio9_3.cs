using System;
using System.Collections.Generic;
using System.Text;

public class Ejercicio9_3
{
    public Ejercicio9_3()
    {
        Init_class();
    }

    public void Init_class()
    {
        List<Mascota> ListaMascotas = new List<Mascota>();
        string res = "";
        int con = 1;

        do
        {
            RegistrarMascota(ref ListaMascotas);

            Console.Write("¿Desea volver a registrar una mascota?(Si/No) ");
            res = Console.ReadLine().Trim();
        } 
        while (res == "Si" || res == "SI" || res == "si" || res == "sI");


        Console.WriteLine("Mascotas registradas:");

        foreach (Mascota animal in ListaMascotas)
        {   
            Console.WriteLine($"Mascota #{con}");
            animal.ToString();
            con++;
        }

    }

    public struct Direccion
    {
        int casaNum;
        string calle;
        string ciudad;
        string provincia;
        string pais;

        public Direccion(string domicilio)
        {
            string[] direccion = domicilio.Split(new char[] {'/'});
            casaNum = Convert.ToInt32(direccion[0]);
            calle = direccion[1];
            ciudad = direccion[2];
            provincia = direccion[3];
            pais = direccion[4];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\n\t\tCalle: {calle} \n\t\tCasa #: {casaNum} \n\t\tCiudad: {ciudad} \n\t\tProvincia: {provincia} \n\t\tPais: {pais}");
            return (sb.ToString());
        }
    }

    public struct Dueno
    {
        string nombreCompleto;
        string cedula;
        int edad;
        char sexo;
        Direccion domicilio;

        public Dueno(string Cedula, string Nombre, char genero, Direccion Domicilio, int Edad)
        {
            nombreCompleto = Nombre;
            cedula = Cedula;
            edad = Edad;
            sexo = genero;
            domicilio = Domicilio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\n\tNombre: {nombreCompleto} \n\tCedula: {cedula} \n\tEdad: {edad} \n\tSexo: {sexo} \n\tDireccion: {domicilio.ToString()}");
            return (sb.ToString());
        }
    }

    public struct Mascota
    {
        Dueno propietario;
        string nombre;
        string tipoAnimal;
        DateTime fechaNacimiento;
        int edad;

        public Mascota(Dueno prop, string Nombre, string tipo, DateTime nacimiento, int Edad)
        {
            nombre = Nombre;
            propietario = prop;
            tipoAnimal = tipo;
            fechaNacimiento = nacimiento;
            edad = Edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"\nNombre de la mascota: {nombre} \nTipo de animal: {tipoAnimal} \nFecha de nacimiento: {fechaNacimiento.ToString()} \nEdad: {edad} \nInformacion del dueño: {propietario.ToString()}");
            return (sb.ToString());
        }
    }

    public void RegistrarMascota(ref List<Mascota> mascotas)
    {
        string nombreMascota = "";
        string[] dueno = new string[5];
        string tipo = "";
        DateTime fecha;
        int edad = 0;
        Dueno propietario;
        Direccion domicilio;

        // Datos de la mascota
        Console.Write("Ingrese el nombre de la mascota: ");
        nombreMascota = Console.ReadLine();
        Console.Write("Ingrese el tipo de animal que es: ");
        tipo = Console.ReadLine();
        Console.Write("Ingrese la fecha de nacimiento del animal: ");
        fecha = Convert.ToDateTime(Console.ReadLine());
        edad = DateTime.Now.Year - fecha.Year;
        
        // Datos del dueño
        Console.Write("Ingrese el nombre del dueño de la mascota: ");
        dueno[0] = Console.ReadLine();
        Console.Write("Ingrese la cedula del dueño: ");
        dueno[1] = Console.ReadLine();
        Console.Write("Ingrese la edad del dueño: ");
        dueno[2] = Console.ReadLine();
        Console.Write("Ingrese el sexo del dueño: ");
        dueno[3] = Console.ReadLine();
        Console.Write("Ingrese la direccion dueño con el siguiente formato (# de casa/Calle/Ciudad/Provincia/Pais): ");
        dueno[4] = Console.ReadLine();

        domicilio = new Direccion(dueno[4]);
        propietario = new Dueno(dueno[1],dueno[0],Convert.ToChar(dueno[3]),domicilio, Convert.ToInt32(dueno[2]));
        mascotas.Add(new Mascota(propietario, nombreMascota, tipo, fecha, edad));
    }
    
}
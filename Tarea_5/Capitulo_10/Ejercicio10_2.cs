using System;

public class Ejercicio10_2
{
    public Ejercicio10_2()
    {

    }
}

class Estudiantes
{
    public int CodigoEscolar { get; set; }
    public string NombreCompleto { get; set; }
    public int Edad { get; set; }
    public string Nivel { get; set; }
    public string Curso { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }
    public double MontoMensualidad { get; set; }
    public string NombreTutor { get; set; }
    public string TelefonoTutor { get; set; }
    public string CorreoTutor { get; set; }


    public Estudiantes()
    {
        CodigoEscolar = 0;
        NombreCompleto = "";
        Edad = 0;
        Nivel = "";
        Curso = "";
        Direccion = "";
        Telefono = "";
        CorreoElectronico = "";
        MontoMensualidad = 0.0;
        NombreTutor = "";
        TelefonoTutor = "";
        CorreoTutor = "";
    }

    public Estudiantes(string CodEscolar, string Nombre, int EdadEstudiante, string CursoEstudiante, string NivelAcademico, string DireccionEstudiante, string TelefonoEstudiante, string CorreoEstudiante, double Mensualidad, string NombreTutorEst, string TelefonoTutorEst, string CorreoTutorEst)
    {
        CodigoEscolar = CodEscolar;
        NombreCompleto = Nombre;
        Edad = EdadEstudiante;
        Nivel = NivelAcademico;
        Curso = CursoEstudiante;
        Direccion = DireccionEstudiante;
        Telefono = TelefonoEstudiante;
        CorreoElectronico = CorreoEstudiante;
        MontoMensualidad = Mensualidad;
        NombreTutor = NombreTutorEst;
        TelefonoTutor = TelefonoTutorEst;
        CorreoTutor = CorreoTutorEst;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat($"Estudiante: \n\tCódigo: {CodigoEscolar} \n\tNombre: {NombreCompleto} \n\tEdad: {Edad} \n\tNivel: {Nivel} \n\tCurso: {Curso} \n\tDireccion: {Direccion} \n\tTelefono: {Telefono} \n\tCorreo: {CorreoElectronico} \n\tMensualidad: {MontoMensualidad} \n\tNombre del Tutor: {NombreTutor} \n\tTelefono del Tutor: {TelefonoTutor} \n\tCorreo del Tutor: {CorreoTutor}");
        return (sb.ToString());
    }
}
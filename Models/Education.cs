using System;
using System.EnterpriseServices.Internal;

public class Education
{
    //Atributos
    public int Id { get; set; }
    public string Institution { get; set;}
    public string Degree { get; set; } // grado académico

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

//Relación con entidad 
public int StudentProfileId {get; set;} //relación con la clase StudenProfile

public StudentProfile StudentProfile {get; set;}

}
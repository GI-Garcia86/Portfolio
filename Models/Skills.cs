using System.EnterpriseServices.Internal;

public class Skills
{
    public int Id { get; set; }
    public string Name { get; set; } //en que soy hábil lenguajes, relaciones etc

    public int Level { get; set; } // 1 a 100

    public int StudentProfileId { get; set; }

    public StudentProfile StudentProfile {get; set;}

}
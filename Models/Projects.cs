using System.EnterpriseServices.Internal;

public class Projects
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string ImageUrl { get; set; }

    public int StudentProfileId { get; set; }
    public StudentProfile StudentProfile {get; set;}

}
using System.EnterpriseServices.Internal;

public class SocialLinks
{
    public int Id { get; set; }
    public string Platform { get; set; } //Red social  (Linkedin, GitHub)
    public string Url { get; set; }

    public int StudentProfileId {get; set;}

    public StudentProfile StudentProfile {get; set;}
}
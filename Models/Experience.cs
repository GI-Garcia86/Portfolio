using System;
using System.EnterpriseServices.Internal;
namespace Portfolio.Models
{ 
public class Experience
    {
        public int Id { get; set; }

        public string Company { get; set; }
        public string Position { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string Description {get; set; } //colocar una descripción 

        public int StudentProfileId {get; set;}

        public StudentProfile StudentProfile {get; set;}

    }
}
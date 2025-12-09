using Microsoft.Ajax.Utilities;
using Portfolio.Models;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;

namespace Portfolio.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }
        //Información Personal
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; } //Breve descripción de la persona

        //información de contacto
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        //imagen o avatar
        public string ProfileImageUrl { get; set; }

        //modificador virtual
        public virtual ICollection<Education> Education { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<SocialLinks> SocialLinks { get; set; }
    }
}
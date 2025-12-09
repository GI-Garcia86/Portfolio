using System.Collections.Generic;
using System.Data.Entity;
namespace Portfolio.Models

{
    public class ApplicationDbContexts : DbContext
    {
        public ApplicationDbContexts() : base("PortfolioConnection") { } //conection string, cadena de conexión
        public DbSet<StudentProfile> StudentProfile { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<SocialLinks> SocialLinks { get; set; }

    }
}
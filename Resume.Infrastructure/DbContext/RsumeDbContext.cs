using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.Models.Entities.Educaties;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.Entities.Contact;

namespace Resume.Presentation.Models.ResumeDbContext

{
    public class RsumeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0GLOUK0;Initial Catalog=ResumeDaneshkar;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Educaties> Educaties { get; set; }
        public DbSet<MySkills> MySkills { get; set; }
        public DbSet<Contacts> Contacts { get; set; }

    }
}


﻿using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Educaties;
using Resume.Presentation.Models.Entities.Experience;
using Resume.Presentation.Models.Entities.MySkills;

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

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KoningsSurveyApp.EfDBContext
{
    public class SurveyContext : DbContext
    {
        public DbSet<SurveyTemplate> SurveyTemplates { get; set; }
        public DbSet<SurveyGroup> SurveyGroups { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-GGV5TS2;Database=KoningsDemo;Trusted_Connection=True");
            optionsBuilder.LogTo(Console.WriteLine);
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

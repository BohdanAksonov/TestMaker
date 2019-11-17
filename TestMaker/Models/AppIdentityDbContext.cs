using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestMaker.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>().ToTable("Users");
            builder.Entity<AppUser>().HasMany(u => u.Tests).WithOne(i => i.User);

            builder.Entity<Test>().ToTable("Tests");
            builder.Entity<Test>().Property(i =>i.Id).ValueGeneratedOnAdd();
            builder.Entity<Test>().HasOne(i => i.User).WithMany(u => u.Tests);
            builder.Entity<Test>().HasMany(i => i.Questions).WithOne(c => c.Test);

            builder.Entity<Question>().ToTable("Questions");
            builder.Entity<Question>().Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Entity<Question>().HasOne(i =>i.Test).WithMany(u => u.Questions);
            builder.Entity<Question>().HasMany(i => i.Answers).WithOne(c => c.Question);
            builder.Entity<Question>().HasMany(i => i.AnswerChoices).WithOne(c => c.Question);

            builder.Entity<Answer>().ToTable("Answers");
            builder.Entity<Answer>().Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Entity<Answer>().HasOne(i => i.Question).WithMany(u => u.Answers);

            builder.Entity<AnswerChoice>().ToTable("AnswerChoice");
            builder.Entity<AnswerChoice>().Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Entity<AnswerChoice>().HasOne(i => i.Question).WithMany(u => u.AnswerChoices);
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerChoice> AnswerChoices { get; set; }
    }
}


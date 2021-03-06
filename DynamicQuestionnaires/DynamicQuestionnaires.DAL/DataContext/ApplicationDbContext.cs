using DynamicQuestionnaires.Infrastruture.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.DAL.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Question> Questions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Question>().HasMany(answer => answer.Answers)
              //             .WithOne(tr=>tr.Question).HasForeignKey(con => con.QuestionId);
        }
    }


}

    

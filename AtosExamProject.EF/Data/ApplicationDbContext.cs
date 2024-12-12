using AtosExamProject.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AtosExamProject.EF.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Exam> exams { get; set; }
        public DbSet<StudentExams> StudentExams { get; set; }
        public DbSet<Subject> subjects { get; set; }

        public DbSet<Question> questions { get; set; }

        public DbSet<QuestionChoices> questionChoices { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<StudentExamQuestionAnswer> studentExamQuestionAnswers { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<StudentExams>()
                .HasKey(ste => new { ste.StudentId, ste.ExamId });

            modelBuilder.Entity<StudentExams>()
                .HasOne(ste => ste.studentUser)
                .WithMany(s => s.StudentsExams)
                .HasForeignKey(ste => ste.StudentId)
                .OnDelete(DeleteBehavior.NoAction);




            modelBuilder.Entity<Exam>()
                .HasOne(e => e.subject)
                .WithMany(s => s.exams)
                .HasForeignKey(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);




            modelBuilder.Entity<Question>()
                .HasOne(q => q.subject)
                .WithMany(s => s.question)
                .HasForeignKey(q => q.SubjectId);


            modelBuilder.Entity<QuestionChoices>()
                .HasOne(c => c.question)
                .WithMany(q => q.questionChoices)
                .HasForeignKey(c => c.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExamQuestion>()
                .HasKey(eq => new { eq.ExamId, eq.QuestionId });

            modelBuilder.Entity<ExamQuestion>()
                .HasOne(eq => eq.exam)
                .WithMany(e => e.EexamQuestions)
                .HasForeignKey(eq => eq.ExamId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ExamQuestion>()
                .HasOne(eq => eq.question)
                .WithMany(q => q.examQuestions)
                .HasForeignKey(eq => eq.QuestionId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
























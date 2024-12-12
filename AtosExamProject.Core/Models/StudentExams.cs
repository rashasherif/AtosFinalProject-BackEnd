namespace AtosExamProject.Core.Models
{
    public class StudentExams
    {
        public string StudentId { get; set; } 
        public int ExamId { get; set; }
        public int Score { get; set; }
        public Exam Exam { get; set; }
        public  User studentUser { get; set; }
    }
}
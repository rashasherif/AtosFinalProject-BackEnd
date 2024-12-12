using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }

        public string ExamTitle { get; set; }

        public double Duration { get; set; }


        public int SubjectId { get; set; }
        public Subject subject { get; set; }



        public ICollection<ExamQuestion> EexamQuestions { get; set; }
        public ICollection<StudentExams> StudentExams { get; set; }
    }
}
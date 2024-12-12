using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class StudentExamQuestionAnswer
    {
        public int Id { get; set; }
        public int StudentExamId { get; set; }

        public int ExamQuestionId { get; set; }

        public int AnswerId { get; set; }

        public StudentExams StudentExams { get; set; }

        public ExamQuestion examQuestion { get; set; }




    }
}

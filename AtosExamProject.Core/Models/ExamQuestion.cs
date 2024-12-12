using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class ExamQuestion
    {
        public int Id { get; set; }

        public int ExamId {  get; set; }
        public Exam exam { get; set; }
        public int QuestionId { get; set; }
        public Question question { get; set; }



    }
}

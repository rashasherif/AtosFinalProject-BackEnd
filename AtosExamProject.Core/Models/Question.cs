using AtosExamProject.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string QuestionText { get; set; }

     

        public int SubjectId { get; set; }
        public Subject subject { get; set; }

        public ICollection<QuestionChoices> questionChoices { get; set; }

        public ICollection<ExamQuestion> examQuestions { get; set; } = new HashSet<ExamQuestion>();
    }
}

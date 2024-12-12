using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public ICollection<Exam> exams { get; set; }

        public ICollection<Question> question { get; set; }


    }
}

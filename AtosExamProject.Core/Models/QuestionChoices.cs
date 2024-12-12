using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class QuestionChoices
    {
        public int Id { get; set; }

        public string value { get; set; }

        public bool Is_correct { get; set; }

        public int QuestionId { get; set; }
        public Question question { get; set; }


    }
}

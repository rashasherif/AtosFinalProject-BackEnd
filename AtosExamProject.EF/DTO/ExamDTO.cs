using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.EF.DTO
{
    public class ExamDTO
    {

        public required string ExamTitle { get; set; }
        public required double Duration { get; set; } 
        public required int SubjectId { get; set; }
    }
}

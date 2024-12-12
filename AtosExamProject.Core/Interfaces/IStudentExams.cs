using AtosExamProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Interfaces
{
    public interface IStudentExams
    {
        public Task<IEnumerable<StudentExams>> GetAllStudentExams();
        public Task<IEnumerable<StudentExams>> GetStudentExamById(int StudentId);
       
    }
}

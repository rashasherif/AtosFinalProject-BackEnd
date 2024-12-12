using AtosExamProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Interfaces
{
    public interface IExam
    {
       
       public Task<ExamQuestion> GetRandomExam();
        public Task<IEnumerable<Exam>> GetAllExams();
        public Task<List<ExamQuestion>> GetExamById(int ExamId);
        public Task<IEnumerable<Exam>> GetExamsBySubjectId(int subjectId);
        public Task<bool> DeleteExam(int ExamId);
       public Task<IEnumerable<StudentExams>> GetHistoryForStudentExam(int studentId);
    
        

    }
}

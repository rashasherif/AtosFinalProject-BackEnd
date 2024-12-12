using AtosExamProject.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Interfaces
{
    public interface IUser
    {
        public Task<IEnumerable<User>> GetAllStudents();
        public Task<User> GetStudentById(int UserId);
        List<IEnumerable<StudentExamQuestionAnswer>> studentExams(int StudentId);

        
        
    }
}

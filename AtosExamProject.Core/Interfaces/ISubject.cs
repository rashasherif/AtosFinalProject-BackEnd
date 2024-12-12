using AtosExamProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Interfaces
{
    public interface ISubject
    {
        public Task<IEnumerable<Subject>> GetAllSubjects();
        public Task<Subject> GetSubjectById(int subjectId);
        public Task<bool> AddSubject(Subject subject);
        public Task<bool> DeleteSubjectAsync(int subjectId);



    }
}

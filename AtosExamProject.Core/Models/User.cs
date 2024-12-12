using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Models
{
    public class User:IdentityUser
    {
    
        public string UserName {  get; set; }
        public string? Role { get; set; }
       

        public List<StudentExams> StudentsExams { get; set; }
    }
}

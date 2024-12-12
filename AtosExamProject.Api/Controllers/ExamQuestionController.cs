using AtosExamProject.Core.Interfaces;
using AtosExamProject.Core.Models;
using AtosExamProject.EF.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AtosExamProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamQuestionController : ControllerBase
    {

         private readonly ApplicationDbContext _context;
        public ExamQuestionController(ApplicationDbContext Context)
        {
            _context = Context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExamQuestion>>> DisplayAllExamQuestion()
        {
           if (_context.ExamQuestions==null)
            {
                return NotFound();
            }
            return await _context.ExamQuestions.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ExamQuestion>> DisplayIdAllExamQuestion(int id)
        {
            if (_context.ExamQuestions == null)
            {
                return NotFound();
            }
            var ExamQuestion = await _context.ExamQuestions.FindAsync(id);  
            if(ExamQuestion == null)
            {
                return NotFound();
            }
            return ExamQuestion;
        }
    }

}


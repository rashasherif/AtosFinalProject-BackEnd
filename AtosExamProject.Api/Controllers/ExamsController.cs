using AtosExamProject.Api.Controllers;
using AtosExamProject.Core.Interfaces;
using AtosExamProject.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtosExamProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IBaseRepository<Exam> _examsRepository;
        public ExamsController(IBaseRepository<Exam> examsRepository)
        {
            _examsRepository = examsRepository;
        }

     

        [HttpGet("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_examsRepository.GetAll());
        }


        [HttpGet("GetByIdAsync/{examId}")]

        public  async Task<IActionResult> GetByIdAsync(int examId)
        {
            return Ok(await _examsRepository.GetByIdAsync(examId));

        }



      

    }
}



















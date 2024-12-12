using AtosExamProject.Core.Interfaces;
using AtosExamProject.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtosExamProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IBaseRepository<Subject> _subjectRepository;
        public SubjectsController(IBaseRepository<Subject> subjectRepository)

        {
            _subjectRepository = subjectRepository;
        }

        [HttpGet]

        public IActionResult GetById() 
        { 
            return Ok(_subjectRepository.GetById(1));
        }

        [HttpGet("GetAll")]

        public IActionResult GetAll()
        {
            return Ok(_subjectRepository.GetAll());
        }

        //[HttpGet("GetByName")]

        //public IActionResult GetByName()
        //{
        //    return Ok(_subjectRepository.Find(b=>b.SubjectName));
        //}

    }
}

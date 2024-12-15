using Microsoft.AspNetCore.Mvc;
using Timesheet.Core.Interfaces;
using Timesheet.Core.Models;

namespace Timesheet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _studentRepository;
        private readonly IConfiguration _configuration;
        public StudentsController(ILogger<StudentsController> logger, IStudentRepository studentRepository, IConfiguration configuration)
        {
            _logger = logger;
            _studentRepository = studentRepository;
            _configuration = configuration;
        }

        [HttpGet(Name = "Students")]
        public IEnumerable<Student> Get(string group)
        {
            var result = _studentRepository.GetStudents(group).ToList();
            _logger.LogInformation(group, result);
            return result;
        }

        [HttpPost(Name = "Students")]
        public Guid Post(string name, string group)
        {
            return _studentRepository.CreateStudent(group, name);
        }
        [HttpDelete(Name = "Students")]
        public Guid Delete(Guid id)
        {
            return _studentRepository.DeleteStudent(id);
        }
        [HttpPut(Name = "Students")]
        public Student Put(Guid id, string name, string group)
        {
            return _studentRepository.UpdateStudent(id, group, name);
            
        }

    }
}

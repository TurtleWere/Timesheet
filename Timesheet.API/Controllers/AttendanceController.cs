using Microsoft.AspNetCore.Mvc;
using Timesheet.Core.Interfaces;
using Timesheet.Core.Models;
using Timesheet.Db.Repository;

namespace Timesheet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttendanceController : Controller
    {
        private readonly ILogger<AttendanceController> _logger;
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly IConfiguration _configuration;
        public AttendanceController(ILogger<AttendanceController> logger, IAttendanceRepository attendanceRepository, IConfiguration configuration)
        {
            _logger = logger;
            _attendanceRepository = attendanceRepository;
            _configuration = configuration;
        }

        [HttpGet(Name = "Attendance")]
        public IEnumerable<Statistic> Get(Guid student_id)
        {
            return  _attendanceRepository.GetAttendances(student_id).ToList();           

        }

        [HttpPost(Name = "Attendance")]
        public bool Post(Attendance attendance)
        {
            return _attendanceRepository.CreateAttendance(attendance);
        }
        [HttpDelete(Name = "Attendance")]

        [HttpPut(Name = "Attendance")]
        public void Put(Attendance attendance)
        {
            _attendanceRepository.UpdateAttendance(attendance);

        }
    }
}

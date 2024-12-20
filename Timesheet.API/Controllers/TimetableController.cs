using Microsoft.AspNetCore.Mvc;
using Timesheet.Core.Interfaces;
using Timesheet.Core.Models;

namespace Timesheet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimetableController : ControllerBase
    {

        private readonly ILogger<TimetableController> _logger;
        private readonly ITimetableRepository _timetableRepository;
        private readonly IConfiguration _configuration;
        public TimetableController(ILogger<TimetableController> logger, ITimetableRepository timetableRepository, IConfiguration configuration)
        {
            _logger = logger;
            _timetableRepository = timetableRepository;
            _configuration = configuration;
        }

        [HttpGet(Name = "Timetable")]
        public Timetable Get(string group)
        {
            return _timetableRepository.GetTimetable(group);
        }

        [HttpPut(Name = "Timetable")]
        public Timetable Put(string group_id, int day_id, int lesson_id)
        {
            return _timetableRepository.UpdateTimetable(group_id, day_id, lesson_id);

        }

    }
}

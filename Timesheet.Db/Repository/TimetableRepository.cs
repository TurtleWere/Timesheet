using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.Core.Interfaces;
using Timesheet.Core.Models;

namespace Timesheet.Db.Repository
{
    public class TimetableRepository : ITimetableRepository
    {
        private readonly string _conectionstring;
        public TimetableRepository(string constring)
        {
            _conectionstring = constring;
        }


        public Timetable GetTimetable(string id)
        {
            using (var db = new SqliteConnection(_conectionstring))
            {
                db.Open();
                var sql = @"SELECT day_id, lesson_id, name FROM Lessons WHERE group_id = @id ORDER BY day_id ASC;";
                var lessons = db.Query<Lesson>(sql, new { id = id }).ToList();
                var timetable = new Timetable(id, lessons);
                return timetable;
            }
        }

        public Timetable UpdateTimetable(string group_id, int day_id, int lesson_id)
        {
            using (var db = new SqliteConnection(_conectionstring))
            {
                db.Open();
                var sql = @"DELETE FROM Lessons WHERE group_id = @group_id AND day_id = @day_id AND lesson_id = @lesson_id;";
                var lessons = db.Query<Lesson>(sql, new { group_id = group_id, day_id = day_id, lesson_id = lesson_id }).ToList();
                return new Timetable(group_id, lessons);
            }
        }
    }
}

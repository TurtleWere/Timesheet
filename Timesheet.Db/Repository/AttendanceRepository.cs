﻿using Timesheet.Core.Interfaces;
using Timesheet.Core.Models;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Timesheet.Db.Repository
{
    public class AttendanceRepository: IAttendanceRepository

    {
        private readonly string _connectionstring;        
        public AttendanceRepository(string constring)
        {
            _connectionstring = constring;
        }
        public IEnumerable<Statistic> GetAttendances(Guid student_id)
        {
            using (var db = new SqliteConnection(_connectionstring))
            {
                db.Open();
                var sql = @"SELECT 
    s.name as StudentName, 
    SUM(CASE WHEN a.status = 'Present' THEN 1 ELSE 0 END) * 1.5 AS HoursWas, 
    SUM(CASE WHEN a.status = 'Absent' THEN 1 ELSE 0 END) * 1.5 AS HoursWasnt, 
    SUM(CASE WHEN a.status = 'Excused' THEN 1 ELSE 0 END) * 1.5 AS HoursForReason, 
    ROUND(100.0 * SUM(CASE WHEN a.status = 'Present' THEN 1 ELSE 0 END) / COUNT(*), 2) AS PercentWas, 
    ROUND(100.0 * SUM(CASE WHEN a.status = 'Absent' THEN 1 ELSE 0 END) / COUNT(*), 2) AS PercentWasnt, 
    ROUND(100.0 * SUM(CASE WHEN a.status = 'Excused' THEN 1 ELSE 0 END) / COUNT(*), 2) AS PercentForReason
FROM Students s
JOIN Attendance a ON s.id = a.student_id
WHERE id=@Studentota_id;";
                var results = db.Query<Statistic>(sql, new { Studentota_id = Convert.ToString(student_id)});
                return results;
            }
        }
        public bool CreateAttendance(Attendance attendance)
        {
            try
            {
                using (var db = new SqliteConnection(_connectionstring))
                {
                    db.Open();
                    var sql = @"INSERT INTO Attendance (group_id, student_id, day_id, lesson_id, status, descrintion) VALUES (@attendace.GrouId, @attendace.StudentId, @attendace.DayId, @attendace.LessonId, @attendace.Status, @attendace.Description  );";
                    db.Execute(sql, attendance);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void CreateTable()
        {
            throw new NotImplementedException();
        }

        public void UpdateAttendance(Attendance attendance)
        {
            using (var db = new SqliteConnection(_connectionstring))
            {
                db.Open();
                var sql = @"UPDATE Attendance SET status = @attendance.Status, description = @attendance.Description WHERE group_id = @attendance.GroupId AND student_id = @attendance.StudentId AND day_id = @attendance.DayId AND @attendance.LessonId;";

                db.Execute(sql, attendance);

            }
        }

    }
}

using System.Data;
using System.Runtime.InteropServices;
using Timesheet.Core.Interfaces;
using Timesheet.Core.Models;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Runtime.Intrinsics.Arm;
namespace Timesheet.Db.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _connectionstring;
        public StudentRepository(string constring=@"Data Source=TimesheetDb.db;") 
        {
            _connectionstring = constring;
        }
        public Guid CreateStudent(string group_id, string name)
        {
            using (var db = new SqliteConnection(_connectionstring))
            {
                var id = Guid.NewGuid();
                var _student = new
                {
                    id = id,
                    name = name,
                    group_id = group_id,
                                        
                };
                db.Open();
                var sql = @"INSERT INTO Students (id,  name, group_id) VALUES (@id, @name, @group_id );";
                db.Execute(sql, _student);
                return id;
            }
        }

        public Guid DeleteStudent(Guid id)
        {
            using (var db = new SqliteConnection(_connectionstring))
            {
                db.Open();
                var sql = @"Delete student in Students WHERE id = @id;";
                db.Execute(sql, new {id = id});
                return id;
            }
        }

        public IEnumerable<Student> GetStudents(string group_id)
        {
            using (var db = new SqliteConnection(_connectionstring))
            {
                db.Open();
                var sql = @"SELECT id, name, group_id FROM Students WHERE group_id=@Group_id;";
                var results = db.Query<dynamic>(sql, new { Group_id = group_id });

                return results.Select(row => new Student
                {
                    Id = Guid.Parse(row.id), // Преобразуем строку в Guid
                    Name = row.name,
                    Group_id = row.group_id
                });
            }
        }

        public Student UpdateStudent(Guid id, string group_id, string name)
        {
            using (var db = new SqliteConnection(_connectionstring)) 
            { 
                db.Open();
                var sql = @"Update Students SET group_id = @group_id, name = @name Where id = @id;";
                db.Execute(sql, new {id = id, group_id = group_id, name = name });
                return new Student(id , name, group_id);

            }
        }

        public void CreateTable() 
        {
            using (var db = new SqliteConnection(_connectionstring))
            {
                db.Open();
                var sql = @"CREATE TABLE IF NOT EXISTS Timetable (id text PRIMARY KEY, days TEXT ARRAY);";
                db.Execute(sql);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Univer.Models;

namespace Univer.Services
{
    public class StudentService : IStudentService
    {
        public async Task AddStudent(Student student)
        {
            using (var context = new UniversityContext())
            {
                context.Students.Add(student);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteStudent(int id)
        {
            using (var context = new UniversityContext())
            {
                var student = GetStudentById(id);
                context.Entry(student).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<Student> GetStudentById(int id)
        {
            Student result = null;

            using (var context = new UniversityContext())
            {
                result = await context.Students.FirstOrDefaultAsync(p => p.StudentId == id);
            }
            return result;
        }

        public async Task<List<Student>> GetStudents()
        {
            List<Student> listOfStudents = new List<Student>();
            using (var context = new UniversityContext())
            {
                listOfStudents = await context.Students.ToListAsync();
            }
            return listOfStudents;
        }
    }
}
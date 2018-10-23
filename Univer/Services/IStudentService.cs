using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Models;

namespace Univer.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();

        Task<Student> GetStudentById(int id);

        Task AddStudent(Student student);

        Task DeleteStudent(int id);
    }
}

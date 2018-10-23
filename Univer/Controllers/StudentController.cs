using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Univer.Services;

namespace Univer.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: Student
        public async Task<ActionResult> Index()
        {
            var students = await _studentService.GetStudents();
            return View(students);
        }
    }
}
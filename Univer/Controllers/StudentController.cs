using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Univer.Models;
using Univer.Services;

namespace Univer.Controllers
{
    public class StudentController : Controller
    {
        /* public StudentController() { }

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
         }*/

        public UniversityContext context = new UniversityContext();

        public ActionResult Index()
        {
            IEnumerable<Student> students = context.Students;

            ViewBag.Students = students; 

            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {

            return View();
        }
    }
}
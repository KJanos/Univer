using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Univer.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string Faculty { get; set; }

        public int Year { get; set; }

        public bool Stipend { get; set; }

        public IEnumerable<SelectListItem> Faculties { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Univer.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public int Salary { get; set; }

        public IEnumerable<SelectListItem> Subjects { get; set; }
    }
}
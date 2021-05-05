using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakultetMVC.Models
{
    public class CourseTitleViewModel
    {
        public IList<Course>Courses { get; set; }
        public SelectList Titles { get; set; }
        public string CourseTitle { get; set; }
        public string SearchString { get; set; }
    }
}

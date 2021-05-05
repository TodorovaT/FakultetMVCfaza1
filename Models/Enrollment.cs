using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakultetMVC.Models
{
    public class Enrollment
    {
        //primary key
        public int Id { get; set; }

        [Display(Name = "Семестар")]
        [StringLength(10)]
        public string Semester { get; set; }

        [Display(Name = "Година")]
        public int Year { get; set; }

        [Display(Name = "Оцена")]
        public int Grade { get; set; }

        //foreign keys
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

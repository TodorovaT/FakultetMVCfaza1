using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakultetMVC.Models
{
    public class Course
    {
        //primary key 
        public int Id { get; set; }

        [Required]
        [Display(Name = "Наслов")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Кредити")]
        public int Credits { get; set; }

        [Required]
        [Display(Name = "Семестар")]
        public int Semester { get; set; }

        [Required]
        [Display(Name = "Насока")]
        [StringLength(100)]
        public string Programme { get; set; }

        [Required]
        [Display(Name = "Степен на школување")]
        [StringLength(25)]
        public string EducationLevel { get; set; }

        //foreign key
        public ICollection<Enrollment> Students { get; set; }

        //First,SecondTeacherId

            [Display(Name = "Професор")]
            public int? FirstTeacherId { get; set; }
            [Display(Name = "Асистент")]
            public int SecondTeacherId { get; set; }
            public Teacher Teacher { get; set; }
    }
}

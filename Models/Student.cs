using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakultetMVC.Models
{
    public class Student
    {
        //primary key
        public int Id { get; set; }

        [Required]
        [Display(Name = "Индекс")]
        [StringLength(10, MinimumLength = 6)]
        public string StudentId { get; set; }

        [Required]
        [Display(Name = "Име")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Презиме")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Датум на запишување")]
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        [Required]
        [Display(Name = "Кредити")]
        public int AcquiredCredits { get; set; }

        [Required]
        [Display(Name = "Семестар")]
        public int CurrentSemestar { get; set; }

        [Required]
        [Display(Name = "Степен на образование")]
        [StringLength(25)]
        public string EducationLevel { get; set; }

        //full name
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
        //foreign keys
        public ICollection<Enrollment> Courses { get; set; }
    }
}

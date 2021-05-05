using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FakultetMVC.Models
{
    public class Teacher
    {
        //primary key 
        public int Id { get; set; }

        [Required]
        [Display(Name = "Име")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Презиме")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Степен на образование")]
        [StringLength(50)]
        public string Degree { get; set; }

        [Required]
        [Display(Name = "Титула")]
        [StringLength(25)]
        public string AcademicRank { get; set; }

        [Required]
        [Display(Name = "Канцеларија")]
        [StringLength(10)]
        public string OfficeNumber { get; set; }


        [Required]
        [Display(Name = "Датум на вработување")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        //full name
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        //foreign keys
        public ICollection<Course> Courses { get; set; }
    }
}

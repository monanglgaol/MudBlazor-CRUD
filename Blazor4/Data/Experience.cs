using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor4.Data
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        [Required]
        public string YearsWorked { get; set; }


        [ForeignKey("Applicant")] //untuk melakukan relasi ke Applicant
        public int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; private set; }


    }
}

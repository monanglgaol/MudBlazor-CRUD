using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor4.Data
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [Range(25, 55, ErrorMessage ="Currently, we have position vacant for your age")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Qualification { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Currently, we have position vacant for your experience")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperience { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();

    }
}

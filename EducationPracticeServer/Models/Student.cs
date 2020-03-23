using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPracticeServer.Models {

    public class Student {

        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public int Sat { get; set; }
        public double Gpa { get; set; }
        public int? MajorId { get; set; }

        public virtual Major Major { get; set; }

    }
}

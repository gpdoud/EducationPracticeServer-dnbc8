using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPracticeServer.Models {

    public class Major {

        public int Id { get; set; }
        [StringLength(8)]
        [Required]
        public string Code { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public int MinSat { get; set; }

    }
}

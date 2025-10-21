using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }

        [StringLength(40)]
        public string SpecializationName { get; set; }

        public int? DepartmentId { get; set; }
    }
}

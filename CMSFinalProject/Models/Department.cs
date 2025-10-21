using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [StringLength(40)]
        public string DepartmentName { get; set; }
    }
}

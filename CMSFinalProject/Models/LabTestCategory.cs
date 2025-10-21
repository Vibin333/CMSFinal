using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTestCategory
    {
        [Key]
        public int LabTestCategoryId { get; set; }

        [Required, StringLength(100)]
        public string LabTestCategoryName { get; set; }
    }
}

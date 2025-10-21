using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTest
    {
        [Key]
        public int LabTestId { get; set; }

        [Required, StringLength(100)]
        public string LabTestName { get; set; }

        public int? LabTestCategoryId { get; set; }

        [StringLength(510)]
        public string Description { get; set; }

        public decimal? Price { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTestResultValues
    {
        [Key]
        public int ResultValueId { get; set; }

        public int ResultId { get; set; }

        [Required, StringLength(100)]
        public string ParameterName { get; set; }

        [StringLength(100)]
        public string ParameterValue { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string ReferenceRange { get; set; }

        public bool IsAbnormal { get; set; } = false;
    }
}

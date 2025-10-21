using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTestResult
    {
        [Key]
        public int ResultId { get; set; }

        public int LabTestPrescriptionId { get; set; }

        public int LabTestId { get; set; }

        public int MMRNo { get; set; }

        public int LabTechId { get; set; }

        public DateTime? SampleCollectionDate { get; set; }

        public DateTime? TestCompletionDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Pending";

        [StringLength(500)]
        public string ResultSummary { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        public int? VerifiedBy { get; set; }

        public DateTime? VerificationDate { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTestSample
    {
        [Key]
        public int SampleId { get; set; }

        public int LabTestPrescriptionId { get; set; }

        public int MMRNo { get; set; }

        [StringLength(50)]
        public string SampleType { get; set; }

        public DateTime? SampleCollectionDate { get; set; }

        public int? CollectedBy { get; set; }

        [StringLength(50)]
        public string SampleCondition { get; set; }

        [StringLength(50)]
        public string BarcodeNumber { get; set; }

        [StringLength(50)]
        public string StorageLocation { get; set; }
    }
}

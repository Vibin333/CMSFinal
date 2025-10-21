using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTestPrescription
    {
        [Key]
        public int LabTestPrescriptionId { get; set; }

        public int? LabTestId { get; set; }

        public int? MMRNo { get; set; }

        public int? DoctorId { get; set; }

        public int? ConsultationId { get; set; }

        public DateTime? PrescriptionDate { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class MedicinePrescription
    {
        [Key]
        public int MedicinePrescriptionId { get; set; }

        public int? MedicineId { get; set; }

        [StringLength(20)]
        public string Dosage { get; set; }

        public int? MMRNo { get; set; }

        public int? DoctorId { get; set; }

        public int? ConsultationId { get; set; }
    }
}

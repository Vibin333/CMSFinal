using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Consultation
    {
        [Key]
        public int ConsultationId { get; set; }

        [Required]
        public DateTime ConsultationDate { get; set; }

        public int? MMRNo { get; set; }

        public int? DoctorId { get; set; }

        [StringLength(200)]
        public string Diagnosis { get; set; }

        [StringLength(200)]
        public string Symptoms { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }
    }
}

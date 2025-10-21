using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        public int? ConsultationFee { get; set; }

        public int? SpecializationId { get; set; }

        public int? UserId { get; set; }

        public bool IsActive { get; set; } = true;

        public int? DepartmentId { get; set; }

        public int? Available { get; set; }
    }
}

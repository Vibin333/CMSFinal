using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        public int? TokenId { get; set; }

        public bool ConsultationStatus { get; set; } = false;

        public int? MMRNo { get; set; }

        public int? DoctorId { get; set; }

        public int? UserId { get; set; }

        public TimeSpan? AppointmentTime { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Patient
    {
        [Key]
        public int MMRNo { get; set; }

        [StringLength(40)]
        public string PatientName { get; set; }

        public DateTime? DOB { get; set; }

        public char? Gender { get; set; }

        public long? MobileNum { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public bool IsActive { get; set; } = true;

        [StringLength(6)]
        public string BloodGroup { get; set; }
    }
}

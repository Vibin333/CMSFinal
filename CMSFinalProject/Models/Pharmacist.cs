using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Pharmacist
    {
        [Key]
        public int PharmacistId { get; set; }

        public int UserId { get; set; }

        [StringLength(50)]
        public string LicenseNumber { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

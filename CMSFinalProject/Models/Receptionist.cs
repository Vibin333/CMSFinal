using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Receptionist
    {
        [Key]
        public int ReceptionistId { get; set; }

        public int UserId { get; set; }

        [StringLength(20)]
        public string ShiftTiming { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class LabTechnician
    {
        [Key]
        public int LabTechId { get; set; }

        public int UserId { get; set; }

        [StringLength(100)]
        public string Qualification { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

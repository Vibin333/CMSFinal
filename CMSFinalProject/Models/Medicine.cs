using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }

        [StringLength(20)]
        public string MedicineName { get; set; }

        public int? MedCategoryId { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(20)]
        public string ManufacturedBy { get; set; }
    }
}

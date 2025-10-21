using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class MedicineDispensing
    {
        [Key]
        public int DispensingId { get; set; }

        public int MedicinePrescriptionId { get; set; }

        public int MedicineId { get; set; }

        public int MMRNo { get; set; }

        public int PharmacistId { get; set; }

        public int Quantity { get; set; }

        public DateTime? DispensingDate { get; set; }

        [StringLength(50)]
        public string BatchNumber { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? TotalAmount { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Dispensed";
    }
}

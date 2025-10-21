using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class MedicineStock
    {
        [Key]
        public int StockId { get; set; }

        public int MedicineId { get; set; }

        [StringLength(50)]
        public string BatchNumber { get; set; }

        public int Quantity { get; set; } = 0;

        public int? ReorderLevel { get; set; }

        public decimal? UnitPrice { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public DateTime? LastUpdated { get; set; }

        public int? UpdatedBy { get; set; }
    }
}

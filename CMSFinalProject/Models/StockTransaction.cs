using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class StockTransaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int MedicineId { get; set; }

        [StringLength(20)]
        public string TransactionType { get; set; }

        public int Quantity { get; set; }

        [StringLength(50)]
        public string BatchNumber { get; set; }

        public DateTime? TransactionDate { get; set; }

        public int? PerformedBy { get; set; }

        public int? ReferenceId { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }
    }
}

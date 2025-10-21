using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        public int? ConsultationId { get; set; }

        public int? MMRNo { get; set; }

        [Required]
        public DateTime BillDate { get; set; }

        public decimal? ConsultationFee { get; set; }

        public decimal? MedicinesFee { get; set; }

        public decimal? LabTestsFee { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? NetAmount { get; set; }

        [StringLength(20)]
        public string PaymentStatus { get; set; } = "Pending";

        [StringLength(20)]
        public string PaymentMode { get; set; }

        public int? GeneratedBy { get; set; }
    }
}

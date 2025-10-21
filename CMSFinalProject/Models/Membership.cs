using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Membership
    {
        [Key]
        public int MembershipID { get; set; }

        [StringLength(100)]
        public string MembershipType { get; set; }

        public decimal? DiscountPercent { get; set; }
    }
}

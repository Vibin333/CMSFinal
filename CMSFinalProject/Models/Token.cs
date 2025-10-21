using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Token
    {
        [Key]
        public int TokenId { get; set; }

        public int? MMRNo { get; set; }

        public int? DoctorId { get; set; }

        public int? Position { get; set; }

        public DateTime? TokenDate { get; set; }
    }
}

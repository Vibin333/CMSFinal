using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public int UserId { get; set; }

        [StringLength(20)]
        public string AccessLevel { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

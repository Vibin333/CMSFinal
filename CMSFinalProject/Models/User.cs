using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(60)]
        public string Password { get; set; }

        [StringLength(40)]
        public string Fullname { get; set; }

        public char? Gender { get; set; }

        public DateTime? JoiningDate { get; set; }

        public long? MobileNum { get; set; }

        public int? RoleId { get; set; }

        public bool IsActive { get; set; } = true;

        [StringLength(20)]
        public string MailId { get; set; }
    }
}

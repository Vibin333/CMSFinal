using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class PatientMembership
    {
        [Key]
        public int PatientMembershipKey { get; set; } // surrogate key for EF if needed

        public int MMRNo { get; set; }

        public int MembershipID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}

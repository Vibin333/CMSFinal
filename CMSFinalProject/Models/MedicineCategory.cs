using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSFinalProject.Models
{
    public class MedicineCategory
    {
        [Key]
        public int MedCategoryId { get; set; }

        [StringLength(40)]
        public string MedCategoryName { get; set; }
    }
}

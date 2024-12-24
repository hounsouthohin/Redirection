using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("PhotoEleve", Schema = "dbo")]
    public partial class PhotoEleve1
    {
        [Key]
        [Column("noPhoto")]
        public int NoPhoto { get; set; }
        [Column("sourcePhoto")]
        [StringLength(255)]
        public string SourcePhoto { get; set; } = null!;
        [Column("noPv")]
        public int NoPv { get; set; }

        [ForeignKey("NoPv")]
        [InverseProperty("PhotoEleve1s")]
        public virtual Eleve1 NoPvNavigation { get; set; } = null!;
    }
}

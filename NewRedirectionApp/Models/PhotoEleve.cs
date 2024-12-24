using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("PhotoEleve")]
    public partial class PhotoEleve
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
        [InverseProperty("PhotoEleves")]
        public virtual Eleve NoPvNavigation { get; set; } = null!;
    }
}

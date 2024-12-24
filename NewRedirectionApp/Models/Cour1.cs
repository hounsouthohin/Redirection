using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Cour", Schema = "dbo")]
    public partial class Cour1
    {
        [Key]
        [Column("idCour")]
        public int IdCour { get; set; }
        [Column("nomCour")]
        [StringLength(100)]
        public string NomCour { get; set; } = null!;
        [Column("nomProf")]
        [StringLength(100)]
        public string NomProf { get; set; } = null!;
        [Column("dureeSemaine")]
        public int DureeSemaine { get; set; }
        [Column("dureeJour")]
        public int DureeJour { get; set; }
        [Column("idClasse")]
        public int IdClasse { get; set; }

        [ForeignKey("IdClasse")]
        [InverseProperty("Cour1s")]
        public virtual Classe1 IdClasseNavigation { get; set; } = null!;
    }
}

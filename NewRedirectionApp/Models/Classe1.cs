using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Classe", Schema = "dbo")]
    public partial class Classe1
    {
        public Classe1()
        {
            Cour1s = new HashSet<Cour1>();
        }

        [Key]
        [Column("idClasse")]
        public int IdClasse { get; set; }
        [Column("nomClasse")]
        [StringLength(100)]
        public string NomClasse { get; set; } = null!;
        [Column("nbEleves")]
        public int? NbEleves { get; set; }
        [Column("idEtablissement")]
        public int? IdEtablissement { get; set; }

        [ForeignKey("IdEtablissement")]
        [InverseProperty("Classe1s")]
        public virtual Etablissement1? IdEtablissementNavigation { get; set; }
        [InverseProperty("IdClasseNavigation")]
        public virtual ICollection<Cour1> Cour1s { get; set; }
    }
}

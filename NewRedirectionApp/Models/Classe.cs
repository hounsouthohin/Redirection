using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Classe")]
    public partial class Classe
    {
        public Classe()
        {
            Cours = new HashSet<Cour>();
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
        [InverseProperty("Classes")]
        public virtual Etablissement? IdEtablissementNavigation { get; set; }
        [InverseProperty("IdClasseNavigation")]
        public virtual ICollection<Cour> Cours { get; set; }
    }
}

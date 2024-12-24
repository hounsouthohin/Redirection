using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Eleve")]
    [Index("Courriel", Name = "UQ_Eleve_Courriel", IsUnique = true)]
    [Index("MotDePasse", Name = "UQ_Eleve_MotDePasse", IsUnique = true)]
    [Index("Courriel", Name = "UQ__Eleve__049FB20280A989AE", IsUnique = true)]
    [Index("MotDePasse", Name = "UQ__Eleve__D01A9ABA2B5F2E1B", IsUnique = true)]
    public partial class Eleve
    {
        public Eleve()
        {
            Notifications = new HashSet<Notification>();
            PhotoEleves = new HashSet<PhotoEleve>();
        }

        [Key]
        [Column("noPv")]
        public int NoPv { get; set; }
        [Column("idEtablissement")]
        public int IdEtablissement { get; set; }
        [Column("nom")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nom { get; set; } = null!;
        [Column("prenom")]
        [StringLength(50)]
        [Unicode(false)]
        public string Prenom { get; set; } = null!;
        [Column("courriel")]
        [StringLength(100)]
        [Unicode(false)]
        public string Courriel { get; set; } = null!;
        [Column("motDePasse")]
        [StringLength(100)]
        [Unicode(false)]
        public string MotDePasse { get; set; } = null!;
        [Column("date_naissance", TypeName = "date")]
        public DateTime DateNaissance { get; set; }
        [Column("date_inscription", TypeName = "date")]
        public DateTime DateInscription { get; set; }

        [ForeignKey("IdEtablissement")]
        [InverseProperty("Eleves")]
        public virtual Etablissement IdEtablissementNavigation { get; set; } = null!;
        [InverseProperty("NoPvNavigation")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty("NoPvNavigation")]
        public virtual ICollection<PhotoEleve> PhotoEleves { get; set; }
    }
}

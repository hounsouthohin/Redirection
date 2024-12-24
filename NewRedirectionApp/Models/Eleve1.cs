using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Eleve", Schema = "dbo")]
    [Index("Courriel", Name = "UQ__Eleve__049FB2022CFFC50D", IsUnique = true)]
    [Index("MotDePasse", Name = "UQ__Eleve__D01A9ABA04577E7E", IsUnique = true)]
    public partial class Eleve1
    {
        public Eleve1()
        {
            Notification1s = new HashSet<Notification1>();
            PhotoEleve1s = new HashSet<PhotoEleve1>();
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
        [InverseProperty("Eleve1s")]
        public virtual Etablissement1 IdEtablissementNavigation { get; set; } = null!;
        [InverseProperty("NoPvNavigation")]
        public virtual ICollection<Notification1> Notification1s { get; set; }
        [InverseProperty("NoPvNavigation")]
        public virtual ICollection<PhotoEleve1> PhotoEleve1s { get; set; }
    }
}

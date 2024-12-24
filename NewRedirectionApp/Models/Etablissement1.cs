using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Etablissement", Schema = "dbo")]
    public partial class Etablissement1
    {
        public Etablissement1()
        {
            Classe1s = new HashSet<Classe1>();
            Eleve1s = new HashSet<Eleve1>();
            Notification1s = new HashSet<Notification1>();
        }

        [Key]
        [Column("idEtablissement")]
        public int IdEtablissement { get; set; }
        [Column("nomEtab")]
        [StringLength(100)]
        [Unicode(false)]
        public string NomEtab { get; set; } = null!;
        [Column("delaiInscription")]
        public int DelaiInscription { get; set; }
        [Column("contact")]
        [StringLength(50)]
        [Unicode(false)]
        public string Contact { get; set; } = null!;
        [Column("nomProviseur")]
        [StringLength(100)]
        [Unicode(false)]
        public string NomProviseur { get; set; } = null!;
        [Column("prenomProviseur")]
        [StringLength(100)]
        [Unicode(false)]
        public string PrenomProviseur { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Region { get; set; } = null!;
        [Column("dateRentre", TypeName = "date")]
        public DateTime DateRentre { get; set; }
        [Column("province")]
        [StringLength(50)]
        [Unicode(false)]
        public string Province { get; set; } = null!;
        [Column("ville")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ville { get; set; } = null!;
        [Column("secteur")]
        [StringLength(50)]
        [Unicode(false)]
        public string Secteur { get; set; } = null!;

        [InverseProperty("IdEtablissementNavigation")]
        public virtual ICollection<Classe1> Classe1s { get; set; }
        [InverseProperty("IdEtablissementNavigation")]
        public virtual ICollection<Eleve1> Eleve1s { get; set; }
        [InverseProperty("IdEtablissementNavigation")]
        public virtual ICollection<Notification1> Notification1s { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    [Table("Notifications", Schema = "dbo")]
    public partial class Notification1
    {
        [Key]
        [Column("idNotifications")]
        public int IdNotifications { get; set; }
        [Column("date", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("message")]
        public string Message { get; set; } = null!;
        [Column("noPv")]
        public int NoPv { get; set; }
        [Column("idEtablissement")]
        public int IdEtablissement { get; set; }
        [Column("vue")]
        public bool Vue { get; set; }

        [ForeignKey("IdEtablissement")]
        [InverseProperty("Notification1s")]
        public virtual Etablissement1 IdEtablissementNavigation { get; set; } = null!;
        [ForeignKey("NoPv")]
        [InverseProperty("Notification1s")]
        public virtual Eleve1 NoPvNavigation { get; set; } = null!;
    }
}

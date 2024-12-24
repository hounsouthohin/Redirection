using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Models
{
    public partial class Notification
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
        [InverseProperty("Notifications")]
        public virtual Etablissement IdEtablissementNavigation { get; set; } = null!;
        [ForeignKey("NoPv")]
        [InverseProperty("Notifications")]
        public virtual Eleve NoPvNavigation { get; set; } = null!;
    }
}

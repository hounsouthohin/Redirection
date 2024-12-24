using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NewRedirectionApp.Models;

namespace NewRedirectionApp.Data
{
    public partial class BDEtabContext : DbContext
    {
        public BDEtabContext()
        {
        }

        public BDEtabContext(DbContextOptions<BDEtabContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classe> Classes { get; set; } = null!;
        public virtual DbSet<Classe1> Classes1 { get; set; } = null!;
        public virtual DbSet<Cour> Cours { get; set; } = null!;
        public virtual DbSet<Cour1> Cours1 { get; set; } = null!;
        public virtual DbSet<Eleve> Eleves { get; set; } = null!;
        public virtual DbSet<Eleve1> Eleves1 { get; set; } = null!;
        public virtual DbSet<Etablissement> Etablissements { get; set; } = null!;
        public virtual DbSet<Etablissement1> Etablissements1 { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Notification1> Notifications1 { get; set; } = null!;
        public virtual DbSet<PhotoEleve> PhotoEleves { get; set; } = null!;
        public virtual DbSet<PhotoEleve1> PhotoEleves1 { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-EPSLT7GU\\MSSQLSERVER01;Initial Catalog=BDEtab;User ID=Arthur;Password=prog3e3;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("db_accessadmin");

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classe__60FFF80179CF79A1");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdEtablissement)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Classe__idEtabli__6383C8BA");
            });

            modelBuilder.Entity<Classe1>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classe__60FFF8018B188D5C");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Classe1s)
                    .HasForeignKey(d => d.IdEtablissement)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Classe__idEtabli__3E52440B");
            });

            modelBuilder.Entity<Cour>(entity =>
            {
                entity.HasKey(e => e.IdCour)
                    .HasName("PK__Cour__80B36504DAB02AFA");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Cours)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Cour__idClasse__66603565");
            });

            modelBuilder.Entity<Cour1>(entity =>
            {
                entity.HasKey(e => e.IdCour)
                    .HasName("PK__Cour__80B36504526CD825");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Cour1s)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Cour__idClasse__4222D4EF");
            });

            modelBuilder.Entity<Eleve>(entity =>
            {
                entity.HasKey(e => e.NoPv)
                    .HasName("PK__Eleve__6F709D8A44045119");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Eleves)
                    .HasForeignKey(d => d.IdEtablissement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Eleve__idEtablis__60A75C0F");
            });

            modelBuilder.Entity<Eleve1>(entity =>
            {
                entity.HasKey(e => e.NoPv)
                    .HasName("PK__Eleve__6F709D8AF6BE9ED6");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Eleve1s)
                    .HasForeignKey(d => d.IdEtablissement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Eleve__idEtablis__3B75D760");
            });

            modelBuilder.Entity<Etablissement>(entity =>
            {
                entity.HasKey(e => e.IdEtablissement)
                    .HasName("PK__Etabliss__1E6C217EDC235690");
            });

            modelBuilder.Entity<Etablissement1>(entity =>
            {
                entity.HasKey(e => e.IdEtablissement)
                    .HasName("PK__Etabliss__1E6C217E6ADDAE43");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.IdNotifications)
                    .HasName("PK__Notifica__430D4E1A0531BF6D");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.IdEtablissement)
                    .HasConstraintName("FK__Notificat__idEta__6B24EA82");

                entity.HasOne(d => d.NoPvNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NoPv)
                    .HasConstraintName("FK__Notificati__noPv__6A30C649");
            });

            modelBuilder.Entity<Notification1>(entity =>
            {
                entity.HasKey(e => e.IdNotifications)
                    .HasName("PK__Notifica__430D4E1A745DD549");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Notification1s)
                    .HasForeignKey(d => d.IdEtablissement)
                    .HasConstraintName("FK__Notificat__idEta__4BAC3F29");

                entity.HasOne(d => d.NoPvNavigation)
                    .WithMany(p => p.Notification1s)
                    .HasForeignKey(d => d.NoPv)
                    .HasConstraintName("FK__Notificati__noPv__4AB81AF0");
            });

            modelBuilder.Entity<PhotoEleve>(entity =>
            {
                entity.HasKey(e => e.NoPhoto)
                    .HasName("PK__PhotoEle__746C0A8C7818351C");

                entity.HasOne(d => d.NoPvNavigation)
                    .WithMany(p => p.PhotoEleves)
                    .HasForeignKey(d => d.NoPv)
                    .HasConstraintName("FK__PhotoEleve__noPv__6E01572D");
            });

            modelBuilder.Entity<PhotoEleve1>(entity =>
            {
                entity.HasKey(e => e.NoPhoto)
                    .HasName("PK__PhotoEle__746C0A8CD147B922");

                entity.HasOne(d => d.NoPvNavigation)
                    .WithMany(p => p.PhotoEleve1s)
                    .HasForeignKey(d => d.NoPv)
                    .HasConstraintName("FK__PhotoEleve__noPv__5165187F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

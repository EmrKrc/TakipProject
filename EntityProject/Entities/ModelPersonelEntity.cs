using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityProject.Entities
{
    public partial class ModelPersonelEntity : DbContext
    {
        public ModelPersonelEntity()
            : base("name=ModelPersonelEntity")
        {
        }

        public virtual DbSet<Birimler> Birimlers { get; set; }
        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<viewPersonelBirim> viewPersonelBirims { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birimler>()
                .Property(e => e.BirimAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Birimler>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.AdiSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Tarih)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.AdiSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.Tarih)
                .IsUnicode(false);

            modelBuilder.Entity<viewPersonelBirim>()
                .Property(e => e.BirimAdi)
                .IsUnicode(false);
        }
    }
}

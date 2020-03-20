namespace CsharpB2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<evennement> evennements { get; set; }
        public virtual DbSet<inscri> inscris { get; set; }
        public virtual DbSet<personne> personnes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<evennement>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<evennement>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<evennement>()
                .Property(e => e.ville)
                .IsUnicode(false);

            modelBuilder.Entity<evennement>()
                .Property(e => e.pays)
                .IsUnicode(false);

            modelBuilder.Entity<personne>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<personne>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<personne>()
                .Property(e => e.ville)
                .IsUnicode(false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;
using Microsoft.EntityFrameworkCore;


namespace Database.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Contenido> Contenidos { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Productora> Productoras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region tables
            modelBuilder.Entity<Contenido>().ToTable("Contenidos");
            modelBuilder.Entity<Generos>().ToTable("Generos");
            modelBuilder.Entity<Productora>().ToTable("Productoras");
            #endregion

            #region "Primary Keys"
            modelBuilder.Entity<Contenido>().HasKey(C => C.Id);
            modelBuilder.Entity<Productora>().HasKey(P => P.Id);
            modelBuilder.Entity<Generos>().HasKey(g => g.Id);
            #endregion

            #region RelationShips
            modelBuilder.Entity<Productora>()
                .HasMany<Contenido>(c => c.Contenido)
                .WithOne(p =>p.Productora)
                .HasForeignKey(c => c.ProductoraId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Contenido>()
                .HasMany<Generos>(g => g.Generos)
                .WithMany(c => c.Contenido);

            modelBuilder.Entity<Generos>()
                .HasMany<Contenido>(c => c.Contenido)
                .WithMany(g => g.Generos);
            #endregion

            #region "Property configurations"

            #region Productora
            modelBuilder.Entity<Productora>().Property(p => p.Name).HasMaxLength(150);
            #endregion

            #region Generos
            modelBuilder.Entity<Generos>().Property(g => g.Name).HasMaxLength(150);
            #endregion

            #region Contenido
            modelBuilder.Entity<Contenido>().Property(c => c.Name).HasMaxLength(150);
            #endregion

            #endregion
        }
    }
}

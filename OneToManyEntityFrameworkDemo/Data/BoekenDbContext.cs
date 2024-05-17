using Microsoft.EntityFrameworkCore;
using OneToManyEntityFrameworkDemo.Models;
using OneToManyEntityFrameworkDemo.Models.ViewModels;

namespace OneToManyEntityFrameworkDemo.Data
{
    public class BoekenDbContext : DbContext
    {
        public BoekenDbContext(DbContextOptions<BoekenDbContext> options) : base(options) { }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Boek> Boeks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure Auteur entity (or table) with restrictions
            modelBuilder.Entity<Auteur>().HasKey(a => a.AuteurId);
            modelBuilder.Entity<Auteur>().HasMany(a => a.Boeken).WithOne(b => b.Auteur).HasForeignKey(b => b.AuteurId).OnDelete(DeleteBehavior.NoAction);
            //Configure Boeks entity with restrictions
            modelBuilder.Entity<Boek>().HasKey(a => a.BoekId);
            modelBuilder.Entity<Boek>().HasOne(x => x.Auteur).WithMany(x => x.Boeken).HasForeignKey(x => x.AuteurId).OnDelete(DeleteBehavior.NoAction);
            SeedData.AddRecords(modelBuilder);
        }
        public DbSet<OneToManyEntityFrameworkDemo.Models.ViewModels.BoekAuteurViewModel> BoekAuteurViewModel { get; set; } = default!;
        public DbSet<OneToManyEntityFrameworkDemo.Models.ViewModels.BoekenViewModel> BoekenViewModel { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using OneToManyEntityFrameworkDemo.Models;

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

            //Configure Auteur entity (or table)
            modelBuilder.Entity<Auteur>().HasMany(a => a.Boeken).WithOne(b => b.Auteur).HasForeignKey(b => b.AuteurId);
        }
    }
}

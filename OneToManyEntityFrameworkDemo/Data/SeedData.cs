using Microsoft.EntityFrameworkCore;
using OneToManyEntityFrameworkDemo.Models;

namespace OneToManyEntityFrameworkDemo.Data
{
    public class SeedData
    {
        public static void AddRecords(ModelBuilder modelBuilder)
        {
            //Seed data
            modelBuilder.Entity<Auteur>().HasData(
                new Auteur { AuteurId = 1, Naam = "I. Asimov" },
                new Auteur { AuteurId = 2, Naam = "F. Dostoievski" },
                new Auteur { AuteurId = 3, Naam = "S. King" },
                new Auteur { AuteurId = 4, Naam = "J.R.R. Tolkien" }
            );
            modelBuilder.Entity<Boek>().HasData(
                new Boek { BoekId = 1, Title = "Foundation", AuteurId = 1 },
                new Boek { BoekId = 2, Title = "Crimes et Châtiments", AuteurId = 2 },
                new Boek { BoekId = 3, Title = "Carrie", AuteurId = 3 },
                new Boek { BoekId = 4, Title = "The Lord of the Ring", AuteurId = 4 },
                new Boek { BoekId = 5, Title = "Robots", AuteurId = 1 },
                new Boek { BoekId = 6, Title = "Les frères Karkarov", AuteurId = 2 },
                new Boek { BoekId = 7, Title = "Les Régulateurs", AuteurId = 3 },
                new Boek { BoekId = 8, Title = "The Hobbits", AuteurId = 4 },
                new Boek { BoekId = 9, Title = "Bombadil", AuteurId = 4 }
            );
        }
    }
}

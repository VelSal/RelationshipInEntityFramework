using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models
{
    public class Auteur
    {
        [Key]
        public int AuteurId { get; set; }
        public string Naam { get; set; }
        public ICollection<Boek> Boeken { get; set; }

    }
}

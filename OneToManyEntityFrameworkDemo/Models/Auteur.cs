using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models
{
    public class Auteur
    {
        [Key]
        public int AuteurId { get; set; }
        [Required] [StringLength(50)] public string Naam { get; set; }
        public ICollection<Boek> Boeken { get; set; }

    }
}

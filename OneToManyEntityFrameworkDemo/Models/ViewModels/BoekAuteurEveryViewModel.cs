
using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
    public class BoekAuteurEveryViewModel
    {
		[Display(Name = "Livres")] public List<Boek> Boeken { get; set; }
		[Display(Name = "Auteurs")] public List<Auteur> Auteurs { get; set; }
		[Display(Name = "ID du livre")] public int GeselecteerdeAuteurId { get; set; }
    }
}

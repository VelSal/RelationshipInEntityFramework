
using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
    public class BoekAuteurEveryViewModel
    {
		[Display(Name = "Livres")] public List<Boek> Boeken { get; set; }
		[Display(Name = "Auteurs")] public List<Auteur> Auteurs { get; set; }
        public int GeselecteerdeAuteurId { get; set; }

       
        
    }
}

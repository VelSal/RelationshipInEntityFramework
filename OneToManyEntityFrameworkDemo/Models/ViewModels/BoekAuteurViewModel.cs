using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
    public class BoekAuteurViewModel
    {
        [Key] public int BoekId { get; set; }
        [Display(Name = "Livres")] public string Title { get; set;}
        [Display(Name = "Auteurs")] public string AuteurNaam { get; set;}
    }
}

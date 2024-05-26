using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
	public class EditBoekViewModel
	{
		public int BoekId { get; set; }
		[Required(ErrorMessage = "Titel is verplicht")] public string Titel { get; set; }
		[Required(ErrorMessage = "Auteur is verplicht")] public int AuteurId { get; set; } // Maak AuteurId nullable
		public List<Auteur>? Auteurs { get; set; }
		public bool IsAvailable { get; set; }
		public bool IsNewRelease { get; set; }
		public bool IsBestSeller { get; set; }
		[Required(ErrorMessage = "Een optie moet worden geselecteerd")] public int? BindingType { get; set; }
	}
}

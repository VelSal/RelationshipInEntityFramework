using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
	public class CreateBoekViewModel
	{
		[Required(ErrorMessage = "Titel is verplicht")]
		public string Titel { get; set; }

		[Required(ErrorMessage = "Auteur is verplicht")]

		[Display(Name = "Auteur")]
		public int AuteurId { get; set; }
		public List<Auteur>? Auteurs { get; set; }
		public bool IsAvailable { get; set; }
		public bool IsNewRelease { get; set; }
		public bool IsBestSeller { get; set; }

		[Required(ErrorMessage = "Een optie moet selecteren")]
		public int BindingType { get; set; }
	}
}

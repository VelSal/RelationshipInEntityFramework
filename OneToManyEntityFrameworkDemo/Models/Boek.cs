using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyEntityFrameworkDemo.Models
{
    public class Boek
    {
        public int BoekId { get; set; }
		[StringLength(50)] public string Title { get; set; }
        [ForeignKey("Auteur")] public int AuteurId { get; set; }
        public Auteur Auteur { get; set; }

        public bool? IsAvailable { get; set; }
        public bool? IsNewRelease { get; set; }
        public bool? IsBestSeller { get; set; }

        public int? BindingType { get; set; }
		public string GetBindingType
		{
			get
			{
				return BindingType switch
				{
					1 => "Paperback",
					2 => "Hardcover",
					3 => "E-book",
					_ => "Unknown"
				};
			}
		}
	}
}

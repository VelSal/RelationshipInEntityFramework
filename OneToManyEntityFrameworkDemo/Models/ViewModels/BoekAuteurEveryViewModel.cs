
namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
    public class BoekAuteurEveryViewModel
    {
        public List<Boek> Boeken { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public int GeselecteerdeAuteurId { get; set; }

       
        
    }
}

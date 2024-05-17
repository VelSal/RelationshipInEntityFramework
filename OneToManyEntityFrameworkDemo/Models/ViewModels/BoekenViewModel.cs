namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
    public class BoekenViewModel
    {
        public int Id { get; set; }
        public List<BoekAuteurViewModel> Boeken { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public int GeselecteerdeAuteurId { get; set; }

    }
}

namespace OneToManyEntityFrameworkDemo.Models
{
    public class Boek
    {
        public int BoekId { get; set; }
        public string Title { get; set; }
        public int AuteurId { get; set; }
        public Auteur Auteur { get; set; }
    }
}

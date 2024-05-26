using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OneToManyEntityFrameworkDemo.Models.ViewModels
{
    [Keyless]
    public class BoekenViewModel
    {
        public List<BoekAuteurViewModel> Boeken { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public int GeselecteerdeAuteurId { get; set; }

    }
}

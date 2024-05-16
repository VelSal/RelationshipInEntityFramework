using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyEntityFrameworkDemo.Data;
using OneToManyEntityFrameworkDemo.Models.ViewModels;

namespace OneToManyEntityFrameworkDemo.Controllers
{
    public class BoekenController : Controller
    {
        readonly BoekenDbContext _context;
        public BoekenController(BoekenDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var boekAuteurViewModel = _context.Boeks
                .Include(b => b.Auteur)
                .Select(b => new BoekAuteurViewModel
                {
                    BoekId = b.BoekId,
                    Title = b.Title,
                    AuteurNaam = b.Auteur.Naam
                });
            return View(boekAuteurViewModel);
        }
    }
}

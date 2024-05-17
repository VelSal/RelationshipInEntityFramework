using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyEntityFrameworkDemo.Data;
using OneToManyEntityFrameworkDemo.Models;
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
        public async Task<IActionResult> Filters(int? GeselecteerdeAuteurId)    //Pour le dropdown
        {
            var auteurs = await _context.Auteurs.ToListAsync();
            //Ne fait rien ici
            IQueryable<Boek> boekenQuery = _context.Boeks.Include(b => b.Auteur);

            //Si on selectionne quelque chose, on filtre sinon on montre tous les livres
            if (GeselecteerdeAuteurId.HasValue)
            {
                boekenQuery = boekenQuery.Where(b => b.AuteurId == GeselecteerdeAuteurId);
            }

            //C'est ici qu'il est activé car ToListAsync()
            var boeken = await boekenQuery.ToListAsync();
            var boekenViewModel = boeken.Select(b => new BoekAuteurViewModel
            {
                BoekId = b.BoekId,
                Title = b.Title,
                AuteurNaam = b.Auteur.Naam
            }).ToList();

            var filtersViewModel = new BoekenViewModel
            {
                Auteurs = auteurs,
                Boeken = boekenViewModel,
                //null coalescing operation (+- comme ternary mais pour db)
                GeselecteerdeAuteurId = GeselecteerdeAuteurId ?? 0
            };

            return View(filtersViewModel);
        }
        public async Task<IActionResult> FiltersEveryViewModel(int? GeselecteerdeAuteurId)
        {
            var auteurs = await _context.Auteurs.ToListAsync();
            
            IQueryable<Boek> boekenQuery = _context.Boeks.Include(b => b.Auteur);

            if (GeselecteerdeAuteurId.HasValue && GeselecteerdeAuteurId > 0)
            {
                boekenQuery = boekenQuery.Where(b => b.AuteurId == GeselecteerdeAuteurId.Value);
            }

            var boeken = await boekenQuery.ToListAsync();
            var ViewModel =  new BoekAuteurEveryViewModel
            {
                Auteurs = auteurs,
                Boeken = boeken,
                GeselecteerdeAuteurId = GeselecteerdeAuteurId ?? 0

            };

            return View(ViewModel);
        }
    }
}

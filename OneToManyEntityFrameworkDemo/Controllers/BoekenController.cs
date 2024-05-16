using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyEntityFrameworkDemo.Data;

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
            var boeken = await _context.Boeks.ToListAsync();
            return View(boeken);
        }
    }
}

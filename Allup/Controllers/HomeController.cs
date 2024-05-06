using Allup.Data;
using Allup.Models;
using Allup.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<Banner> banners = await _context.Banners.ToListAsync();
            List<Product> products = await _context.Products.ToListAsync();


            HomeVM model = new()
            {
                Sliders = sliders,
                Banners = banners,
                Products = products
            };
            return View(model);
        }
    }
}

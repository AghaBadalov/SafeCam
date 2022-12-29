using Microsoft.AspNetCore.Mvc;
using SafeCam.Models;
using SafeCam.ViewModels;
using System.Diagnostics;

namespace SafeCam.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            HomeViewModel Homewm = new HomeViewModel()
            {
                Sliders=_context.Sliders.ToList(),
                Services=_context.Services.ToList(),
                Plans=_context.Plans.ToList()
            
            };
            return View(Homewm);
        }
        public IActionResult Services()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Services = _context.Services.ToList();
            return View(homeViewModel);
        }

        public IActionResult Plan()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Plans = _context.Plans.ToList();
            return View(homeViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
    }
        
}
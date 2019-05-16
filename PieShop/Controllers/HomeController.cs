using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;


        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }


        public IActionResult Index()
        {
           
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to my pie shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}
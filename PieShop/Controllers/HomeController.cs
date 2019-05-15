using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;


        public HomeController(IPieRepository pieRepository)
        {
            pieRepository = _pieRepository;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
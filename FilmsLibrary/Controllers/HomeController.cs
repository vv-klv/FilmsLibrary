using FilmsLibrary.Data.Interfaces;
using FilmsLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFilmRepository _repository;



        public HomeController(ILogger<HomeController> logger, IFilmRepository filmRepository)
        {
            _logger = logger;
            _repository = filmRepository;
        }

        public IActionResult Index()
        {
            Film f = new Film
            {
                Name = "Fast and Furious: Tokyo Drift",
                Description = "",
                Rating = 10
            };
            var data = _repository.Create(f);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    }
}

using Microsoft.AspNetCore.Mvc;
using SequentialGuidGenerator.Infra;
using SequentialGuidGenerator.Models;
using System.Diagnostics;

namespace SequentialGuidGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGuidGenerator _guidGenerator;

        public HomeController(ILogger<HomeController> logger,
               IGuidGenerator guidGenerator)
        {
            _logger = logger;
            _guidGenerator = guidGenerator;
        }

        public IActionResult Index()
        {
            ViewBag.message1 = "First Guid " + _guidGenerator.Create().ToString();
            ViewBag.message2 = "Second Guid " + _guidGenerator.Create().ToString();
            ViewBag.message3 = "Third Guid " + _guidGenerator.Create().ToString();
            ViewBag.message4 = "Fourth Guid " + _guidGenerator.Create().ToString();
            ViewBag.message5 = "Fifth Guid " + _guidGenerator.Create().ToString();
            ViewBag.message6 = "Sixth Guid " + _guidGenerator.Create().ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
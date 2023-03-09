using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Services;
using Microsoft.AspNetCore.Mvc;

namespace APP.Controllers
{
    [Route("he-mat-troi/[action]")]
    public class PlanetController : Controller
    {
        private readonly PlanetServices _planetServices;
        private readonly ILogger<PlanetController> _logger;

        public PlanetController(ILogger<PlanetController> logger, PlanetServices planetServices)
        {
            _logger = logger;
            _planetServices = planetServices;
        }

        [Route("/danh-sach-cac-hanh-tinh.html")]
        public IActionResult Index()
        {
            return View();
        }

        [BindProperty(SupportsGet = true, Name = "action")]
        public string Name { set; get; }
        public IActionResult Mercury()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        public IActionResult Venus()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        public IActionResult Earth()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        public IActionResult Mars()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        [HttpGet("/saomoc.html")]
        public IActionResult Jupiter()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        public IActionResult Saturn()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        public IActionResult Uranus()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        [Route("sao/[action]", Order = 3, Name = "neptune3")]
        [Route("sao/[controller]/[action]", Order = 2, Name = "neptune2")]
        [Route("[controller]-[action].html", Order = 1, Name = "neptune1")]
        public IActionResult Neptune()
        {
            var planet = _planetServices.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        // controller, action, area => [controller] [action] [area]
        [Route("hanhtinh/{id:int}")]
        public IActionResult PlanetInfo(int id)
        {
            var planet = _planetServices.Where(p => p.Id == id).FirstOrDefault();
            return View("Detail", planet);
        }
    }
}
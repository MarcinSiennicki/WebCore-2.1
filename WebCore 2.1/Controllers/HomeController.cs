using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebCoreProjekt.Models;
using WebCoreProjekt.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebCoreProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;

        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var samochody = _samochodRepository.PobierzWszystkieSamochody().OrderBy(s => s.Marka);

            var homeVM = new HomeVM()
            {
                Tytul = "Przegląd Samochodow",
                Samochody = samochody.ToList()

            };


            return View(homeVM);
        }
        public IActionResult Szczegoly(int id)
        {
            var samochod = _samochodRepository.PobierzSamochodId(id);
            if (samochod == null)
            {
                return NotFound();
            }
            return View(samochod);
        }
    }
}

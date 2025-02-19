using Microsoft.AspNetCore.Mvc;
using SlnPruebaTecnica.Models;

namespace SlnPruebaTecnica.Controllers
{
    public class PersonDataController : Controller
    {
        PruebaTecnicaDbContext db = new PruebaTecnicaDbContext();
        public IActionResult Index()
        {
            return View(db.Personas.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

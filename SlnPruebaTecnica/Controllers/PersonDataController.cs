using Microsoft.AspNetCore.Mvc;
using SlnPruebaTecnica.Models;

namespace SlnPruebaTecnica.Controllers
{
    public class PersonDataController : Controller
    {
        PruebaTecnicaDbContext db = new PruebaTecnicaDbContext();
        public IActionResult Index()
        {
            return View(Tuple.Create(db.Personas.ToList(), db.Nacionalidads.OrderBy(x => x.Descripcion).ToList(), db.Residencia.OrderBy(x => x.Descripcion).ToList()));
        }
    }
}

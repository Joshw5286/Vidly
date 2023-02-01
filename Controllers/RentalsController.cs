using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            var rental = _context.Rentals.Single(r => r.Id == id);

            if (rental == null)
            {
                return HttpNotFound();
            }

            return View(rental);
        }
    }
}
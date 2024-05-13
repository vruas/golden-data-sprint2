using GoldenData.Data;
using GoldenData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenData.Controllers
{
    public class InfoConsumidorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InfoConsumidorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET

        public IActionResult Index()
        {
            return View(_context.InfoConsumidor.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST

        [HttpPost]

        public IActionResult Create(InfoConsumidor info)
        {
            if (ModelState.IsValid)
            {
                _context.InfoConsumidor.Add(info);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info);
        }

        // GET: info

        public IActionResult Edit(int Id)
        {
            var info = _context.InfoConsumidor.Find(Id);
            if (info == null)
            {
                return NotFound();
            }

            return View(info);
        }

        // UPDATE

        [HttpPost]

        public IActionResult Edit(InfoConsumidor info)
        {
            if (ModelState.IsValid)
            {
                _context.InfoConsumidor.Update(info);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info);
        }

        // GET: info

        public IActionResult Delete(int Id)
        {
            var info = _context.InfoConsumidor.Find(Id);
            if (info == null)
            {
                return NotFound();
            }

            return View(info);

        }

        // DELETE

        [HttpPost]

        public IActionResult DeleteConfirmed(int Id)
        {
            var info = _context.InfoConsumidor.Find(Id);
            if (info == null)
            {
                return NotFound();
            }

            _context.InfoConsumidor.Remove(info);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

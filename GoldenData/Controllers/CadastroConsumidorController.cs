using GoldenData.Data;
using GoldenData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GoldenData.Controllers
{
    public class CadastroConsumidorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastroConsumidorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            return View(_context.CadastroConsumidor.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Create(CadastroConsumidor consumidor)
        {
            if (ModelState.IsValid)
            {
                _context.CadastroConsumidor.Add(consumidor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consumidor);
        }

        // GET: consumidor
        public IActionResult Edit(int Id)
        {
            var consumidor = _context.CadastroConsumidor.Find(Id);
            if (consumidor == null)
            {
                return NotFound();
            }

            return View(consumidor);
        }

        // UPDATE
        [HttpPost]
        public IActionResult Update(CadastroConsumidor consumidor)
        {
            if (ModelState.IsValid)
            {
                _context.CadastroConsumidor.Update(consumidor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consumidor);
        }

        // GET: consumidor
        public IActionResult Delete(int Id)
        {
            var consumidor = _context.CadastroConsumidor.Find(Id);
            if (consumidor == null)
            {
                return NotFound();
            }

            return View(consumidor);
        }

        // DELETE
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            var consumidor = _context.CadastroConsumidor.Find(Id);
            if (consumidor == null)
            {
                return NotFound();
            }

            _context.CadastroConsumidor.Remove(consumidor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

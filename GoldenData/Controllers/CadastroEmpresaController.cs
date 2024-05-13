using GoldenData.Data;
using GoldenData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenData.Controllers
{

    public class CadastroEmpresaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CadastroEmpresaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET

        public IActionResult Index()
        {
            return View(_context.CadastroEmpresa.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST

        [HttpPost]

        public IActionResult Create(CadastroEmpresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.CadastroEmpresa.Add(empresa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        // GET: empresa

        public IActionResult Edit(int Id)
        {
            var empresa = _context.CadastroEmpresa.Find(Id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // UPDATE

        [HttpPost]

        public IActionResult Update(CadastroEmpresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.CadastroEmpresa.Update(empresa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        // GET: empresa

        public IActionResult Delete(int Id)
        {
            var empresa = _context.CadastroEmpresa.Find(Id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // DELETE

        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int Id)
        {
            var empresa = _context.CadastroEmpresa.Find(Id);
            if (empresa == null)
            {
                return NotFound();
            }
           
            _context.CadastroEmpresa.Remove(empresa);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

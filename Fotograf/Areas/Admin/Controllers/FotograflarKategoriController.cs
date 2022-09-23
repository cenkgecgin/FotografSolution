using Fotograf.DAL.Contexts;
using Fotograf.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fotograf.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class FotograflarKategoriController : Controller
    {
        private readonly SqlDbContext context;

        public FotograflarKategoriController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.FotograflarKategori.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            FotograflarKategori fotograflarkategori = new();
            return View(fotograflarkategori);
        }

        [HttpPost]
        public IActionResult Create(FotograflarKategori fotograflarkategori)
        {
            if (ModelState.IsValid)
            {

                context.FotograflarKategori.Add(fotograflarkategori);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(fotograflarkategori);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            FotograflarKategori fotograflarkategori = context.FotograflarKategori.Find(id);
            return View(fotograflarkategori);
        }

        [HttpPost]
        public IActionResult Update(FotograflarKategori fotograflarkategori)
        {
            context.Update(fotograflarkategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var fotograflarkategori = context.FotograflarKategori.Find(id);
            return View(fotograflarkategori);
        }

        [HttpPost]
        public IActionResult Delete(FotograflarKategori fotograflarkategori)
        {


            context.Remove(fotograflarkategori);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

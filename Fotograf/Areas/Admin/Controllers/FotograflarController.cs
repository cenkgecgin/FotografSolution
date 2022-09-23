using Fotograf.DAL.Contexts;
using Fotograf.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fotograf.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class FotograflarController : Controller
    {
        private readonly SqlDbContext context;

        public FotograflarController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Fotograflar.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Fotograflar fotograflar = new();
            return View(fotograflar);
        }

        [HttpPost]
        public IActionResult Create(Fotograflar fotograflar)
        {
            if (ModelState.IsValid)
            {

                context.Fotograflar.Add(fotograflar);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(fotograflar);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Fotograflar fotograflar = context.Fotograflar.Find(id);
            return View(fotograflar);
        }

        [HttpPost]
        public IActionResult Update(Fotograflar fotograflar)
        {
            context.Update(fotograflar);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var fotograflar = context.Fotograflar.Find(id);
            return View(fotograflar);
        }

        [HttpPost]
        public IActionResult Delete(Fotograflar fotograflar)
        {


            context.Remove(fotograflar);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

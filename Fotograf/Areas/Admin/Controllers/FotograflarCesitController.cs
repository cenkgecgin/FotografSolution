using Fotograf.DAL.Contexts;
using Fotograf.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fotograf.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class FotograflarCesitController : Controller
    {
        private readonly SqlDbContext context;

        public FotograflarCesitController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.FotograflarCesitler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            FotograflarCesit fotografcesit = new();
            return View(fotografcesit);
        }

        [HttpPost]
        public IActionResult Create(FotograflarCesit fotografcesit)
        {
            if (ModelState.IsValid)
            {

                context.FotograflarCesitler.Add(fotografcesit);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(fotografcesit);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            FotograflarCesit fotografcesit = context.FotograflarCesitler.Find(id);
            return View(fotografcesit);
        }

        [HttpPost]
        public IActionResult Update(FotograflarCesit fotografcesit)
        {
            context.Update(fotografcesit);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var fotografcesit = context.FotograflarCesitler.Find(id);
            return View(fotografcesit);
        }

        [HttpPost]
        public IActionResult Delete(FotograflarCesit fotografcesit)
        {


            context.Remove(fotografcesit);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

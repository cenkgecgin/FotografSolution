using Fotograf.DAL.Contexts;
using Fotograf.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fotograf.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "admin")]
    public class TeslimController : Controller
    {
        private readonly SqlDbContext context;

        public TeslimController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Teslimler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Teslim teslim = new();
            return View(teslim);
        }

        [HttpPost]
        public IActionResult Create(Teslim teslim)
        {
            if (ModelState.IsValid)
            {

                context.Teslimler.Add(teslim);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(teslim);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Teslim teslim = context.Teslimler.Find(id);
            return View(teslim);
        }

        [HttpPost]
        public IActionResult Update(Teslim teslim)
        {
            context.Update(teslim);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var teslim = context.Teslimler.Find(id);
            return View(teslim);
        }

        [HttpPost]
        public IActionResult Delete(Teslim teslim)
        {


            context.Remove(teslim);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

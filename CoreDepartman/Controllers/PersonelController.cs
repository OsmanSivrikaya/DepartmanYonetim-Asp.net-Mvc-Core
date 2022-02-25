using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var oku = c.personel.Include(x => x.Departman).ToList();
            return View(oku);
        }
        [Authorize]
        public IActionResult PersonelSil(int id)
        {
            var sil = c.personel.Find(id);
            c.personel.Remove(sil);
            c.SaveChanges();
            return View("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.departman.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartmanAd,
                                                 Value = x.DepartmanID.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            
            var per = c.departman.Where(x => x.DepartmanID == p.DepartmanID).FirstOrDefault();
            p.Departman = per;
            c.personel.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;

namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var oku = c.personel/*.Include(x=>x.Departman)*/.ToList();
            return View(oku);
        }
        public IActionResult PersonelSil(int id)
        {
            var sil = c.personel.Find(id);
            c.personel.Remove(sil);
            c.SaveChanges();
            return View("Index");
        }
    }
}

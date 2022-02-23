using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;


namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        //departman sınıfının içindeki verileri okumak için kullanıyor
        public IActionResult Index()
        {
            var degerler = c.departman.ToList();
            return View(degerler);
        }
        [HttpGet]
        //open new departman page
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        //use to add new departman
        public IActionResult YeniDepartman(Departman d)
        {
            c.departman.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
            
        }
        //use to delete departman
        public IActionResult DepartmanSil(int id)
        {
            var dep = c.departman.Find(id);
            c.departman.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //tıklanan departmanın bilgilerini textbox içinde yeni bir view de çağırır
        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.departman.Find(id);
            return View("DepartmanGetir",depart);
        }
        public IActionResult DepartmanGuncelle(Departman d)
        {
            var dep = c.departman.Find(d.DepartmanID);
            dep.DepartmanAd = d.DepartmanAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}

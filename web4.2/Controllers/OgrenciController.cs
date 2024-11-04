using Microsoft.AspNetCore.Mvc;
using web4._2.Models;

namespace web4._2.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OgrEkle(Ogrenci ogr) 
        {
            return View();
        }
        public IActionResult IndexOto()
        {
            return View();
        }
    }
}

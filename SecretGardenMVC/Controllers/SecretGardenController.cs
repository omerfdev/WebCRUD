using GizliBahceMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecretGardenMVC.Models.Entitites;

namespace SecretGardenMVC.Controllers
{
    public class SecretGardenController : Controller
    {
        private readonly AppDbContext _context;
        public SecretGardenController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Urunler.Include(x => x.Kategori).ToList();
            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Iletisim model)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Ad = model.Ad;
            iletisim.Email = model.Email;
            iletisim.Mesaj = model.Mesaj;
            _context.Iletisim.Add(iletisim);
            _context.SaveChanges();
            return RedirectToAction("Contact");
        }
        public IActionResult Details(int id)
        {
            Urunler urun = _context.Urunler.Include(x => x.Kategori).FirstOrDefault(x => x.UrunID == id);
            return View(urun);
        }
        public IActionResult History()
        {
            var model = _context.Tarihce.ToList();
            return View(model);
        }
        public IActionResult About()
        {
            return View(_context.Hakkımızda.ToList());
        }

    }
}

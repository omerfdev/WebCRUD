using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentClass.Context;

namespace StudentClass.Controllers
{
    public class ClassController : Controller
    {
        private readonly AppDbContext db;
        public ClassController(AppDbContext _db)
        {   
           db=_db;
        }
        public IActionResult Index()
        {

            return View(db.Classes.Include(x=>x.Students).ToList());
        }
    }
}

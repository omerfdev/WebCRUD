using ManyToManyMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace ManyToManyMVC.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly AppDbContext _db;
        public StudentCourseController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

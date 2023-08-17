using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentClass.Context;
using StudentClass.Models.Entities;
using StudentClass.Models.ViewModels;
using System.Drawing;

namespace StudentClass.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext db;
        public StudentController(AppDbContext _db)
        {
            db = _db;
        }
        StudentClassVM model = new StudentClassVM();
        public IActionResult Index(int id)
        {
            //Filtreleme
            model.Students = id != 0 ? db.Students.Where(x => x.ClassID == id).ToList() : db.Students.ToList();
            model.Class = db.Classes.ToList();
            return View(model);
        }    

        private List<SelectListItem> Dropdown()
        {
            return db.Classes.Select(x => new SelectListItem() { Text = x.Degree + x.ClassName, Value = x.ClassID.ToString() }).ToList();
        }
        public IActionResult Create()
        {
            model.Dropdown = Dropdown();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(StudentClassVM studentClassVM)
        {
            Student student = new Student()
            {
                FirstName = studentClassVM.Student.FirstName,
                LastName = studentClassVM.Student.LastName,
                Adress = studentClassVM.Student.Adress,
                ClassID = studentClassVM.Student.ClassID,
                Age = studentClassVM.Student.Age,

            };
            student.Class = db.Classes.FirstOrDefault(x => x.ClassID == student.ClassID); //öğrencinin sınıfını bulup öğrenci sayısını altta arttırıyoruz.
            student.Class.ClassStundentCount++;
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            model.Student = db.Students.FirstOrDefault(x => x.StudentID == id);
            model.Dropdown = Dropdown();
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(int id, StudentClassVM studentClassVM)
        {
            Student student = db.Students.Include(x=>x.Class).FirstOrDefault(x => x.StudentID == id);
            student.FirstName= studentClassVM.Student.FirstName;
            student.LastName= studentClassVM.Student.LastName;
            student.Adress= studentClassVM.Student.Adress;  
            student.Age= studentClassVM.Student.Age;    
            if(student.ClassID== studentClassVM.Student.ClassID)
            {
                student.Class.ClassStundentCount--;
                student.ClassID = studentClassVM.Student.ClassID;
                student.Class = db.Classes.FirstOrDefault(x => x.ClassID == student.ClassID);
                student.Class.ClassStundentCount++;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Student student = db.Students.Include(x => x.Class).FirstOrDefault(x => x.StudentID == id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

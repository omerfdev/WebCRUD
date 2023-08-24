using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManyToManyMVC.Context;
using ManyToManyMVC.Models.Entities;
using ManyToManyMVC.Models;

namespace ManyToManyMVC.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly AppDbContext _context;

        public StudentCourseController(AppDbContext context)
        {
            _context = context;
        }

        
        public  IActionResult Index()
        {
            var model = new StudentCourseModel();
            model.Courses = _context.Course.Include(x => x.StudentCourses).ThenInclude(x => x.Student).ToList();   
            model.Students=_context.Students.Include(x=>x.StudentCourses).ThenInclude(x=>x.Course).ToList();
            return View(model);
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StudentCourses == null)
            {
                return NotFound();
            }

            var studentCourse = await _context.StudentCourses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentCourseID == id);
            if (studentCourse == null)
            {
                return NotFound();
            }

            return View(studentCourse);
        }

       
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID");
            ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentID");
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentCourseID,CourseID,StudentID")] StudentCourse studentCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID", studentCourse.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentID", studentCourse.StudentID);
            return View(studentCourse);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StudentCourses == null)
            {
                return NotFound();
            }

            var studentCourse = await _context.StudentCourses.FindAsync(id);
            if (studentCourse == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID", studentCourse.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentID", studentCourse.StudentID);
            return View(studentCourse);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentCourseID,CourseID,StudentID")] StudentCourse studentCourse)
        {
            if (id != studentCourse.StudentCourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentCourseExists(studentCourse.StudentCourseID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID", studentCourse.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentID", studentCourse.StudentID);
            return View(studentCourse);
        }

        // GET: StudentCourse/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StudentCourses == null)
            {
                return NotFound();
            }

            var studentCourse = await _context.StudentCourses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentCourseID == id);
            if (studentCourse == null)
            {
                return NotFound();
            }

            return View(studentCourse);
        }

        // POST: StudentCourse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StudentCourses == null)
            {
                return Problem("Entity set 'AppDbContext.StudentCourses'  is null.");
            }
            var studentCourse = await _context.StudentCourses.FindAsync(id);
            if (studentCourse != null)
            {
                _context.StudentCourses.Remove(studentCourse);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentCourseExists(int id)
        {
          return (_context.StudentCourses?.Any(e => e.StudentCourseID == id)).GetValueOrDefault();
        }
    }
}

using ManyToManyMVC.Models.Entities;

namespace ManyToManyMVC.Models
{
    public class StudentCourseModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }

    }
}

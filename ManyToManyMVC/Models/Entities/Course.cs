namespace ManyToManyMVC.Models.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public IEnumerable<StudentCourse> StudentCourses { get; set; }
    }
}

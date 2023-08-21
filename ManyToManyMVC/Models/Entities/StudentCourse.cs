namespace ManyToManyMVC.Models.Entities
{
    public class StudentCourse
    {
        public int StudentCourseID { get; set; }
        public Student Student{ get; set; }
        public Course Course{ get; set; }
        public int CourseID{ get; set; }
        public int StudentID{ get; set; }
    }
}

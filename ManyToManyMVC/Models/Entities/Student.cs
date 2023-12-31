﻿namespace ManyToManyMVC.Models.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<StudentCourse> StudentCourses { get; set; }

    }
}
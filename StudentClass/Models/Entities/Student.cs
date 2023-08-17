using System.ComponentModel.DataAnnotations;

namespace StudentClass.Models.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }

        [Display(Name = "Class")]
        public int ClassID { get; set; }
        public Class Class { get; set; }
    }
}

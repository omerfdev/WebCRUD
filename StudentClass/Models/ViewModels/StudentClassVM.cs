using Microsoft.AspNetCore.Mvc.Rendering;
using StudentClass.Models.Entities;

namespace StudentClass.Models.ViewModels
{
    public class StudentClassVM
    {
        public List<Student> Students { get; set; }
        public List<Class> Class { get; set; }
        public List<SelectListItem> Dropdown { get; set; }
        public Student Student { get; set; }       
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUD.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get => FirstName + " " + LastName; }
        public virtual ICollection<FilmActor>? Films { get; set; }
    }
}

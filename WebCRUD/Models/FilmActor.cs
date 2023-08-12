using System.ComponentModel.DataAnnotations;

namespace WebCRUD.Models
{
    public class FilmActor
    {
        [Key]
        public int FAID { get; set; }
        public int ActorID { get; set; }

        public string  ActorRole{ get; set; }
        public int FilmID { get; set; }

        public virtual Film? Film { get; set; }
        public virtual Actor? Actor { get; set; }
    }
}

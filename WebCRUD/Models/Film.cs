namespace WebCRUD.Models
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<FilmActor>? Actors { get; set; }

    }
}

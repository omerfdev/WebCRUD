namespace WebCRUD.Models.ViewModel
{
    public class FilmDetailVM
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }

        public ICollection<ActorVM> Actors { get; set; }
        
    }
}

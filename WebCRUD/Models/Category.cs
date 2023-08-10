namespace WebCRUD.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual Film Films { get; set; }
    }
}

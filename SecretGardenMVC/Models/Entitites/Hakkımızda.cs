using System.ComponentModel.DataAnnotations;

namespace SecretGardenMVC.Models.Entitites
{
    public class Hakkımızda
    {
        [Key]
        public int PersonelId { get; set; }
        public string İsim { get; set; }
        public string Görev { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
    }
}

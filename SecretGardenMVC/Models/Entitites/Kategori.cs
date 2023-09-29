using System.ComponentModel.DataAnnotations;

namespace SecretGardenMVC.Models.Entitites
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }

        public ICollection<Urunler>? Urunler { get; set; }
    }
}

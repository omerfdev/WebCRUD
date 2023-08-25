using System.ComponentModel.DataAnnotations;

namespace GizliBahceMVC.Models.Entitites
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }

        public ICollection<Urunler>? Urunler { get; set; }
    }
}

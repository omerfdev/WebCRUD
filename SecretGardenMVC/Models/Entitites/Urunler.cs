using System.ComponentModel.DataAnnotations;

namespace GizliBahceMVC.Models.Entitites
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public int? KategoriId { get; set; }
        public decimal Fiyat { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunResim { get; set; }
        public Kategori? Kategori { get; set; }
    }
}

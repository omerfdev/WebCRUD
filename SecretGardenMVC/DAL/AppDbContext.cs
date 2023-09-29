
using Microsoft.EntityFrameworkCore;
using SecretGardenMVC.Models.Entitites;

namespace GizliBahceMVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Ozellik> Ozellikler { get; set; }
        public DbSet<Tarihce> Tarihce { get; set; }
        public DbSet<Hakkımızda> Hakkımızda { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { KategoriId = 1, KategoriAd = "Pizza" },
               new Kategori { KategoriId = 2, KategoriAd = "Salata" },
               new Kategori { KategoriId = 3, KategoriAd = "Noodle" }
               );
            modelBuilder.Entity<Urunler>().HasData(
                new Urunler { UrunID = 1, UrunAd = "Fusce dictum finibus", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 55, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 2, UrunAd = "Aliquam sagittis", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan.", Fiyat = 70, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 3, UrunAd = "Sed varius turpis", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 30, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 4, UrunAd = "Aliquam sagittis", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 25, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 5, UrunAd = "Maecenas eget justo", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 80, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 6, UrunAd = "Quisque et felis eros", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 60, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 7, UrunAd = "Sed ultricies dui", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 94, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 8, UrunAd = "Donec porta consequati", UrunAciklama = "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", Fiyat = 15, KategoriId = 1, UrunResim = "/Content/img/gallery/02.jpg" },
                new Urunler { UrunID = 9, UrunAd = "Salad Menu One", KategoriId = 2, UrunAciklama = "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", Fiyat = 25, UrunResim = "/Content/img/gallery/01.jpg" },
                new Urunler { UrunID = 10, UrunAd = "Second Title Salad", KategoriId = 2, UrunAciklama = "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", Fiyat = 30, UrunResim = "/Content/img/gallery/01.jpg" },
                new Urunler { UrunID = 11, UrunAd = "Third Salad Item", KategoriId = 2, UrunAciklama = "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", Fiyat = 45, UrunResim = "/Content/img/gallery/01.jpg" },
                new Urunler { UrunID = 12, UrunAd = "Superior Salad", KategoriId = 2, UrunAciklama = "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", Fiyat = 50, UrunResim = "/Content/img/gallery/01.jpg" },
                new Urunler { UrunID = 13, UrunAd = "Sed ultricies dui", KategoriId = 2, UrunAciklama = "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", Fiyat = 60, UrunResim = "/Content/img/gallery/07.jpg" },
                new Urunler { UrunID = 14, UrunAd = "Maecenas eget justo", KategoriId = 2, UrunAciklama = "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", Fiyat = 75, UrunResim = "/Content/img/gallery/07.jpg" },
                new Urunler { UrunID = 15, UrunAd = "Noodle One", KategoriId = 3, UrunAciklama = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", Fiyat = 12, UrunResim = "/Content/img/gallery/04.jpg" },
                new Urunler { UrunID = 16, UrunAd = "Noodle Second", KategoriId = 3, UrunAciklama = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", Fiyat = 15, UrunResim = "/Content/img/gallery/04.jpg" },
                new Urunler { UrunID = 17, UrunAd = "Third Soft Noodle", KategoriId = 3, UrunAciklama = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", Fiyat = 20, UrunResim = "/Content/img/gallery/04.jpg" },
                new Urunler { UrunID = 18, UrunAd = "Aliquam sagittis", KategoriId = 3, UrunAciklama = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", Fiyat = 30, UrunResim = "/Content/img/gallery/04.jpg" },
                new Urunler { UrunID = 19, UrunAd = "Maecenas eget justo", KategoriId = 3, UrunAciklama = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", Fiyat = 35, UrunResim = "/Content/img/gallery/04.jpg" },
                new Urunler { UrunID = 20, UrunAd = "Quisque et felis eros", KategoriId = 3, UrunAciklama = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", Fiyat = 40, UrunResim = "/Content/img/gallery/04.jpg" }
            );
            modelBuilder.Entity<Hakkımızda>().HasData(
                new Hakkımızda { PersonelId = 1, İsim = "Gül YILMAZ", Görev = "Kurucu ve CEO", Aciklama = "Çanakkale 18 mart Üniversitesi Bilgisayar ve öğretim teknolojileri Eğitmenliği", Resim = "/Content/img/about-01.jpg" },
                new Hakkımızda { PersonelId = 2, İsim = "Parla ŞAHİN", Görev = "Yönetici Şef", Aciklama = "Atatürk Üniversitesi Gastronomi ve Mutfak Sanatları Bölümü", Resim = "/Content/img/about-02.jpg" },
                 new Hakkımızda { PersonelId = 3, İsim = "Tülin MUTLU", Görev = "Mutfak Sorumlusu", Aciklama = "Balıkesir Üniversitesi Gastronomi ve Mutfak Sanatları Bölümü", Resim = "/Content/img/about-03.jpg" },
                  new Hakkımızda { PersonelId = 4, İsim = "Sevgi YILDIZ", Görev = "Şef Yardımcısı", Aciklama = "Akdeniz Üniversitesi Gastronomi ve Mutfak Sanatları Bölümü", Resim = "/Content/img/about-04.jpg" }
            );

            modelBuilder.Entity<Tarihce>().HasData(
                new Tarihce { Id = 1, Resim = "/Content/img/about-06.jpg", Aciklama = "Sed ligula risus, interdum aliquet imperdiet sit amet, auctor sit amet justo. Maecenas posuere lorem id augue interdum vehicula. Praesent sed leo eget libero ultricies congue.\n\nRedistributing this template as a downloadable ZIP file on any template collection site is strictly prohibited. You will need to contact TemplateMo for additional permissions about our templates. Thank you.", Baslik = "History of our restaurant" },
                new Tarihce { Id = 2, Resim = "/Content/img/about-05.jpg", Aciklama = "", Baslik = "" },
                new Tarihce { Id = 3, Resim = "fas fa-4x fa-pepper-hot tm-feature-icon", Aciklama = "Donec sed orci fermentum, convallis lacus id, tempus elit. Sed eu neque accumsan, porttitor arcu a, interdum est. Donec in risus eu ante.", Baslik = "" }, 
                new Tarihce { Id = 4, Resim = "fas fa-4x fa-seedling tm-feature-icon", Aciklama = "Maecenas pretium rutrum molestie. Duis dignissim egestas turpis sit. Nam sed suscipit odio. Morbi in dolor finibus, consequat nisl eget.", Baslik = "" }, 
                new Tarihce { Id = 5, Resim = "fas fa-4x fa-cocktail tm-feature-icon", Aciklama = "Morbi in dolor finibus, consequat nisl eget, pretium nunc. Maecenas pretium rutrum molestie. Duis dignissim egestas turpis sit.", Baslik = "" }
            );

            modelBuilder.Entity<Urunler>().HasOne(x => x.Kategori).WithMany(x => x.Urunler).HasForeignKey(x => x.KategoriId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

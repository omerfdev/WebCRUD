using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecretGardenMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hakkımızda",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Görev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkımızda", x => x.PersonelId);
                });

            migrationBuilder.CreateTable(
                name: "Iletisim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Ozellikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButonRenk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ozellikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarihce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarihce", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunResim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriId");
                });

            migrationBuilder.InsertData(
                table: "Hakkımızda",
                columns: new[] { "PersonelId", "Aciklama", "Görev", "Resim", "İsim" },
                values: new object[,]
                {
                    { 1, "Çanakkale 18 mart Üniversitesi Bilgisayar ve öğretim teknolojileri Eğitmenliği", "Kurucu ve CEO", "/Content/img/about-01.jpg", "Gül YILMAZ" },
                    { 2, "Atatürk Üniversitesi Gastronomi ve Mutfak Sanatları Bölümü", "Yönetici Şef", "/Content/img/about-02.jpg", "Parla ŞAHİN" },
                    { 3, "Balıkesir Üniversitesi Gastronomi ve Mutfak Sanatları Bölümü", "Mutfak Sorumlusu", "/Content/img/about-03.jpg", "Tülin MUTLU" },
                    { 4, "Akdeniz Üniversitesi Gastronomi ve Mutfak Sanatları Bölümü", "Şef Yardımcısı", "/Content/img/about-04.jpg", "Sevgi YILDIZ" }
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriId", "KategoriAd" },
                values: new object[,]
                {
                    { 1, "Pizza" },
                    { 2, "Salata" },
                    { 3, "Noodle" }
                });

            migrationBuilder.InsertData(
                table: "Tarihce",
                columns: new[] { "Id", "Aciklama", "Baslik", "Resim" },
                values: new object[,]
                {
                    { 1, "Sed ligula risus, interdum aliquet imperdiet sit amet, auctor sit amet justo. Maecenas posuere lorem id augue interdum vehicula. Praesent sed leo eget libero ultricies congue.\n\nRedistributing this template as a downloadable ZIP file on any template collection site is strictly prohibited. You will need to contact TemplateMo for additional permissions about our templates. Thank you.", "History of our restaurant", "/Content/img/about-06.jpg" },
                    { 2, "", "", "/Content/img/about-05.jpg" },
                    { 3, "Donec sed orci fermentum, convallis lacus id, tempus elit. Sed eu neque accumsan, porttitor arcu a, interdum est. Donec in risus eu ante.", "", "fas fa-4x fa-pepper-hot tm-feature-icon" },
                    { 4, "Maecenas pretium rutrum molestie. Duis dignissim egestas turpis sit. Nam sed suscipit odio. Morbi in dolor finibus, consequat nisl eget.", "", "fas fa-4x fa-seedling tm-feature-icon" },
                    { 5, "Morbi in dolor finibus, consequat nisl eget, pretium nunc. Maecenas pretium rutrum molestie. Duis dignissim egestas turpis sit.", "", "fas fa-4x fa-cocktail tm-feature-icon" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunID", "Fiyat", "KategoriId", "UrunAciklama", "UrunAd", "UrunResim" },
                values: new object[,]
                {
                    { 1, 55m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Fusce dictum finibus", "/Content/img/gallery/02.jpg" },
                    { 2, 70m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan.", "Aliquam sagittis", "/Content/img/gallery/02.jpg" },
                    { 3, 30m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Sed varius turpis", "/Content/img/gallery/02.jpg" },
                    { 4, 25m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Aliquam sagittis", "/Content/img/gallery/02.jpg" },
                    { 5, 80m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Maecenas eget justo", "/Content/img/gallery/02.jpg" },
                    { 6, 60m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Quisque et felis eros", "/Content/img/gallery/02.jpg" },
                    { 7, 94m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Sed ultricies dui", "/Content/img/gallery/02.jpg" },
                    { 8, 15m, 1, "Nam in suscipit nisi, sit amet consectetur metus. Ut sit amet tellus accumsan", "Donec porta consequati", "/Content/img/gallery/02.jpg" },
                    { 9, 25m, 2, "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", "Salad Menu One", "/Content/img/gallery/01.jpg" },
                    { 10, 30m, 2, "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", "Second Title Salad", "/Content/img/gallery/01.jpg" },
                    { 11, 45m, 2, "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", "Third Salad Item", "/Content/img/gallery/01.jpg" },
                    { 12, 50m, 2, "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", "Superior Salad", "/Content/img/gallery/01.jpg" },
                    { 13, 60m, 2, "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", "Sed ultricies dui", "/Content/img/gallery/07.jpg" },
                    { 14, 75m, 2, "Proin eu velit egestas, viverra sapien eget, consequat nunc. Vestibulum tristique", "Maecenas eget justo", "/Content/img/gallery/07.jpg" },
                    { 15, 12m, 3, "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Noodle One", "/Content/img/gallery/04.jpg" },
                    { 16, 15m, 3, "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Noodle Second", "/Content/img/gallery/04.jpg" },
                    { 17, 20m, 3, "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Third Soft Noodle", "/Content/img/gallery/04.jpg" },
                    { 18, 30m, 3, "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Aliquam sagittis", "/Content/img/gallery/04.jpg" },
                    { 19, 35m, 3, "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Maecenas eget justo", "/Content/img/gallery/04.jpg" },
                    { 20, 40m, 3, "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", "Quisque et felis eros", "/Content/img/gallery/04.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hakkımızda");

            migrationBuilder.DropTable(
                name: "Iletisim");

            migrationBuilder.DropTable(
                name: "Ozellikler");

            migrationBuilder.DropTable(
                name: "Tarihce");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}

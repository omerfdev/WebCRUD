using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCRUD.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmID);
                    table.ForeignKey(
                        name: "FK_Films_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "FilmActor",
                columns: table => new
                {
                    FAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    ActorRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActor", x => x.FAID);
                    table.ForeignKey(
                        name: "FK_FilmActor_Actor_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actor",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActor_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "ActorID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Cem", "YILMAZ" },
                    { 2, "Özkan", "UĞUR" },
                    { 3, "Matt", "Damon" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Drama" },
                    { 2, "Action" },
                    { 3, "Biography" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmID", "CategoryID", "Description", "Duration", "FilmName" },
                values: new object[] { 1, 1, "Bir Uzay Filmi", 109, "G.O.R.A." });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmID", "CategoryID", "Description", "Duration", "FilmName" },
                values: new object[] { 2, 2, "Uzay Filmi", 109, "Installer" });

            migrationBuilder.InsertData(
                table: "FilmActor",
                columns: new[] { "FAID", "ActorID", "ActorRole", "FilmID" },
                values: new object[] { 1, 1, "Arif Işık", 1 });

            migrationBuilder.InsertData(
                table: "FilmActor",
                columns: new[] { "FAID", "ActorID", "ActorRole", "FilmID" },
                values: new object[] { 2, 2, "Garavel", 1 });

            migrationBuilder.InsertData(
                table: "FilmActor",
                columns: new[] { "FAID", "ActorID", "ActorRole", "FilmID" },
                values: new object[] { 3, 3, "Mann", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_FilmActor_ActorID",
                table: "FilmActor",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActor_FilmID",
                table: "FilmActor",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Films_CategoryID",
                table: "Films",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmActor");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}

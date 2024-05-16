using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OneToManyEntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    AuteurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.AuteurId);
                });

            migrationBuilder.CreateTable(
                name: "Boeks",
                columns: table => new
                {
                    BoekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuteurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boeks", x => x.BoekId);
                    table.ForeignKey(
                        name: "FK_Boeks_Auteurs_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Auteurs",
                        principalColumn: "AuteurId");
                });

            migrationBuilder.InsertData(
                table: "Auteurs",
                columns: new[] { "AuteurId", "Naam" },
                values: new object[,]
                {
                    { 1, "I. Asimov" },
                    { 2, "F. Dostoievski" },
                    { 3, "S. King" },
                    { 4, "J.R.R. Tolkien" }
                });

            migrationBuilder.InsertData(
                table: "Boeks",
                columns: new[] { "BoekId", "AuteurId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Foundation" },
                    { 2, 2, "Crimes et Châtiments" },
                    { 3, 3, "Carrie" },
                    { 4, 4, "The Lord of the Ring" },
                    { 5, 1, "Robots" },
                    { 6, 2, "Les frères Karkarov" },
                    { 7, 3, "Les Régulateurs" },
                    { 8, 4, "The Hobbits" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boeks_AuteurId",
                table: "Boeks",
                column: "AuteurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boeks");

            migrationBuilder.DropTable(
                name: "Auteurs");
        }
    }
}

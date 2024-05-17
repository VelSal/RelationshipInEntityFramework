using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyEntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class ok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoekenViewModelId",
                table: "Auteurs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BoekenViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeselecteerdeAuteurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoekenViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoekAuteurViewModel",
                columns: table => new
                {
                    BoekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuteurNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoekenViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoekAuteurViewModel", x => x.BoekId);
                    table.ForeignKey(
                        name: "FK_BoekAuteurViewModel_BoekenViewModel_BoekenViewModelId",
                        column: x => x.BoekenViewModelId,
                        principalTable: "BoekenViewModel",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 1,
                column: "BoekenViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 2,
                column: "BoekenViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 3,
                column: "BoekenViewModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Auteurs",
                keyColumn: "AuteurId",
                keyValue: 4,
                column: "BoekenViewModelId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Auteurs_BoekenViewModelId",
                table: "Auteurs",
                column: "BoekenViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BoekAuteurViewModel_BoekenViewModelId",
                table: "BoekAuteurViewModel",
                column: "BoekenViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auteurs_BoekenViewModel_BoekenViewModelId",
                table: "Auteurs",
                column: "BoekenViewModelId",
                principalTable: "BoekenViewModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auteurs_BoekenViewModel_BoekenViewModelId",
                table: "Auteurs");

            migrationBuilder.DropTable(
                name: "BoekAuteurViewModel");

            migrationBuilder.DropTable(
                name: "BoekenViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Auteurs_BoekenViewModelId",
                table: "Auteurs");

            migrationBuilder.DropColumn(
                name: "BoekenViewModelId",
                table: "Auteurs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyEntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class Addedbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boeks",
                columns: new[] { "BoekId", "AuteurId", "Title" },
                values: new object[] { 9, 4, "Bombadil" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 9);
        }
    }
}

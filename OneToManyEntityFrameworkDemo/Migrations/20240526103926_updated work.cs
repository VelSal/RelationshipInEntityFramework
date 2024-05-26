using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyEntityFrameworkDemo.Migrations
{
    /// <inheritdoc />
    public partial class updatedwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auteurs_BoekenViewModel_BoekenViewModelId",
                table: "Auteurs");

            migrationBuilder.DropForeignKey(
                name: "FK_BoekAuteurViewModel_BoekenViewModel_BoekenViewModelId",
                table: "BoekAuteurViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoekenViewModel",
                table: "BoekenViewModel");

            migrationBuilder.DropIndex(
                name: "IX_BoekAuteurViewModel_BoekenViewModelId",
                table: "BoekAuteurViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Auteurs_BoekenViewModelId",
                table: "Auteurs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BoekenViewModel");

            migrationBuilder.DropColumn(
                name: "BoekenViewModelId",
                table: "BoekAuteurViewModel");

            migrationBuilder.DropColumn(
                name: "BoekenViewModelId",
                table: "Auteurs");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Boeks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BindingType",
                table: "Boeks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Boeks",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBestSeller",
                table: "Boeks",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewRelease",
                table: "Boeks",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 1,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 2,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 3,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 4,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 5,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 6,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 7,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 8,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Boeks",
                keyColumn: "BoekId",
                keyValue: 9,
                columns: new[] { "BindingType", "IsAvailable", "IsBestSeller", "IsNewRelease" },
                values: new object[] { null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BindingType",
                table: "Boeks");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Boeks");

            migrationBuilder.DropColumn(
                name: "IsBestSeller",
                table: "Boeks");

            migrationBuilder.DropColumn(
                name: "IsNewRelease",
                table: "Boeks");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Boeks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BoekenViewModel",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BoekenViewModelId",
                table: "BoekAuteurViewModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BoekenViewModelId",
                table: "Auteurs",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoekenViewModel",
                table: "BoekenViewModel",
                column: "Id");

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
                name: "IX_BoekAuteurViewModel_BoekenViewModelId",
                table: "BoekAuteurViewModel",
                column: "BoekenViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Auteurs_BoekenViewModelId",
                table: "Auteurs",
                column: "BoekenViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auteurs_BoekenViewModel_BoekenViewModelId",
                table: "Auteurs",
                column: "BoekenViewModelId",
                principalTable: "BoekenViewModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BoekAuteurViewModel_BoekenViewModel_BoekenViewModelId",
                table: "BoekAuteurViewModel",
                column: "BoekenViewModelId",
                principalTable: "BoekenViewModel",
                principalColumn: "Id");
        }
    }
}

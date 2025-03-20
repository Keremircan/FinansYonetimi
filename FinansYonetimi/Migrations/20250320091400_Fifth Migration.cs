using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinansYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isim",
                table: "Receivables");

            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "Receivables",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ParaBirimi",
                table: "Receivables",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Miktar",
                table: "Receivables",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "Receivables",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "No",
                table: "Receivables",
                newName: "RID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Receivables",
                newName: "ParaBirimi");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Receivables",
                newName: "Aciklama");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Receivables",
                newName: "Tarih");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Receivables",
                newName: "Miktar");

            migrationBuilder.RenameColumn(
                name: "RID",
                table: "Receivables",
                newName: "No");

            migrationBuilder.AddColumn<string>(
                name: "Isim",
                table: "Receivables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

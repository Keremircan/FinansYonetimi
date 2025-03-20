using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinansYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Receivables",
                newName: "Isim");

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
                name: "ParaBirimi",
                table: "Receivables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "Receivables",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Isim",
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
    }
}

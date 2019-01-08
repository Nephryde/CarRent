using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class Dodanieadresudlaklientaorazusunięciekosztuwwypożyczeniu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Rents");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Workers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Workers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Workers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Workers");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Rents",
                nullable: false,
                defaultValue: 0m);
        }
    }
}

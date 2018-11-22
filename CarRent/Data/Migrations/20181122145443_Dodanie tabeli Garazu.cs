using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class DodanietabeliGarazu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GarageId",
                table: "Workers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Garage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_GarageId",
                table: "Workers",
                column: "GarageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Garage_GarageId",
                table: "Workers",
                column: "GarageId",
                principalTable: "Garage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Garage_GarageId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Garage");

            migrationBuilder.DropIndex(
                name: "IX_Workers_GarageId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "GarageId",
                table: "Workers");
        }
    }
}

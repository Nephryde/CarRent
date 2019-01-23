using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class UsunięcieBossId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Workers_BossId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_BossId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "BossId",
                table: "Workers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BossId",
                table: "Workers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_BossId",
                table: "Workers",
                column: "BossId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Workers_BossId",
                table: "Workers",
                column: "BossId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class Dodanieworkeraijobavol2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Boss",
                table: "Workers");

            migrationBuilder.RenameColumn(
                name: "Job_Name",
                table: "Jobs",
                newName: "JobName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "Jobs",
                newName: "Job_Name");

            migrationBuilder.AddColumn<int>(
                name: "Id_Boss",
                table: "Workers",
                nullable: false,
                defaultValue: 0);
        }
    }
}

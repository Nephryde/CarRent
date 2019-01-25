using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class Dodaniekluczaidworkerawzwolnieniu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exemptions_Workers_WorkerId",
                table: "Exemptions");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Exemptions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exemptions_Workers_WorkerId",
                table: "Exemptions",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exemptions_Workers_WorkerId",
                table: "Exemptions");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Exemptions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Exemptions_Workers_WorkerId",
                table: "Exemptions",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

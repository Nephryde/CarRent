using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class DodanieidkluczówdoEmployment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_TypesOfEmployment_TypeOfEmploymentId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Workers_WorkerId",
                table: "Employments");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Employments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfEmploymentId",
                table: "Employments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_TypesOfEmployment_TypeOfEmploymentId",
                table: "Employments",
                column: "TypeOfEmploymentId",
                principalTable: "TypesOfEmployment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Workers_WorkerId",
                table: "Employments",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employments_TypesOfEmployment_TypeOfEmploymentId",
                table: "Employments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employments_Workers_WorkerId",
                table: "Employments");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Employments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfEmploymentId",
                table: "Employments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_TypesOfEmployment_TypeOfEmploymentId",
                table: "Employments",
                column: "TypeOfEmploymentId",
                principalTable: "TypesOfEmployment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employments_Workers_WorkerId",
                table: "Employments",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

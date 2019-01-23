using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class DodanieidkluczówdoEmployeeTraining : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainings_Courses_CourseId",
                table: "EmployeeTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainings_Workers_WorkerId",
                table: "EmployeeTrainings");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "EmployeeTrainings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "EmployeeTrainings",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainings_Courses_CourseId",
                table: "EmployeeTrainings",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainings_Workers_WorkerId",
                table: "EmployeeTrainings",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainings_Courses_CourseId",
                table: "EmployeeTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainings_Workers_WorkerId",
                table: "EmployeeTrainings");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "EmployeeTrainings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "EmployeeTrainings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainings_Courses_CourseId",
                table: "EmployeeTrainings",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainings_Workers_WorkerId",
                table: "EmployeeTrainings",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

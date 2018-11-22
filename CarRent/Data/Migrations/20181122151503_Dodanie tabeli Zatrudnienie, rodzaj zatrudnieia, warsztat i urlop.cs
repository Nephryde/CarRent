using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class DodanietabeliZatrudnienierodzajzatrudnieiawarsztatiurlop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacation_Workers_WorkerId",
                table: "Vacation");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Garage_GarageId",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacation",
                table: "Vacation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Garage",
                table: "Garage");

            migrationBuilder.RenameTable(
                name: "Vacation",
                newName: "Vacations");

            migrationBuilder.RenameTable(
                name: "Garage",
                newName: "Garages");

            migrationBuilder.RenameIndex(
                name: "IX_Vacation_WorkerId",
                table: "Vacations",
                newName: "IX_Vacations_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacations",
                table: "Vacations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Garages",
                table: "Garages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TypesOfEmployment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfEmployment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkerId = table.Column<int>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    Bonus = table.Column<decimal>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    TypeOfEmploymentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employments_TypesOfEmployment_TypeOfEmploymentId",
                        column: x => x.TypeOfEmploymentId,
                        principalTable: "TypesOfEmployment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employments_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employments_TypeOfEmploymentId",
                table: "Employments",
                column: "TypeOfEmploymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employments_WorkerId",
                table: "Employments",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Workers_WorkerId",
                table: "Vacations",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Garages_GarageId",
                table: "Workers",
                column: "GarageId",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Workers_WorkerId",
                table: "Vacations");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Garages_GarageId",
                table: "Workers");

            migrationBuilder.DropTable(
                name: "Employments");

            migrationBuilder.DropTable(
                name: "TypesOfEmployment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacations",
                table: "Vacations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Garages",
                table: "Garages");

            migrationBuilder.RenameTable(
                name: "Vacations",
                newName: "Vacation");

            migrationBuilder.RenameTable(
                name: "Garages",
                newName: "Garage");

            migrationBuilder.RenameIndex(
                name: "IX_Vacations_WorkerId",
                table: "Vacation",
                newName: "IX_Vacation_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacation",
                table: "Vacation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Garage",
                table: "Garage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacation_Workers_WorkerId",
                table: "Vacation",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Garage_GarageId",
                table: "Workers",
                column: "GarageId",
                principalTable: "Garage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

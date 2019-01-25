using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class Dodaniekluczarodzajuplatnosciwplatnosci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_TypesOfPayment_TypesOfPaymentId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_TypesOfPaymentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TypesOfPaymentId",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "TypeOfPaymentId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TypeOfPaymentId",
                table: "Payments",
                column: "TypeOfPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_TypesOfPayment_TypeOfPaymentId",
                table: "Payments",
                column: "TypeOfPaymentId",
                principalTable: "TypesOfPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_TypesOfPayment_TypeOfPaymentId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_TypeOfPaymentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TypeOfPaymentId",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "TypesOfPaymentId",
                table: "Payments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TypesOfPaymentId",
                table: "Payments",
                column: "TypesOfPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_TypesOfPayment_TypesOfPaymentId",
                table: "Payments",
                column: "TypesOfPaymentId",
                principalTable: "TypesOfPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

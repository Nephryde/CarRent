using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.Data.Migrations
{
    public partial class Dodaniekluczyidwduzomodelach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_Brandes_BrandId",
                table: "CarModels");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_CarModels_CarModelId",
                table: "CustomerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_Customers_CustomerId",
                table: "CustomerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_ReplacementCars_ReplacementCarId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplacementCars_CarModels_CarModelId",
                table: "ReplacementCars");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplacementCars_Garages_GarageId",
                table: "ReplacementCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_CustomerCars_CustomerCarId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_TypesOfService_TypesOfServiceId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Workers_WorkerId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_TypesOfServiceId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "TypesOfServiceId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Services",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerCarId",
                table: "Services",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfServiceId",
                table: "Services",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "GarageId",
                table: "ReplacementCars",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "ReplacementCars",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReplacementCarId",
                table: "Rents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Rents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerCars",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "CustomerCars",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "CarModels",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_TypeOfServiceId",
                table: "Services",
                column: "TypeOfServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Brandes_BrandId",
                table: "CarModels",
                column: "BrandId",
                principalTable: "Brandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_CarModels_CarModelId",
                table: "CustomerCars",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_Customers_CustomerId",
                table: "CustomerCars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_ReplacementCars_ReplacementCarId",
                table: "Rents",
                column: "ReplacementCarId",
                principalTable: "ReplacementCars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplacementCars_CarModels_CarModelId",
                table: "ReplacementCars",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplacementCars_Garages_GarageId",
                table: "ReplacementCars",
                column: "GarageId",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_CustomerCars_CustomerCarId",
                table: "Services",
                column: "CustomerCarId",
                principalTable: "CustomerCars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_TypesOfService_TypeOfServiceId",
                table: "Services",
                column: "TypeOfServiceId",
                principalTable: "TypesOfService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Workers_WorkerId",
                table: "Services",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModels_Brandes_BrandId",
                table: "CarModels");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_CarModels_CarModelId",
                table: "CustomerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCars_Customers_CustomerId",
                table: "CustomerCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_ReplacementCars_ReplacementCarId",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplacementCars_CarModels_CarModelId",
                table: "ReplacementCars");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplacementCars_Garages_GarageId",
                table: "ReplacementCars");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_CustomerCars_CustomerCarId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_TypesOfService_TypeOfServiceId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Workers_WorkerId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_TypeOfServiceId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "TypeOfServiceId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Services",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerCarId",
                table: "Services",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TypesOfServiceId",
                table: "Services",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GarageId",
                table: "ReplacementCars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "ReplacementCars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ReplacementCarId",
                table: "Rents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Rents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerCars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "CustomerCars",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "CarModels",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Services_TypesOfServiceId",
                table: "Services",
                column: "TypesOfServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModels_Brandes_BrandId",
                table: "CarModels",
                column: "BrandId",
                principalTable: "Brandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_CarModels_CarModelId",
                table: "CustomerCars",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCars_Customers_CustomerId",
                table: "CustomerCars",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_ReplacementCars_ReplacementCarId",
                table: "Rents",
                column: "ReplacementCarId",
                principalTable: "ReplacementCars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplacementCars_CarModels_CarModelId",
                table: "ReplacementCars",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplacementCars_Garages_GarageId",
                table: "ReplacementCars",
                column: "GarageId",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_CustomerCars_CustomerCarId",
                table: "Services",
                column: "CustomerCarId",
                principalTable: "CustomerCars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_TypesOfService_TypesOfServiceId",
                table: "Services",
                column: "TypesOfServiceId",
                principalTable: "TypesOfService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Workers_WorkerId",
                table: "Services",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

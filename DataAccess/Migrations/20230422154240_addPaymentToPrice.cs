using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addPaymentToPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payments_ParcelId",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Parcels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Posted",
                table: "Parcels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Received",
                table: "Parcels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ParcelId",
                table: "Payments",
                column: "ParcelId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payments_ParcelId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "Posted",
                table: "Parcels");

            migrationBuilder.DropColumn(
                name: "Received",
                table: "Parcels");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ParcelId",
                table: "Payments",
                column: "ParcelId");
        }
    }
}

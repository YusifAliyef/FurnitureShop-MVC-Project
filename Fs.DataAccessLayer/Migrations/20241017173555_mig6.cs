using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fs.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ProductOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(177), new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(189), new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(193), new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(197), new DateTime(2024, 10, 17, 17, 35, 54, 779, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 17, 35, 54, 775, DateTimeKind.Utc).AddTicks(2892), new DateTime(2024, 10, 17, 17, 35, 54, 775, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductOrders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1137), new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 9, 22, 8, 11, 50, 175, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 22, 8, 11, 50, 173, DateTimeKind.Utc).AddTicks(1330), new DateTime(2024, 9, 22, 8, 11, 50, 173, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.AddForeignKey(
                name: "FK_UploadedFiles_Products_ProductId",
                table: "UploadedFiles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}

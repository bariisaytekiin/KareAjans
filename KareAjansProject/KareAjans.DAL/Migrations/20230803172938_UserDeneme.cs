using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KareAjans.DAL.Migrations
{
    public partial class UserDeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 722, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 723, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 723, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 724, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 724, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 724, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 724, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 29, 37, 725, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 433, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 434, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 434, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 435, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 28, 11, 436, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KareAjans.DAL.Migrations
{
    public partial class oderUserIdAdd : Migration
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
                value: new DateTime(2023, 8, 3, 20, 44, 7, 478, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 479, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 479, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 480, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 480, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 480, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 481, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 44, 7, 482, DateTimeKind.Local).AddTicks(6075));

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
                value: new DateTime(2023, 8, 3, 20, 43, 8, 930, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 931, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 931, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 932, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 932, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 932, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 932, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 20, 43, 8, 933, DateTimeKind.Local).AddTicks(9876));

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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KareAjans.DAL.Migrations
{
    public partial class mankenEmailAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Mankenler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 839, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 840, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 840, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 841, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 841, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 841, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(3143), "a@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(5713), "b@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(5722), "c@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(5726), "d@gmail.com" });

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 842, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 4, 15, 9, 1, 843, DateTimeKind.Local).AddTicks(6323));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Mankenler");

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
        }
    }
}

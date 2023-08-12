using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KareAjans.DAL.Migrations
{
    public partial class adresupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ulke",
                table: "Adresler");

            migrationBuilder.AddColumn<string>(
                name: "OrganizasyonSehirAdresi",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 282, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 283, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 283, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 284, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 284, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 284, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 284, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 3, 0, 53, 15, 285, DateTimeKind.Local).AddTicks(8255));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizasyonSehirAdresi",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Ulke",
                table: "Adresler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Ulke" },
                values: new object[] { new DateTime(2023, 7, 27, 20, 0, 21, 498, DateTimeKind.Local).AddTicks(4621), "Türkiye" });

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Ulke" },
                values: new object[] { new DateTime(2023, 7, 27, 20, 0, 21, 499, DateTimeKind.Local).AddTicks(6177), "Türkiye" });

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Ulke" },
                values: new object[] { new DateTime(2023, 7, 27, 20, 0, 21, 499, DateTimeKind.Local).AddTicks(6186), "Türkiye" });

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 500, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 501, DateTimeKind.Local).AddTicks(6733));
        }
    }
}

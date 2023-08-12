using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KareAjans.DAL.Migrations
{
    public partial class mankenguncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 498, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 499, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 20, 0, 21, 499, DateTimeKind.Local).AddTicks(6186));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 617, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 619, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Adresler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 619, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 619, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 619, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Fotograflar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 619, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Mankenler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGelirler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "OrganizasyonGiderler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Organizasyonlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 620, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 621, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 621, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Yorumlar",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 27, 2, 35, 5, 621, DateTimeKind.Local).AddTicks(823));
        }
    }
}

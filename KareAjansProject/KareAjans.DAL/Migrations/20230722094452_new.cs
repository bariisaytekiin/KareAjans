using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KareAjans.DAL.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcikAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizasyonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Onaylama = table.Column<bool>(type: "bit", nullable: false),
                    OrganizasyonAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizasyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizasyonAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizasyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizasyonlar_Adresler_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adresler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mankenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TelefonNo2 = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    AyakkabıNo = table.Column<int>(type: "int", nullable: false),
                    Beden = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Boy = table.Column<short>(type: "smallint", nullable: false),
                    SacRengi = table.Column<int>(type: "int", nullable: false),
                    GozRengi = table.Column<int>(type: "int", nullable: false),
                    SehirDisiCalisma = table.Column<bool>(type: "bit", nullable: false),
                    Ehliyet = table.Column<bool>(type: "bit", nullable: false),
                    Özellik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YabanciDil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kategori = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mankenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mankenler_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizasyonGelirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizasyonId = table.Column<int>(type: "int", nullable: false),
                    Butce = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizasyonGelirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizasyonGelirler_Organizasyonlar_OrganizasyonId",
                        column: x => x.OrganizasyonId,
                        principalTable: "Organizasyonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotograflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MankenId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograflar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotograflar_Mankenler_MankenId",
                        column: x => x.MankenId,
                        principalTable: "Mankenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MankenId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Kategori = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Mankenler_MankenId",
                        column: x => x.MankenId,
                        principalTable: "Mankenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrganizasyonGiderler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizasyonId = table.Column<int>(type: "int", nullable: false),
                    MankenId = table.Column<int>(type: "int", nullable: false),
                    Butce = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GunSayisi = table.Column<int>(type: "int", nullable: false),
                    OgunUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KonaklamaUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GunlukUcret = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KategoriUcMankenSayisi = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizasyonGiderler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizasyonGiderler_Mankenler_MankenId",
                        column: x => x.MankenId,
                        principalTable: "Mankenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizasyonGiderler_Organizasyonlar_OrganizasyonId",
                        column: x => x.OrganizasyonId,
                        principalTable: "Organizasyonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MankenId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Mankenler_MankenId",
                        column: x => x.MankenId,
                        principalTable: "Mankenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adresler",
                columns: new[] { "Id", "AcikAdres", "CreatedDate", "IsActive", "Sehir", "Status", "Ulke", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Yeni Mah. No:89 D:4 Pendik", new DateTime(2023, 7, 22, 12, 44, 51, 493, DateTimeKind.Local).AddTicks(230), true, "İstanbul", 1, "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Cumhuriyet Mah. No:8 D:9 Kartal", new DateTime(2023, 7, 22, 12, 44, 51, 494, DateTimeKind.Local).AddTicks(3701), true, "İstanbul", 1, "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Zaman Mah. No:30 Kızılay", new DateTime(2023, 7, 22, 12, 44, 51, 494, DateTimeKind.Local).AddTicks(3708), true, "Ankara", 1, "Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Mankenler",
                columns: new[] { "Id", "Ad", "Adres", "AyakkabıNo", "Beden", "Boy", "Cinsiyet", "CreatedDate", "DogumTarihi", "Ehliyet", "GozRengi", "IsActive", "Kategori", "Kilo", "SacRengi", "SehirDisiCalisma", "Soyad", "Status", "TelefonNo", "TelefonNo2", "UpdatedDate", "UserId", "YabanciDil", "Özellik" },
                values: new object[,]
                {
                    { 1, "Ayşe", "Yeni Mah. Pendik/İstanbul", 36, 2, (short)160, 0, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(5609), new DateTime(2010, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, true, 1, 45m, 0, true, "Alev", 1, "905058529632", "905328547896", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "İngilizce,Almanca", "Girişken" },
                    { 2, "Ahmet", "Eski Mah. Kadıköy/İstanbul", 41, 4, (short)180, 1, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(7352), new DateTime(1995, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, true, 2, 75m, 0, true, "Can", 1, "905529529632", "905368548596", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "İngilizce", "Girişken" },
                    { 3, "Fatma", "Güzel Mah. Ümraniye/İstanbul", 37, 2, (short)170, 0, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(7357), new DateTime(1997, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 0, true, 3, 55m, 5, false, "Kalyon", 1, "905638512632", "905985647896", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "İspanyolca", "Girişken" },
                    { 4, "Ayşegül", "Yeni Mah. Levent/İstanbul", 37, 3, (short)165, 0, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(7360), new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, true, 3, 45m, 0, true, "Ay", 1, "905075329632", "905328253496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "Sıcak Kanlı" }
                });

            migrationBuilder.InsertData(
                table: "Fotograflar",
                columns: new[] { "Id", "CreatedDate", "IsActive", "MankenId", "Status", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(1416), true, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(1597), true, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(1599), true, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Organizasyonlar",
                columns: new[] { "Id", "AdresId", "BaslangicTarihi", "BitisTarihi", "CreatedDate", "IsActive", "OrganizasyonAdi", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(9185), true, "A standı", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(9857), true, "A standı", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 12, 44, 51, 495, DateTimeKind.Local).AddTicks(9860), true, "A standı", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Yorumlar",
                columns: new[] { "Id", "CreatedDate", "IsActive", "MankenId", "Mesaj", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(5765), true, 1, "İlerlemesi güzel", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(6060), true, 2, "Çok sessiz", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(6062), true, 2, "Çok sessiz", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrganizasyonGelirler",
                columns: new[] { "Id", "Butce", "CreatedDate", "IsActive", "OrganizasyonId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 25000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(1248), true, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 35000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(1557), true, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 45000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(1559), true, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrganizasyonGiderler",
                columns: new[] { "Id", "Butce", "CreatedDate", "GunSayisi", "GunlukUcret", "IsActive", "KategoriUcMankenSayisi", "KonaklamaUcreti", "MankenId", "OgunUcreti", "OrganizasyonId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 25000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(3910), 5, 500m, true, 0, 500m, 1, 150m, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 25000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(4628), 5, 1000m, true, 0, 500m, 2, 150m, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 25000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(4631), 2, 0m, true, 2, 500m, 3, 150m, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 25000m, new DateTime(2023, 7, 22, 12, 44, 51, 496, DateTimeKind.Local).AddTicks(4708), 2, 0m, true, 2, 500m, 4, 150m, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Fotograflar_MankenId",
                table: "Fotograflar",
                column: "MankenId");

            migrationBuilder.CreateIndex(
                name: "IX_Mankenler_UserId",
                table: "Mankenler",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MankenId",
                table: "OrderDetails",
                column: "MankenId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizasyonGelirler_OrganizasyonId",
                table: "OrganizasyonGelirler",
                column: "OrganizasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizasyonGiderler_MankenId",
                table: "OrganizasyonGiderler",
                column: "MankenId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizasyonGiderler_OrganizasyonId",
                table: "OrganizasyonGiderler",
                column: "OrganizasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizasyonlar_AdresId",
                table: "Organizasyonlar",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_MankenId",
                table: "Yorumlar",
                column: "MankenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Fotograflar");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrganizasyonGelirler");

            migrationBuilder.DropTable(
                name: "OrganizasyonGiderler");

            migrationBuilder.DropTable(
                name: "Yorumlar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Organizasyonlar");

            migrationBuilder.DropTable(
                name: "Mankenler");

            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

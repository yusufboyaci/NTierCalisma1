using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTierCalisma1.DATAACCESS.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OluşturulmaZamanı = table.Column<DateTime>(name: "Oluşturulma Zamanı", type: "datetime2", nullable: true),
                    OluşturulanBilgisayarAdı = table.Column<string>(name: "Oluşturulan Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    OluşturulanIPAdresi = table.Column<string>(name: "Oluşturulan IP Adresi", type: "nvarchar(max)", nullable: true),
                    OluşturulanKullanıcıAdminAdı = table.Column<string>(name: "Oluşturulan Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    OluşturanKişi = table.Column<int>(name: "Oluşturan Kişi", type: "int", nullable: true),
                    GüncellenenZamanı = table.Column<DateTime>(name: "Güncellenen Zamanı", type: "datetime2", nullable: true),
                    GüncellenenBilgisayarAdı = table.Column<string>(name: "Güncellenen Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenIPAdresi = table.Column<string>(name: "Güncellenen IP Adresi", type: "nvarchar(max)", nullable: true),
                    GüncellenenKullanıcıAdminAdı = table.Column<string>(name: "Güncellenen Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenKişi = table.Column<int>(name: "Güncellenen Kişi", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MasterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OluşturulmaZamanı = table.Column<DateTime>(name: "Oluşturulma Zamanı", type: "datetime2", nullable: true),
                    OluşturulanBilgisayarAdı = table.Column<string>(name: "Oluşturulan Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    OluşturulanIPAdresi = table.Column<string>(name: "Oluşturulan IP Adresi", type: "nvarchar(max)", nullable: true),
                    OluşturulanKullanıcıAdminAdı = table.Column<string>(name: "Oluşturulan Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    OluşturanKişi = table.Column<int>(name: "Oluşturan Kişi", type: "int", nullable: true),
                    GüncellenenZamanı = table.Column<DateTime>(name: "Güncellenen Zamanı", type: "datetime2", nullable: true),
                    GüncellenenBilgisayarAdı = table.Column<string>(name: "Güncellenen Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenIPAdresi = table.Column<string>(name: "Güncellenen IP Adresi", type: "nvarchar(max)", nullable: true),
                    GüncellenenKullanıcıAdminAdı = table.Column<string>(name: "Güncellenen Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenKişi = table.Column<int>(name: "Güncellenen Kişi", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    QuantityPerUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OluşturulmaZamanı = table.Column<DateTime>(name: "Oluşturulma Zamanı", type: "datetime2", nullable: true),
                    OluşturulanBilgisayarAdı = table.Column<string>(name: "Oluşturulan Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    OluşturulanIPAdresi = table.Column<string>(name: "Oluşturulan IP Adresi", type: "nvarchar(max)", nullable: true),
                    OluşturulanKullanıcıAdminAdı = table.Column<string>(name: "Oluşturulan Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    OluşturanKişi = table.Column<int>(name: "Oluşturan Kişi", type: "int", nullable: true),
                    GüncellenenZamanı = table.Column<DateTime>(name: "Güncellenen Zamanı", type: "datetime2", nullable: true),
                    GüncellenenBilgisayarAdı = table.Column<string>(name: "Güncellenen Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenIPAdresi = table.Column<string>(name: "Güncellenen IP Adresi", type: "nvarchar(max)", nullable: true),
                    GüncellenenKullanıcıAdminAdı = table.Column<string>(name: "Güncellenen Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenKişi = table.Column<int>(name: "Güncellenen Kişi", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Confirmed = table.Column<bool>(type: "bit", nullable: false),
                    MasterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OluşturulmaZamanı = table.Column<DateTime>(name: "Oluşturulma Zamanı", type: "datetime2", nullable: true),
                    OluşturulanBilgisayarAdı = table.Column<string>(name: "Oluşturulan Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    OluşturulanIPAdresi = table.Column<string>(name: "Oluşturulan IP Adresi", type: "nvarchar(max)", nullable: true),
                    OluşturulanKullanıcıAdminAdı = table.Column<string>(name: "Oluşturulan Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    OluşturanKişi = table.Column<int>(name: "Oluşturan Kişi", type: "int", nullable: true),
                    GüncellenenZamanı = table.Column<DateTime>(name: "Güncellenen Zamanı", type: "datetime2", nullable: true),
                    GüncellenenBilgisayarAdı = table.Column<string>(name: "Güncellenen Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenIPAdresi = table.Column<string>(name: "Güncellenen IP Adresi", type: "nvarchar(max)", nullable: true),
                    GüncellenenKullanıcıAdminAdı = table.Column<string>(name: "Güncellenen Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenKişi = table.Column<int>(name: "Güncellenen Kişi", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MasterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OluşturulmaZamanı = table.Column<DateTime>(name: "Oluşturulma Zamanı", type: "datetime2", nullable: true),
                    OluşturulanBilgisayarAdı = table.Column<string>(name: "Oluşturulan Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    OluşturulanIPAdresi = table.Column<string>(name: "Oluşturulan IP Adresi", type: "nvarchar(max)", nullable: true),
                    OluşturulanKullanıcıAdminAdı = table.Column<string>(name: "Oluşturulan Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    OluşturanKişi = table.Column<int>(name: "Oluşturan Kişi", type: "int", nullable: true),
                    GüncellenenZamanı = table.Column<DateTime>(name: "Güncellenen Zamanı", type: "datetime2", nullable: true),
                    GüncellenenBilgisayarAdı = table.Column<string>(name: "Güncellenen Bilgisayar Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenIPAdresi = table.Column<string>(name: "Güncellenen IP Adresi", type: "nvarchar(max)", nullable: true),
                    GüncellenenKullanıcıAdminAdı = table.Column<string>(name: "Güncellenen Kullanıcı Admin Adı", type: "nvarchar(max)", nullable: true),
                    GüncellenenKişi = table.Column<int>(name: "Güncellenen Kişi", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

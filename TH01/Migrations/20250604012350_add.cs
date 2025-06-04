using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TH01.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsTrendingProduct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Orders = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Americano là một shot espresso pha với nước nóng. Nó thường được pha trong một cốc 6 ounce và gồm một nửa espresso và một nửa nước nóng, hoặc ⅓ espresso và ⅔ nước nóng.\n Thông thường mọi người sẽ uống nước, sau đó thêm espresso lên trên, \n vì nó giữ được lớp crema, là lớp bọt màu nâu đỏ, nhưng cũng có thể làm ngược lại.", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", false, "America", 25m },
                    { 2, "Trung Nguyen Legend is a Vietnamese business group engaged in coffee production, processing, and distribution. It is known as the largest domestic coffee brand in Vietnam, exporting products to over 60 countries, including major markets such as G7 countries, the United States,\n the European Union, the United Kingdom, Germany, China, Canada, Russia, Japan, Dubai, and ASEAN. When talking about quality Vietnamese coffee,\n this brand with its aromatic and robust coffee cannot be overlooked", "https://bna.1cdn.vn/2025/02/02/cdnphoto.dantri.com.vn-i7ew_jatefe35zxjrpzbe0euvlk-thumb_w-1020-2022-08-06-_caphe-1659747941762.jpeg", false, "Vietnam", 20m },
                    { 3, "In the UK, coffee preferences are varied but a\n few stand out as particularly popular. While many enjoy flat whites\n, cappuccinos, and lattes, the most popular coffee drink in the UK is the flat white", "https://images2.thanhnien.vn/528068263637045248/2023/9/8/cafefqxn-16941744457661231106144.jpg", false, "United Kingdom", 15m },
                    { 4, "Indian Mysore coffee is a market name for high-quality wet processed (washed)\n coffees from the southern region in the state of Karnataka. The coffee is known for its subtle,\n rich flavor complemented by a medium to full body and moderate though distinct acidity.", "https://suckhoedoisong.qltns.mediacdn.vn/324455921873985536/2024/10/16/ca-phe-1-17290637850462076395892.jpg", false, "India", 15m },
                    { 5, "Raf coffee (Russian: раф-кофе) is a popular coffee drink in some countries of the former USSR,\n which appeared in the late 1990s in Russia. Prepared by adding cream and vanilla sugar to a single shot of espresso and\n then foaming the mix with a steam heater.", "https://simexcodl.com.vn/wp-content/uploads/2023/11/cac-loai-ca-phe-o-viet-nam-8.jpg", false, "Russian", 25m },
                    { 6, "This refers to regular black coffee. It is usually served in small portions as an espresso or French press coffee.\n The French enjoy café noir with meals or as a pick-me-up in the afternoon.", "https://file.hstatic.net/1000274203/article/ca_phe_robusta_va_arabica_loai_nao_ngon_09d00c9c4e76439786c981c7a8c43cd0.jpg", false, "France", 35m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_OrderId",
                table: "OrdersDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_ProductId",
                table: "OrdersDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

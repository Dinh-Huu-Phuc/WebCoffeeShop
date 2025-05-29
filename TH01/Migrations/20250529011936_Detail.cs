using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TH01.Migrations
{
    /// <inheritdoc />
    public partial class Detail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Americano là một shot espresso pha với nước nóng. Nó thường được pha trong một cốc 6 ounce và gồm một nửa espresso và một nửa nước nóng, hoặc ⅓ espresso và ⅔ nước nóng.\n Thông thường mọi người sẽ uống nước, sau đó thêm espresso lên trên, \n vì nó giữ được lớp crema, là lớp bọt màu nâu đỏ, nhưng cũng có thể làm ngược lại.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Trung Nguyen Legend is a Vietnamese business group engaged in coffee production, processing, and distribution. It is known as the largest domestic coffee brand in Vietnam, exporting products to over 60 countries, including major markets such as G7 countries, the United States,\n the European Union, the United Kingdom, Germany, China, Canada, Russia, Japan, Dubai, and ASEAN. When talking about quality Vietnamese coffee,\n this brand with its aromatic and robust coffee cannot be overlooked");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "In the UK, coffee preferences are varied but a\n few stand out as particularly popular. While many enjoy flat whites\n, cappuccinos, and lattes, the most popular coffee drink in the UK is the flat white");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "Indian Mysore coffee is a market name for high-quality wet processed (washed)\n coffees from the southern region in the state of Karnataka. The coffee is known for its subtle,\n rich flavor complemented by a medium to full body and moderate though distinct acidity.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "Raf coffee (Russian: раф-кофе) is a popular coffee drink in some countries of the former USSR,\n which appeared in the late 1990s in Russia. Prepared by adding cream and vanilla sugar to a single shot of espresso and\n then foaming the mix with a steam heater.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Detail",
                value: "This refers to regular black coffee. It is usually served in small portions as an espresso or French press coffee.\n The French enjoy café noir with meals or as a pick-me-up in the afternoon.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Name product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Vietnamese product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "UK product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "India product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "Russian product");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Detail",
                value: "France product");
        }
    }
}

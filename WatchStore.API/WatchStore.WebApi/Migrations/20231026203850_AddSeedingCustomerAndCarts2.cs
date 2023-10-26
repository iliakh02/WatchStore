using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchStore.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingCustomerAndCarts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carts",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CartId", "DeliveryAddress", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 1, 1, "Test delivery address #112233", "User", "", "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

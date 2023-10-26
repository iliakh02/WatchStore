using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchStore.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUrl", "Name", "Price", "Rating", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Elegant silver watch with a leather strap.", "https://idom.kiev.ua/image/Watch/Watch-Ultra/Apple-Watch-Series-Ultra-ocean-midnight-photo.jpg", "Classic Silver Watch", 99.99m, 4.0m, 500 },
                    { 2, "Water-resistant chronograph watch for sports enthusiasts.", "https://m.media-amazon.com/images/I/71VjM5LOeYL._AC_UY780_.jpg", "Sporty Chronograph Watch", 129.99m, 4.8m, 20 },
                    { 3, "Trendy rose gold watch with a minimalist design.", "https://www.linjer.co/cdn/shop/products/linjer-classic-watch-38-gunmetal-tan-1-front_grande.jpg?v=1602577160", "Rose Gold Fashion Watch", 79.99m, 3.4m, 400 },
                    { 4, "Smartwatch with fitness tracking and notifications.", "https://images.samsung.com/is/image/samsung/p6pim/ua/2307/gallery/ua-galaxy-watch6-r935-sm-r930nzeasek-537479860?$650_519_PNG$", "Digital Smartwatch", 149.99m, 4.6m, 40 },
                    { 5, "Exquisite gold watch with diamond-studded dial.", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/ML733_VW_34FR+watch-case-41-stainless-gold-s9_VW_34FR+watch-face-41-stainless-gold-s9_VW_34FR?wid=2000&hei=2000&fmt=png-alpha&.v=1694507905569", "Luxury Gold Watch", 299.99m, 4.9m, 15 },
                    { 6, "Classic leather watch for a timeless style.", "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/U/O/92910_1666897463.jpg", "Vintage Leather Watch", 89.99m, 4.2m, 200 },
                    { 7, "Durable sports watch for diving enthusiasts.", "https://fossil.scene7.com/is/image/FossilPartners/FS5384_main?$sfcc_fos_medium$", "Diving Sports Watch", 159.99m, 4.5m, 30 },
                    { 8, "Stainless steel watch with a modern design.", "https://m.media-amazon.com/images/I/81nC4u9eYfL._AC_UY1000_.jpg", "Sleek Stainless Steel Watch", 109.99m, 4.3m, 150 },
                    { 9, "Bracelet with built-in fitness tracking features.", "https://img.piaget.com/new-product-banner-normal-2/2cbb5d5c3aa87deb32fa85058422982dfec2bfb2.jpg", "Fitness Tracker Bracelet", 49.99m, 4.1m, 100 },
                    { 10, "Watch with a unique wooden dial for nature lovers.", "https://www.raymond-weil.us/wp-content/uploads/2023/04/RW_toccata_5385-pc5-00859_rvb_700x860px_72dpi-1.png", "Wooden Dial Watch", 69.99m, 4.7m, 80 },
                    { 11, "Smartwatch with advanced fitness tracking capabilities.", "https://www.vaerwatches.com/cdn/shop/files/GMT-Home-Collection.jpg?v=1678902341&width=1000", "Smart Fitness Watch", 179.99m, 4.6m, 25 },
                    { 12, "Casual watch with a comfortable canvas strap.", "https://www.vaerwatches.com/cdn/shop/files/G5-Batman-QR-WFL-BLK.jpg?v=1684430729&width=1200", "Casual Canvas Strap Watch", 59.99m, 4.0m, 120 },
                    { 13, "Luxurious watch with diamond encrusted details.", "https://www.anguscoote.com.au/content/products/citizen-mens-quartz-watch-5065022-141566.jpg?width=1200&height=630&fit=bounds", "Diamond Encrusted Watch", 499.99m, 4.9m, 10 },
                    { 14, "Durable watch designed for outdoor activities.", "https://www.prouds.com.au/content/products/g-shock-watch-by-casio-5149229-140528.jpg?canvas=1:1&auto=webp&optimize=high&width=375", "Rugged Outdoor Watch", 129.99m, 4.4m, 35 },
                    { 15, "Elegantly designed watch with a ceramic strap.", "https://i02.appmifile.com/619_operator_in/13/05/2021/f1781d7f24bd880a489a6a72088a261c!800x800!85.png", "Elegant Ceramic Watch", 199.99m, 4.8m, 18 },
                    { 16, "Classic pocket watch with a vintage charm.", "https://www.watchportal.com.ph/cdn/shop/products/1_d9fb14cf-cf36-4ee4-a513-7ecded3a1c4c.jpg?v=1600303384", "Pocket Watch", 79.99m, 4.3m, 60 },
                    { 17, "Watch with a minimalist design for a clean look.", "https://timex.eu/cdn/shop/products/TW2V42700.png?v=1687315799&width=990", "Minimalist Design Watch", 69.99m, 4.2m, 90 },
                    { 18, "Pilot watch with aviation-inspired features.", "https://www.watches.com/cdn/shop/products/Timex-TW2V70100_1800x1800.jpg?v=1678413063", "Aviator Pilot Watch", 139.99m, 4.5m, 25 },
                    { 19, "Ring with smart features like notifications and health tracking.", "https://staticimg.titan.co.in/Sonata/Catalog/7140WL02_1.jpg?pView=listing", "Smart Ring", 89.99m, 4.1m, 70 },
                    { 20, "Fitness band with a digital display for activity tracking.", "https://images-static.nykaa.com/media/catalog/product/8/7/875c3d17140NL05_1.jpg?tr=w-500,pr-true", "Digital Fitness Band", 39.99m, 4.0m, 150 },
                    { 21, "Antique pocket watch with a brass finish.", "https://www.chanel.com/images//t_one////q_auto:good,f_auto,fl_lossy,dpr_1.2/w_1920/j12-interstellar-watch-38-mm-black-black-ceramic-steel-diamond-packshot-default-h7989-9528001626142.jpg", "Antique Brass Pocket Watch", 119.99m, 4.6m, 30 },
                    { 22, "Environmentally friendly watch powered by solar energy.", "https://www.hublot.com/sites/default/files/styles/homepage_hero_image_mobile/public/2023-03/MP-13-Tourbillon-Bi-Axis-Retrograde-44-mm-homepage.png?itok=EU0Daw2P", "Solar-Powered Watch", 149.99m, 4.7m, 22 },
                    { 23, "Watch with a stylish mesh strap for a modern look.", "https://www.boat-lifestyle.com/cdn/shop/products/a09a67f0-75bd-42b8-8f0d-58ffad51e03b_600x.png?v=1625045372", "Stylish Mesh Strap Watch", 109.99m, 4.2m, 50 },
                    { 24, "Sports watch with digital display and multiple functions.", "https://cdn.opstatics.com/store/20170907/assets/images/events/2021/03/watches/en/common/1920/kv/kv-2.png", "Digital Sports Watch", 79.99m, 4.3m, 65 },
                    { 25, "Watch with a scratch-resistant sapphire crystal.", "https://m.media-amazon.com/images/I/718ndu+NQnL._AC_SL1500_.jpg", "Sapphire Crystal Watch", 199.99m, 4.8m, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_OrderId",
                table: "CartItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC_Cake.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bakeries",
                columns: table => new
                {
                    BakeryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakeryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakeries", x => x.BakeryId);
                });

            migrationBuilder.CreateTable(
                name: "Cupcakes",
                columns: table => new
                {
                    CupcakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CupcakeType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlutenFree = table.Column<bool>(type: "bit", nullable: false),
                    CaloricValue = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageMimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BakeryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cupcakes", x => x.CupcakeId);
                    table.ForeignKey(
                        name: "FK_Cupcakes_Bakeries_BakeryId",
                        column: x => x.BakeryId,
                        principalTable: "Bakeries",
                        principalColumn: "BakeryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bakeries",
                columns: new[] { "BakeryId", "Address", "BakeryName", "Quantity" },
                values: new object[,]
                {
                    { 1, "Nowa Hata 32-445 ul. Błotna 34", "Ekstra wypieki", 8 },
                    { 2, "Toruń 62-666 ul. Mogilska 34", "Babunia ciastka", 4 },
                    { 3, "Warszawa 45-444 ul. Błotna 34", "Ciastka na wynos", 3 },
                    { 4, "Kraków 31-555 ul. Długa 34", "Dumiecki LTD", 6 }
                });

            migrationBuilder.InsertData(
                table: "Cupcakes",
                columns: new[] { "CupcakeId", "BakeryId", "CaloricValue", "CupcakeType", "Description", "GlutenFree", "ImageMimeType", "ImageName", "PhotoFile", "Price" },
                values: new object[,]
                {
                    { 1, 1, 260, 0, "Waniliowe pyszne ...", true, "image/jpeg", "birthday-cupcake.jpg", null, 2.5m },
                    { 2, 2, 195, 2, "Chocolate cupcake with caramel filling and chocolate butter cream", false, "image/jpeg", "chocolate-cupcake.jpg", null, 3.2m },
                    { 3, 3, 295, 3, "Chocolate cupcake with straberry cream filling", false, "image/jpeg", "pink-cupcake.jpg", null, 4m },
                    { 4, 4, 360, 1, "Vanilla cupcake with butter cream", true, "image/jpeg", "turquoise-cupcake.jpg", null, 1.5m },
                    { 5, 4, 250, 1, "Przepyszne ciastko", true, "image/jpeg", "cupcakes-cover.jpg", null, 4.5m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cupcakes_BakeryId",
                table: "Cupcakes",
                column: "BakeryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cupcakes");

            migrationBuilder.DropTable(
                name: "Bakeries");
        }
    }
}

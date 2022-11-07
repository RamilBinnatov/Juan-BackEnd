using Microsoft.EntityFrameworkCore.Migrations;

namespace Juan.Migrations
{
    public partial class CreateProductSizeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductSizeId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Size = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSizeId",
                table: "Products",
                column: "ProductSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSizes_ProductSizeId",
                table: "Products",
                column: "ProductSizeId",
                principalTable: "ProductSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSizes_ProductSizeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductSizeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductSizeId",
                table: "Products");
        }
    }
}

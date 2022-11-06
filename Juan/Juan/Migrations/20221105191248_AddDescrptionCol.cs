using Microsoft.EntityFrameworkCore.Migrations;

namespace Juan.Migrations
{
    public partial class AddDescrptionCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderDetails_sliderDetailId",
                table: "Sliders");

            migrationBuilder.DropTable(
                name: "SliderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_sliderDetailId",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "sliderDetailId",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Header",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.AddColumn<int>(
                name: "sliderDetailId",
                table: "Sliders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SliderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SignImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_sliderDetailId",
                table: "Sliders",
                column: "sliderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sliders_SliderDetails_sliderDetailId",
                table: "Sliders",
                column: "sliderDetailId",
                principalTable: "SliderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

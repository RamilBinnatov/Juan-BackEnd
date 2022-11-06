using Microsoft.EntityFrameworkCore.Migrations;

namespace Juan.Migrations
{
    public partial class UpdateSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sliderDetailId",
                table: "Sliders",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sliders_SliderDetails_sliderDetailId",
                table: "Sliders");

            migrationBuilder.DropIndex(
                name: "IX_Sliders_sliderDetailId",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "sliderDetailId",
                table: "Sliders");
        }
    }
}

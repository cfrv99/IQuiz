using Microsoft.EntityFrameworkCore.Migrations;

namespace EyeQuiz.Managment.Migrations
{
    public partial class init_point : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "Questions");
        }
    }
}

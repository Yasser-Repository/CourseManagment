using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursesManagment.DAL.Migrations
{
    public partial class AddingFilePathColumnToCourseLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filePath",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filePath",
                table: "CourseLessons");
        }
    }
}

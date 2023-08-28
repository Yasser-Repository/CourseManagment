using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursesManagment.DAL.Migrations
{
    public partial class updateinColTypeOfOrderNumberInCourseLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "orderNumber",
                table: "CourseLessons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "orderNumber",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}

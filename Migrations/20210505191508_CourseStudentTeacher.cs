using Microsoft.EntityFrameworkCore.Migrations;

namespace FakultetMVC.Migrations
{
    public partial class CourseStudentTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_TeacherId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Teacher_TeacherId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_TeacherId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Course_TeacherId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "FirstTeacherId",
                table: "Course",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SecondTeacherId",
                table: "Course",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Course_SecondTeacherId",
                table: "Course",
                column: "SecondTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_SecondTeacherId",
                table: "Course",
                column: "SecondTeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_SecondTeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_SecondTeacherId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "SecondTeacherId",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Enrollment",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstTeacherId",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_TeacherId",
                table: "Enrollment",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                table: "Course",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_TeacherId",
                table: "Course",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Teacher_TeacherId",
                table: "Enrollment",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

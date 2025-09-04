using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Task_1.Migrations
{
    /// <inheritdoc />
    public partial class Annotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Stud_Courses");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Course_Insts");

            migrationBuilder.RenameTable(
                name: "Stud_Courses",
                newName: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Course_Insts",
                newName: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "inst_ID",
                table: "Departments",
                newName: "Inst_ID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "Dept_Name");

            migrationBuilder.RenameColumn(
                name: "HiringDate",
                table: "Departments",
                newName: "Hiring_Date");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Departments",
                newName: "Dept_ID");

            migrationBuilder.RenameColumn(
                name: "evaluate",
                table: "Course_Inst",
                newName: "Evaluate");

            migrationBuilder.AlterColumn<int>(
                name: "Stud_ID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Course_ID",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                column: "Stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                column: "Course_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "Stud_Courses");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                newName: "Course_Insts");

            migrationBuilder.RenameColumn(
                name: "Inst_ID",
                table: "Departments",
                newName: "inst_ID");

            migrationBuilder.RenameColumn(
                name: "Hiring_Date",
                table: "Departments",
                newName: "HiringDate");

            migrationBuilder.RenameColumn(
                name: "Dept_Name",
                table: "Departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Departments",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Evaluate",
                table: "Course_Insts",
                newName: "evaluate");

            migrationBuilder.AlterColumn<int>(
                name: "Stud_ID",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Course_ID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts",
                column: "ID");
        }
    }
}

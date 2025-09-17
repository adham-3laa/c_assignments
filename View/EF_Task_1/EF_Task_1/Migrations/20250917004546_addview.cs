using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Task_1.Migrations
{
    /// <inheritdoc />
    public partial class addview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
cREATE OR ALTER VIEW StudentsAdnTheCorsesTheyTake AS
SELECT 
    s.FName + ' ' + s.LName AS StudentName,
    c.CourseName AS CourseName
FROM
    Students s
JOIN
    Stud_Courses sc ON s.ID = sc.StudentID
JOIN
    Courses c ON sc.CourseID = c.ID
");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS StudentsAdnTheCorsesTheyTake");

        }
    }
}

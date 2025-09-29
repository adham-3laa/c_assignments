using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Sec_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Department1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 9, 26, 23, 20, 53, 277, DateTimeKind.Local).AddTicks(5255));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 9, 26, 23, 20, 53, 277, DateTimeKind.Local).AddTicks(5255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}

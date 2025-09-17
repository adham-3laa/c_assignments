using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Task_1.Migrations
{
    /// <inheritdoc />
    public partial class view : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_inst_ID",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_inst_ID",
                table: "Departments",
                column: "inst_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_inst_ID",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_inst_ID",
                table: "Departments",
                column: "inst_ID",
                unique: true);
        }
    }
}

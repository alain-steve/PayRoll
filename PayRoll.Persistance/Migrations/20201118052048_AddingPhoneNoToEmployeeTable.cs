using Microsoft.EntityFrameworkCore.Migrations;

namespace PayRoll.Persistance.Migrations
{
    public partial class AddingPhoneNoToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Employees");
        }
    }
}

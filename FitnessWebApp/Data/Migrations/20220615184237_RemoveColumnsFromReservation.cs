using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessWebApp.Data.Migrations
{
    public partial class RemoveColumnsFromReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Reservations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

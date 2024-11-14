using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_roomimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "roomImage",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "roomImage",
                table: "Rooms");
        }
    }
}

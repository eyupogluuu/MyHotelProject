using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adultCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    childCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roomCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.bookingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}

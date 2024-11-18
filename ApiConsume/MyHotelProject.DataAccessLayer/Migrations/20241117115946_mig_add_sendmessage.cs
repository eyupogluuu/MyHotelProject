using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_sendmessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendMessages",
                columns: table => new
                {
                    sendMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    receiverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    receiverMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senderMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMessages", x => x.sendMessageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendMessages");
        }
    }
}

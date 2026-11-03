using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SwgohParticipation.Data;

#nullable disable

namespace SwgohParticipation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261103003758_AllowBlankTicketValues")]
    public partial class AllowBlankTicketValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AllyCode",
                table: "TicketParticipations",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<int>(
                name: "LifetimeTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "UPDATE TicketParticipations SET AllyCode = '' WHERE AllyCode IS NULL;");
            migrationBuilder.Sql(
                "UPDATE TicketParticipations SET LifetimeTickets = 0 WHERE LifetimeTickets IS NULL;");

            migrationBuilder.AlterColumn<string>(
                name: "AllyCode",
                table: "TicketParticipations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LifetimeTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}

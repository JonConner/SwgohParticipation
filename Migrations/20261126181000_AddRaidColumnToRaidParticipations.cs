using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SwgohParticipation.Data;

#nullable disable

namespace SwgohParticipation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261126181000_AddRaidColumnToRaidParticipations")]
    public partial class AddRaidColumnToRaidParticipations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "raid",
                table: "RaidParticipations",
                type: "varchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "order66");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "raid",
                table: "RaidParticipations");
        }
    }
}

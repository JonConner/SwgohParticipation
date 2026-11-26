using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using SwgohParticipation.Data;

#nullable disable

namespace SwgohParticipation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261126180000_RenameOrder66ParticipationsToRaidParticipations")]
    public partial class RenameOrder66ParticipationsToRaidParticipations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Order66Participations",
                newName: "RaidParticipations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "RaidParticipations",
                newName: "Order66Participations");
        }
    }
}

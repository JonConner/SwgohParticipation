using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwgohParticipation.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order66Participations",
                columns: table => new
                {
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiffPercent = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order66Participations", x => new { x.StartDate, x.Name });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoteParticipations",
                columns: table => new
                {
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalTerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    PlatoonUnits = table.Column<int>(type: "int", nullable: false),
                    CombatWaves = table.Column<int>(type: "int", nullable: false),
                    RogueActions = table.Column<int>(type: "int", nullable: false),
                    P1Deployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    P1TerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    P1DeployedGp = table.Column<int>(type: "int", nullable: false),
                    P1CombatAttempts = table.Column<int>(type: "int", nullable: false),
                    P1SpecialAttempts = table.Column<int>(type: "int", nullable: false),
                    P1Waves = table.Column<int>(type: "int", nullable: false),
                    P2Deployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    P2TerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    P2DeployedGp = table.Column<int>(type: "int", nullable: false),
                    P2CombatAttempts = table.Column<int>(type: "int", nullable: false),
                    P2SpecialAttempts = table.Column<int>(type: "int", nullable: false),
                    P2Waves = table.Column<int>(type: "int", nullable: false),
                    P3Deployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    P3TerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    P3DeployedGp = table.Column<int>(type: "int", nullable: false),
                    P3CombatAttempts = table.Column<int>(type: "int", nullable: false),
                    P3SpecialAttempts = table.Column<int>(type: "int", nullable: false),
                    P3Waves = table.Column<int>(type: "int", nullable: false),
                    P4Deployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    P4TerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    P4DeployedGp = table.Column<int>(type: "int", nullable: false),
                    P4CombatAttempts = table.Column<int>(type: "int", nullable: false),
                    P4SpecialAttempts = table.Column<int>(type: "int", nullable: false),
                    P4Waves = table.Column<int>(type: "int", nullable: false),
                    P5Deployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    P5TerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    P5DeployedGp = table.Column<int>(type: "int", nullable: false),
                    P5CombatAttempts = table.Column<int>(type: "int", nullable: false),
                    P5SpecialAttempts = table.Column<int>(type: "int", nullable: false),
                    P5Waves = table.Column<int>(type: "int", nullable: false),
                    P6Deployed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    P6TerritoryPoints = table.Column<int>(type: "int", nullable: false),
                    P6DeployedGp = table.Column<int>(type: "int", nullable: false),
                    P6CombatAttempts = table.Column<int>(type: "int", nullable: false),
                    P6SpecialAttempts = table.Column<int>(type: "int", nullable: false),
                    P6Waves = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoteParticipations", x => new { x.StartDate, x.Name });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TicketParticipations",
                columns: table => new
                {
                    WeekEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DailyAverage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketParticipations", x => new { x.WeekEndDate, x.Name });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TwParticipations",
                columns: table => new
                {
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TwParticipations", x => new { x.StartDate, x.Name });
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order66Participations");

            migrationBuilder.DropTable(
                name: "RoteParticipations");

            migrationBuilder.DropTable(
                name: "TicketParticipations");

            migrationBuilder.DropTable(
                name: "TwParticipations");
        }
    }
}

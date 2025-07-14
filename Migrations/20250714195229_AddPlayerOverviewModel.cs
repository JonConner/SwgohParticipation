using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwgohParticipation.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerOverviewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerOverviews",
                columns: table => new
                {
                    ReportDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AllyCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscordTag = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiscordId = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                    CharacterGP = table.Column<int>(type: "int", nullable: false),
                    ShipGP = table.Column<int>(type: "int", nullable: false),
                    LeagueId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillRating = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ModScore = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    GearScore = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Star7Count = table.Column<int>(type: "int", nullable: false),
                    G11Count = table.Column<int>(type: "int", nullable: false),
                    G12Count = table.Column<int>(type: "int", nullable: false),
                    G13Count = table.Column<int>(type: "int", nullable: false),
                    ZetaCount = table.Column<int>(type: "int", nullable: false),
                    OmiCount = table.Column<int>(type: "int", nullable: false),
                    TWOmiCount = table.Column<int>(type: "int", nullable: false),
                    GACOmiCount = table.Column<int>(type: "int", nullable: false),
                    TBOmiCount = table.Column<int>(type: "int", nullable: false),
                    CQOmiCount = table.Column<int>(type: "int", nullable: false),
                    Relic1Count = table.Column<int>(type: "int", nullable: false),
                    Relic2Count = table.Column<int>(type: "int", nullable: false),
                    Relic3Count = table.Column<int>(type: "int", nullable: false),
                    Relic4Count = table.Column<int>(type: "int", nullable: false),
                    Relic5Count = table.Column<int>(type: "int", nullable: false),
                    Relic6Count = table.Column<int>(type: "int", nullable: false),
                    Relic7Count = table.Column<int>(type: "int", nullable: false),
                    Relic8Count = table.Column<int>(type: "int", nullable: false),
                    Relic9Count = table.Column<int>(type: "int", nullable: false),
                    Mod6Dot = table.Column<int>(type: "int", nullable: false),
                    Speed10 = table.Column<int>(type: "int", nullable: false),
                    Speed15 = table.Column<int>(type: "int", nullable: false),
                    Speed20 = table.Column<int>(type: "int", nullable: false),
                    Speed25 = table.Column<int>(type: "int", nullable: false),
                    UltimateGLCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerOverviews", x => new { x.ReportDate, x.Name });
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerOverviews");
        }
    }
}

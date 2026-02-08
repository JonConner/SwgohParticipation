using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwgohParticipation.Migrations
{
    /// <inheritdoc />
    public partial class LoaSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DailyAverage",
                table: "TicketParticipations",
                newName: "WednesdayTickets");

            migrationBuilder.AddColumn<int>(
                name: "AttackBanners",
                table: "TwParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefenseBanners",
                table: "TwParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimumBanners",
                table: "TwParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalBanners",
                table: "TwParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AllyCode",
                table: "TicketParticipations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "AverageTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FridayTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LifetimeTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MondayTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaturdayTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SundayTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThursdayTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TuesdayTickets",
                table: "TicketParticipations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsP1Excused",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsP2Excused",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsP3Excused",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsP4Excused",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsP5Excused",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsP6Excused",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsZeffoMissionCompleted",
                table: "RoteParticipations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AllyCode",
                table: "Order66Participations",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Difference",
                table: "Order66Participations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstimatedScore",
                table: "Order66Participations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcused",
                table: "Order66Participations",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LastActualScore",
                table: "Order66Participations",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttackBanners",
                table: "TwParticipations");

            migrationBuilder.DropColumn(
                name: "DefenseBanners",
                table: "TwParticipations");

            migrationBuilder.DropColumn(
                name: "MinimumBanners",
                table: "TwParticipations");

            migrationBuilder.DropColumn(
                name: "TotalBanners",
                table: "TwParticipations");

            migrationBuilder.DropColumn(
                name: "AllyCode",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "AverageTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "CurrentTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "FridayTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "LifetimeTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "MondayTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "SaturdayTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "SundayTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "ThursdayTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "TuesdayTickets",
                table: "TicketParticipations");

            migrationBuilder.DropColumn(
                name: "IsP1Excused",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "IsP2Excused",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "IsP3Excused",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "IsP4Excused",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "IsP5Excused",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "IsP6Excused",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "IsZeffoMissionCompleted",
                table: "RoteParticipations");

            migrationBuilder.DropColumn(
                name: "AllyCode",
                table: "Order66Participations");

            migrationBuilder.DropColumn(
                name: "Difference",
                table: "Order66Participations");

            migrationBuilder.DropColumn(
                name: "EstimatedScore",
                table: "Order66Participations");

            migrationBuilder.DropColumn(
                name: "IsExcused",
                table: "Order66Participations");

            migrationBuilder.DropColumn(
                name: "LastActualScore",
                table: "Order66Participations");

            migrationBuilder.RenameColumn(
                name: "WednesdayTickets",
                table: "TicketParticipations",
                newName: "DailyAverage");
        }
    }
}

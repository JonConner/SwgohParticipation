using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwgohParticipation.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBitColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "P6Deployed",
                table: "RoteParticipations",
                newName: "IsP6Deployed");

            migrationBuilder.RenameColumn(
                name: "P5Deployed",
                table: "RoteParticipations",
                newName: "IsP5Deployed");

            migrationBuilder.RenameColumn(
                name: "P4Deployed",
                table: "RoteParticipations",
                newName: "IsP4Deployed");

            migrationBuilder.RenameColumn(
                name: "P3Deployed",
                table: "RoteParticipations",
                newName: "IsP3Deployed");

            migrationBuilder.RenameColumn(
                name: "P2Deployed",
                table: "RoteParticipations",
                newName: "IsP2Deployed");

            migrationBuilder.RenameColumn(
                name: "P1Deployed",
                table: "RoteParticipations",
                newName: "IsP1Deployed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsP6Deployed",
                table: "RoteParticipations",
                newName: "P6Deployed");

            migrationBuilder.RenameColumn(
                name: "IsP5Deployed",
                table: "RoteParticipations",
                newName: "P5Deployed");

            migrationBuilder.RenameColumn(
                name: "IsP4Deployed",
                table: "RoteParticipations",
                newName: "P4Deployed");

            migrationBuilder.RenameColumn(
                name: "IsP3Deployed",
                table: "RoteParticipations",
                newName: "P3Deployed");

            migrationBuilder.RenameColumn(
                name: "IsP2Deployed",
                table: "RoteParticipations",
                newName: "P2Deployed");

            migrationBuilder.RenameColumn(
                name: "IsP1Deployed",
                table: "RoteParticipations",
                newName: "P1Deployed");
        }
    }
}

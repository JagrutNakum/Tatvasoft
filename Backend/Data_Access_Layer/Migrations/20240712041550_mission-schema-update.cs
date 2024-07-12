using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class missionschemaupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissionAvilability",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "MissionDocuments",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "MissionOrganisationDetail",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "MissionOrganisationName",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "MissionThemeId",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "MissionVideoUrl",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "RegistrationDeadLine",
                table: "Missions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MissionAvilability",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionDocuments",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionOrganisationDetail",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionOrganisationName",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionThemeId",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionVideoUrl",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDeadLine",
                table: "Missions",
                type: "date",
                nullable: true);
        }
    }
}

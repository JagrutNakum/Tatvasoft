using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class missonapplicationupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissionType",
                table: "Missions");

            migrationBuilder.AddColumn<string>(
                name: "MissionTitle",
                table: "MissionApplication",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserImage",
                table: "MissionApplication",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MissionApplication",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissionTitle",
                table: "MissionApplication");

            migrationBuilder.DropColumn(
                name: "UserImage",
                table: "MissionApplication");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MissionApplication");

            migrationBuilder.AddColumn<string>(
                name: "MissionType",
                table: "Missions",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}

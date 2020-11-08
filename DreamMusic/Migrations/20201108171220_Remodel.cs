using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamMusic.Migrations
{
    public partial class Remodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beats",
                table: "DrumSheet");

            migrationBuilder.AddColumn<string>(
                name: "Crash",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloorTom",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HiHatClose",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HiHatOpen",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HighTom",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kick",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MidTom",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ride",
                table: "DrumSheet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Snare",
                table: "DrumSheet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Crash",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "FloorTom",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "HiHatClose",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "HiHatOpen",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "HighTom",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "Kick",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "MidTom",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "Ride",
                table: "DrumSheet");

            migrationBuilder.DropColumn(
                name: "Snare",
                table: "DrumSheet");

            migrationBuilder.AddColumn<string>(
                name: "Beats",
                table: "DrumSheet",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}

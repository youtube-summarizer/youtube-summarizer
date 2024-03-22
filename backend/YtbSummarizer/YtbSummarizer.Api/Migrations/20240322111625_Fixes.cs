using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YtbSummarizer.Api.Migrations
{
    /// <inheritdoc />
    public partial class Fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Processed1D",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Processed1H",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Processed1W",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Processed4H",
                table: "Videos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Processed1D",
                table: "Videos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Processed1H",
                table: "Videos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Processed1W",
                table: "Videos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Processed4H",
                table: "Videos",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ace.Geograpi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MapBoundaries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleId",
                schema: "public",
                table: "continents",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryN",
                schema: "public",
                table: "continents",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryS",
                schema: "public",
                table: "continents",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryE",
                schema: "public",
                table: "continents",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryW",
                schema: "public",
                table: "continents",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CenterLat",
                schema: "public",
                table: "continents",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CenterLng",
                schema: "public",
                table: "continents",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "GoogleId",
                schema: "public",
                table: "countries",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryN",
                schema: "public",
                table: "countries",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryS",
                schema: "public",
                table: "countries",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryE",
                schema: "public",
                table: "countries",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BoundaryW",
                schema: "public",
                table: "countries",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CenterLat",
                schema: "public",
                table: "countries",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CenterLng",
                schema: "public",
                table: "countries",
                type: "numeric(11,8)",
                precision: 11,
                scale: 8,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleId",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "BoundaryN",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "BoundaryS",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "BoundaryE",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "BoundaryW",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "CenterLat",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "CenterLng",
                schema: "public",
                table: "continents");

            migrationBuilder.DropColumn(
                name: "GoogleId",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "BoundaryN",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "BoundaryS",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "BoundaryE",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "BoundaryW",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "CenterLat",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "CenterLng",
                schema: "public",
                table: "countries");
        }
    }
}

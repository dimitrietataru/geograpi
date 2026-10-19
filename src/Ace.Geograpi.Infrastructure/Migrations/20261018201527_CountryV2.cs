using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ace.Geograpi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CountryV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Area",
                schema: "public",
                table: "countries",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                schema: "public",
                table: "countries",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodeA3",
                schema: "public",
                table: "countries",
                type: "character varying(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameOfficial",
                schema: "public",
                table: "countries",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Population",
                schema: "public",
                table: "countries",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "Code",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "CodeA3",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "NameOfficial",
                schema: "public",
                table: "countries");

            migrationBuilder.DropColumn(
                name: "Population",
                schema: "public",
                table: "countries");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ace.Geograpi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "continents",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContinentId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_countries_continents_ContinentId",
                        column: x => x.ContinentId,
                        principalSchema: "public",
                        principalTable: "continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "continents",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, 0, null, 0, "Africa", null, 0 },
                    { 2, null, 0, null, 0, "Antarctica", null, 0 },
                    { 3, null, 0, null, 0, "Asia", null, 0 },
                    { 4, null, 0, null, 0, "Australia (Oceania)", null, 0 },
                    { 5, null, 0, null, 0, "Europe", null, 0 },
                    { 6, null, 0, null, 0, "North America", null, 0 },
                    { 7, null, 0, null, 0, "South America", null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "countries",
                columns: new[] { "Id", "ContinentId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 3, null, 0, null, 0, "Afghanistan", null, 0 },
                    { 2, 5, null, 0, null, 0, "Albania", null, 0 },
                    { 3, 1, null, 0, null, 0, "Algeria", null, 0 },
                    { 4, 5, null, 0, null, 0, "Andorra", null, 0 },
                    { 5, 1, null, 0, null, 0, "Angola", null, 0 },
                    { 6, 6, null, 0, null, 0, "Antigua and Barbuda", null, 0 },
                    { 7, 7, null, 0, null, 0, "Argentina", null, 0 },
                    { 8, 3, null, 0, null, 0, "Armenia", null, 0 },
                    { 9, 4, null, 0, null, 0, "Australia", null, 0 },
                    { 10, 5, null, 0, null, 0, "Austria", null, 0 },
                    { 11, 3, null, 0, null, 0, "Azerbaijan", null, 0 },
                    { 12, 6, null, 0, null, 0, "Bahamas", null, 0 },
                    { 13, 3, null, 0, null, 0, "Bahrain", null, 0 },
                    { 14, 3, null, 0, null, 0, "Bangladesh", null, 0 },
                    { 15, 6, null, 0, null, 0, "Barbados", null, 0 },
                    { 16, 5, null, 0, null, 0, "Belarus", null, 0 },
                    { 17, 5, null, 0, null, 0, "Belgium", null, 0 },
                    { 18, 6, null, 0, null, 0, "Belize", null, 0 },
                    { 19, 1, null, 0, null, 0, "Benin", null, 0 },
                    { 20, 3, null, 0, null, 0, "Bhutan", null, 0 },
                    { 21, 7, null, 0, null, 0, "Bolivia", null, 0 },
                    { 22, 5, null, 0, null, 0, "Bosnia and Herzegovina", null, 0 },
                    { 23, 1, null, 0, null, 0, "Botswana", null, 0 },
                    { 24, 7, null, 0, null, 0, "Brazil", null, 0 },
                    { 25, 3, null, 0, null, 0, "Brunei", null, 0 },
                    { 26, 5, null, 0, null, 0, "Bulgaria", null, 0 },
                    { 27, 1, null, 0, null, 0, "Burkina Faso", null, 0 },
                    { 28, 1, null, 0, null, 0, "Burundi", null, 0 },
                    { 29, 1, null, 0, null, 0, "Cabo Verde", null, 0 },
                    { 30, 3, null, 0, null, 0, "Cambodia", null, 0 },
                    { 31, 1, null, 0, null, 0, "Cameroon", null, 0 },
                    { 32, 6, null, 0, null, 0, "Canada", null, 0 },
                    { 33, 1, null, 0, null, 0, "Central African Republic", null, 0 },
                    { 34, 1, null, 0, null, 0, "Chad", null, 0 },
                    { 35, 7, null, 0, null, 0, "Chile", null, 0 },
                    { 36, 3, null, 0, null, 0, "China", null, 0 },
                    { 37, 7, null, 0, null, 0, "Colombia", null, 0 },
                    { 38, 1, null, 0, null, 0, "Comoros", null, 0 },
                    { 39, 1, null, 0, null, 0, "Congo, Democratic Republic of the", null, 0 },
                    { 40, 1, null, 0, null, 0, "Congo, Republic of the", null, 0 },
                    { 41, 6, null, 0, null, 0, "Costa Rica", null, 0 },
                    { 42, 1, null, 0, null, 0, "Cote d'Ivoire", null, 0 },
                    { 43, 5, null, 0, null, 0, "Croatia", null, 0 },
                    { 44, 6, null, 0, null, 0, "Cuba", null, 0 },
                    { 45, 3, null, 0, null, 0, "Cyprus", null, 0 },
                    { 46, 5, null, 0, null, 0, "Czech Republic", null, 0 },
                    { 47, 5, null, 0, null, 0, "Denmark", null, 0 },
                    { 48, 1, null, 0, null, 0, "Djibouti", null, 0 },
                    { 49, 6, null, 0, null, 0, "Dominica", null, 0 },
                    { 50, 6, null, 0, null, 0, "Dominican Republic", null, 0 },
                    { 51, 3, null, 0, null, 0, "East Timor (Timor-Leste)", null, 0 },
                    { 52, 7, null, 0, null, 0, "Ecuador", null, 0 },
                    { 53, 1, null, 0, null, 0, "Egypt", null, 0 },
                    { 54, 6, null, 0, null, 0, "El Salvador", null, 0 },
                    { 55, 1, null, 0, null, 0, "Equatorial Guinea", null, 0 },
                    { 56, 1, null, 0, null, 0, "Eritrea", null, 0 },
                    { 57, 5, null, 0, null, 0, "Estonia", null, 0 },
                    { 58, 1, null, 0, null, 0, "Eswatini", null, 0 },
                    { 59, 1, null, 0, null, 0, "Ethiopia", null, 0 },
                    { 60, 4, null, 0, null, 0, "Fiji", null, 0 },
                    { 61, 5, null, 0, null, 0, "Finland", null, 0 },
                    { 62, 5, null, 0, null, 0, "France", null, 0 },
                    { 63, 1, null, 0, null, 0, "Gabon", null, 0 },
                    { 64, 1, null, 0, null, 0, "Gambia", null, 0 },
                    { 65, 3, null, 0, null, 0, "Georgia", null, 0 },
                    { 66, 5, null, 0, null, 0, "Germany", null, 0 },
                    { 67, 1, null, 0, null, 0, "Ghana", null, 0 },
                    { 68, 5, null, 0, null, 0, "Greece", null, 0 },
                    { 69, 6, null, 0, null, 0, "Grenada", null, 0 },
                    { 70, 6, null, 0, null, 0, "Guatemala", null, 0 },
                    { 71, 1, null, 0, null, 0, "Guinea", null, 0 },
                    { 72, 1, null, 0, null, 0, "Guinea-Bissau", null, 0 },
                    { 73, 7, null, 0, null, 0, "Guyana", null, 0 },
                    { 74, 6, null, 0, null, 0, "Haiti", null, 0 },
                    { 75, 6, null, 0, null, 0, "Honduras", null, 0 },
                    { 76, 5, null, 0, null, 0, "Hungary", null, 0 },
                    { 77, 5, null, 0, null, 0, "Iceland", null, 0 },
                    { 78, 3, null, 0, null, 0, "India", null, 0 },
                    { 79, 3, null, 0, null, 0, "Indonesia", null, 0 },
                    { 80, 3, null, 0, null, 0, "Iran", null, 0 },
                    { 81, 3, null, 0, null, 0, "Iraq", null, 0 },
                    { 82, 5, null, 0, null, 0, "Ireland", null, 0 },
                    { 83, 3, null, 0, null, 0, "Israel", null, 0 },
                    { 84, 5, null, 0, null, 0, "Italy", null, 0 },
                    { 85, 6, null, 0, null, 0, "Jamaica", null, 0 },
                    { 86, 3, null, 0, null, 0, "Japan", null, 0 },
                    { 87, 3, null, 0, null, 0, "Jordan", null, 0 },
                    { 88, 3, null, 0, null, 0, "Kazakhstan", null, 0 },
                    { 89, 1, null, 0, null, 0, "Kenya", null, 0 },
                    { 90, 4, null, 0, null, 0, "Kiribati", null, 0 },
                    { 91, 3, null, 0, null, 0, "Korea, North", null, 0 },
                    { 92, 3, null, 0, null, 0, "Korea, South", null, 0 },
                    { 93, 5, null, 0, null, 0, "Kosovo", null, 0 },
                    { 94, 3, null, 0, null, 0, "Kuwait", null, 0 },
                    { 95, 3, null, 0, null, 0, "Kyrgyzstan", null, 0 },
                    { 96, 3, null, 0, null, 0, "Laos", null, 0 },
                    { 97, 5, null, 0, null, 0, "Latvia", null, 0 },
                    { 98, 3, null, 0, null, 0, "Lebanon", null, 0 },
                    { 99, 1, null, 0, null, 0, "Lesotho", null, 0 },
                    { 100, 1, null, 0, null, 0, "Liberia", null, 0 },
                    { 101, 1, null, 0, null, 0, "Libya", null, 0 },
                    { 102, 5, null, 0, null, 0, "Liechtenstein", null, 0 },
                    { 103, 5, null, 0, null, 0, "Lithuania", null, 0 },
                    { 104, 5, null, 0, null, 0, "Luxembourg", null, 0 },
                    { 105, 1, null, 0, null, 0, "Madagascar", null, 0 },
                    { 106, 1, null, 0, null, 0, "Malawi", null, 0 },
                    { 107, 3, null, 0, null, 0, "Malaysia", null, 0 },
                    { 108, 3, null, 0, null, 0, "Maldives", null, 0 },
                    { 109, 1, null, 0, null, 0, "Mali", null, 0 },
                    { 110, 5, null, 0, null, 0, "Malta", null, 0 },
                    { 111, 4, null, 0, null, 0, "Marshall Islands", null, 0 },
                    { 112, 1, null, 0, null, 0, "Mauritania", null, 0 },
                    { 113, 1, null, 0, null, 0, "Mauritius", null, 0 },
                    { 114, 6, null, 0, null, 0, "Mexico", null, 0 },
                    { 115, 4, null, 0, null, 0, "Micronesia", null, 0 },
                    { 116, 5, null, 0, null, 0, "Moldova", null, 0 },
                    { 117, 5, null, 0, null, 0, "Monaco", null, 0 },
                    { 118, 3, null, 0, null, 0, "Mongolia", null, 0 },
                    { 119, 5, null, 0, null, 0, "Montenegro", null, 0 },
                    { 120, 1, null, 0, null, 0, "Morocco", null, 0 },
                    { 121, 1, null, 0, null, 0, "Mozambique", null, 0 },
                    { 122, 3, null, 0, null, 0, "Myanmar (Burma)", null, 0 },
                    { 123, 1, null, 0, null, 0, "Namibia", null, 0 },
                    { 124, 4, null, 0, null, 0, "Nauru", null, 0 },
                    { 125, 3, null, 0, null, 0, "Nepal", null, 0 },
                    { 126, 5, null, 0, null, 0, "Netherlands", null, 0 },
                    { 127, 4, null, 0, null, 0, "New Zealand", null, 0 },
                    { 128, 6, null, 0, null, 0, "Nicaragua", null, 0 },
                    { 129, 1, null, 0, null, 0, "Niger", null, 0 },
                    { 130, 1, null, 0, null, 0, "Nigeria", null, 0 },
                    { 131, 5, null, 0, null, 0, "North Macedonia", null, 0 },
                    { 132, 5, null, 0, null, 0, "Norway", null, 0 },
                    { 133, 3, null, 0, null, 0, "Oman", null, 0 },
                    { 134, 3, null, 0, null, 0, "Pakistan", null, 0 },
                    { 135, 4, null, 0, null, 0, "Palau", null, 0 },
                    { 136, 6, null, 0, null, 0, "Panama", null, 0 },
                    { 137, 4, null, 0, null, 0, "Papua New Guinea", null, 0 },
                    { 138, 7, null, 0, null, 0, "Paraguay", null, 0 },
                    { 139, 7, null, 0, null, 0, "Peru", null, 0 },
                    { 140, 3, null, 0, null, 0, "Philippines", null, 0 },
                    { 141, 5, null, 0, null, 0, "Poland", null, 0 },
                    { 142, 5, null, 0, null, 0, "Portugal", null, 0 },
                    { 143, 3, null, 0, null, 0, "Qatar", null, 0 },
                    { 144, 5, null, 0, null, 0, "Romania", null, 0 },
                    { 145, 5, null, 0, null, 0, "Russia", null, 0 },
                    { 146, 1, null, 0, null, 0, "Rwanda", null, 0 },
                    { 147, 6, null, 0, null, 0, "Saint Kitts and Nevis", null, 0 },
                    { 148, 6, null, 0, null, 0, "Saint Lucia", null, 0 },
                    { 149, 6, null, 0, null, 0, "Saint Vincent and the Grenadines", null, 0 },
                    { 150, 4, null, 0, null, 0, "Samoa", null, 0 },
                    { 151, 5, null, 0, null, 0, "San Marino", null, 0 },
                    { 152, 1, null, 0, null, 0, "Sao Tome and Principe", null, 0 },
                    { 153, 3, null, 0, null, 0, "Saudi Arabia", null, 0 },
                    { 154, 1, null, 0, null, 0, "Senegal", null, 0 },
                    { 155, 5, null, 0, null, 0, "Serbia", null, 0 },
                    { 156, 1, null, 0, null, 0, "Seychelles", null, 0 },
                    { 157, 1, null, 0, null, 0, "Sierra Leone", null, 0 },
                    { 158, 3, null, 0, null, 0, "Singapore", null, 0 },
                    { 159, 5, null, 0, null, 0, "Slovakia", null, 0 },
                    { 160, 5, null, 0, null, 0, "Slovenia", null, 0 },
                    { 161, 4, null, 0, null, 0, "Solomon Islands", null, 0 },
                    { 162, 1, null, 0, null, 0, "Somalia", null, 0 },
                    { 163, 1, null, 0, null, 0, "South Africa", null, 0 },
                    { 164, 5, null, 0, null, 0, "Spain", null, 0 },
                    { 165, 3, null, 0, null, 0, "Sri Lanka", null, 0 },
                    { 166, 1, null, 0, null, 0, "Sudan", null, 0 },
                    { 167, 1, null, 0, null, 0, "Sudan, South", null, 0 },
                    { 168, 7, null, 0, null, 0, "Suriname", null, 0 },
                    { 169, 5, null, 0, null, 0, "Sweden", null, 0 },
                    { 170, 5, null, 0, null, 0, "Switzerland", null, 0 },
                    { 171, 3, null, 0, null, 0, "Syria", null, 0 },
                    { 172, 3, null, 0, null, 0, "Taiwan", null, 0 },
                    { 173, 3, null, 0, null, 0, "Tajikistan", null, 0 },
                    { 174, 1, null, 0, null, 0, "Tanzania", null, 0 },
                    { 175, 3, null, 0, null, 0, "Thailand", null, 0 },
                    { 176, 1, null, 0, null, 0, "Togo", null, 0 },
                    { 177, 4, null, 0, null, 0, "Tonga", null, 0 },
                    { 178, 6, null, 0, null, 0, "Trinidad and Tobago", null, 0 },
                    { 179, 1, null, 0, null, 0, "Tunisia", null, 0 },
                    { 180, 3, null, 0, null, 0, "Turkey", null, 0 },
                    { 181, 3, null, 0, null, 0, "Turkmenistan", null, 0 },
                    { 182, 4, null, 0, null, 0, "Tuvalu", null, 0 },
                    { 183, 1, null, 0, null, 0, "Uganda", null, 0 },
                    { 184, 5, null, 0, null, 0, "Ukraine", null, 0 },
                    { 185, 3, null, 0, null, 0, "United Arab Emirates", null, 0 },
                    { 186, 5, null, 0, null, 0, "United Kingdom", null, 0 },
                    { 187, 6, null, 0, null, 0, "United States", null, 0 },
                    { 188, 7, null, 0, null, 0, "Uruguay", null, 0 },
                    { 189, 3, null, 0, null, 0, "Uzbekistan", null, 0 },
                    { 190, 4, null, 0, null, 0, "Vanuatu", null, 0 },
                    { 191, 5, null, 0, null, 0, "Vatican City", null, 0 },
                    { 192, 7, null, 0, null, 0, "Venezuela", null, 0 },
                    { 193, 3, null, 0, null, 0, "Vietnam", null, 0 },
                    { 194, 3, null, 0, null, 0, "Yemen", null, 0 },
                    { 195, 1, null, 0, null, 0, "Zambia", null, 0 },
                    { 196, 1, null, 0, null, 0, "Zimbabwe", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_countries_ContinentId",
                schema: "public",
                table: "countries",
                column: "ContinentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "countries",
                schema: "public");

            migrationBuilder.DropTable(
                name: "continents",
                schema: "public");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourtSide.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TournamentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourtSurface = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtEnvironment = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Height = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: true),
                    TournamentsPlayed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TournamentVenues",
                columns: table => new
                {
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentVenues", x => new { x.TournamentId, x.VenueId });
                    table.ForeignKey(
                        name: "FK_TournamentVenues_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TournamentVenues_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPlayerId = table.Column<int>(type: "int", nullable: false),
                    SecondPlayerId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatchRound = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtSurface = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CourtEnvironment = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    ScoreResult = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WinnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Players_FirstPlayerId",
                        column: x => x.FirstPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Players_SecondPlayerId",
                        column: x => x.SecondPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Players_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Australia" },
                    { 10, "Austria" },
                    { 11, "Azerbaijan" },
                    { 12, "Bahamas" },
                    { 13, "Bahrain" },
                    { 14, "Bangladesh" },
                    { 15, "Barbados" },
                    { 16, "Belarus" },
                    { 17, "Belgium" },
                    { 18, "Belize" },
                    { 19, "Benin" },
                    { 20, "Bhutan" },
                    { 21, "Bolivia" },
                    { 22, "Bosnia and Herzegovina" },
                    { 23, "Botswana" },
                    { 24, "Brazil" },
                    { 25, "Brunei" },
                    { 26, "Bulgaria" },
                    { 27, "Burkina Faso" },
                    { 28, "Burundi" },
                    { 29, "Cabo Verde" },
                    { 30, "Cambodia" },
                    { 31, "Cameroon" },
                    { 32, "Canada" },
                    { 33, "Central African Republic" },
                    { 34, "Chad" },
                    { 35, "Chile" },
                    { 36, "China" },
                    { 37, "Colombia" },
                    { 38, "Comoros" },
                    { 39, "Congo (Brazzaville)" },
                    { 40, "Costa Rica" },
                    { 41, "Côte d'Ivoire" },
                    { 42, "Croatia" },
                    { 43, "Cuba" },
                    { 44, "Cyprus" },
                    { 45, "Czechia (Czech Republic)" },
                    { 46, "Democratic Republic of the Congo" },
                    { 47, "Denmark" },
                    { 48, "Djibouti" },
                    { 49, "Dominica" },
                    { 50, "Dominican Republic" },
                    { 51, "Ecuador" },
                    { 52, "Egypt" },
                    { 53, "El Salvador" },
                    { 54, "Equatorial Guinea" },
                    { 55, "Eritrea" },
                    { 56, "Estonia" },
                    { 57, "Eswatini" },
                    { 58, "Ethiopia" },
                    { 59, "Fiji" },
                    { 60, "Finland" },
                    { 61, "France" },
                    { 62, "Gabon" },
                    { 63, "Gambia" },
                    { 64, "Georgia" },
                    { 65, "Germany" },
                    { 66, "Ghana" },
                    { 67, "Greece" },
                    { 68, "Grenada" },
                    { 69, "Guatemala" },
                    { 70, "Guinea" },
                    { 71, "Guinea-Bissau" },
                    { 72, "Guyana" },
                    { 73, "Haiti" },
                    { 74, "Holy See" },
                    { 75, "Honduras" },
                    { 76, "Hungary" },
                    { 77, "Iceland" },
                    { 78, "India" },
                    { 79, "Indonesia" },
                    { 80, "Iran" },
                    { 81, "Iraq" },
                    { 82, "Ireland" },
                    { 83, "Israel" },
                    { 84, "Italy" },
                    { 85, "Jamaica" },
                    { 86, "Japan" },
                    { 87, "Jordan" },
                    { 88, "Kazakhstan" },
                    { 89, "Kenya" },
                    { 90, "Kiribati" },
                    { 91, "Kuwait" },
                    { 92, "Kyrgyzstan" },
                    { 93, "Laos" },
                    { 94, "Latvia" },
                    { 95, "Lebanon" },
                    { 96, "Lesotho" },
                    { 97, "Liberia" },
                    { 98, "Libya" },
                    { 99, "Liechtenstein" },
                    { 100, "Lithuania" },
                    { 101, "Luxembourg" },
                    { 102, "Madagascar" },
                    { 103, "Malawi" },
                    { 104, "Malaysia" },
                    { 105, "Maldives" },
                    { 106, "Mali" },
                    { 107, "Malta" },
                    { 108, "Marshall Islands" },
                    { 109, "Mauritania" },
                    { 110, "Mauritius" },
                    { 111, "Mexico" },
                    { 112, "Micronesia" },
                    { 113, "Moldova" },
                    { 114, "Monaco" },
                    { 115, "Mongolia" },
                    { 116, "Montenegro" },
                    { 117, "Morocco" },
                    { 118, "Mozambique" },
                    { 119, "Myanmar (Burma)" },
                    { 120, "Namibia" },
                    { 121, "Nauru" },
                    { 122, "Nepal" },
                    { 123, "Netherlands" },
                    { 124, "New Zealand" },
                    { 125, "Nicaragua" },
                    { 126, "Niger" },
                    { 127, "Nigeria" },
                    { 128, "North Korea" },
                    { 129, "North Macedonia" },
                    { 130, "Norway" },
                    { 131, "Oman" },
                    { 132, "Pakistan" },
                    { 133, "Palau" },
                    { 134, "Palestine State" },
                    { 135, "Panama" },
                    { 136, "Papua New Guinea" },
                    { 137, "Paraguay" },
                    { 138, "Peru" },
                    { 139, "Philippines" },
                    { 140, "Poland" },
                    { 141, "Portugal" },
                    { 142, "Qatar" },
                    { 143, "Romania" },
                    { 144, "Russia" },
                    { 145, "Rwanda" },
                    { 146, "Saint Kitts and Nevis" },
                    { 147, "Saint Lucia" },
                    { 148, "Saint Vincent and the Grenadines" },
                    { 149, "Samoa" },
                    { 150, "San Marino" },
                    { 151, "Sao Tome and Principe" },
                    { 152, "Saudi Arabia" },
                    { 153, "Senegal" },
                    { 154, "Serbia" },
                    { 155, "Seychelles" },
                    { 156, "Sierra Leone" },
                    { 157, "Singapore" },
                    { 158, "Slovakia" },
                    { 159, "Slovenia" },
                    { 160, "Solomon Islands" },
                    { 161, "Somalia" },
                    { 162, "South Africa" },
                    { 163, "South Korea" },
                    { 164, "South Sudan" },
                    { 165, "Spain" },
                    { 166, "Sri Lanka" },
                    { 167, "Sudan" },
                    { 168, "Suriname" },
                    { 169, "Sweden" },
                    { 170, "Switzerland" },
                    { 171, "Syria" },
                    { 172, "Tajikistan" },
                    { 173, "Tanzania" },
                    { 174, "Thailand" },
                    { 175, "Timor-Leste" },
                    { 176, "Togo" },
                    { 177, "Tonga" },
                    { 178, "Trinidad and Tobago" },
                    { 179, "Tunisia" },
                    { 180, "Turkey" },
                    { 181, "Turkmenistan" },
                    { 182, "Tuvalu" },
                    { 183, "Uganda" },
                    { 184, "Ukraine" },
                    { 185, "United Arab Emirates" },
                    { 186, "United Kingdom" },
                    { 187, "United States of America" },
                    { 188, "Uruguay" },
                    { 189, "Uzbekistan" },
                    { 190, "Vanuatu" },
                    { 191, "Venezuela" },
                    { 192, "Vietnam" },
                    { 193, "Yemen" },
                    { 194, "Zambia" },
                    { 195, "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CourtEnvironment", "CourtSurface", "EndDate", "Location", "StartDate", "TournamentName", "TournamentType" },
                values: new object[,]
                {
                    { 1, "Indoor", "Hard", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Lyon, France", new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Lyon Open", "ATP 250" },
                    { 2, "Indoor", "Hard", new DateTime(2026, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Paris, France", new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Rolex Paris Masters", "ATP 1000" },
                    { 3, "Outdoor", "Hard", new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "New York, USA", new DateTime(2026, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), "US Open", "Grand Slam Mens" },
                    { 4, "Indoor", "Hard", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Almaty, Kazakhstan", new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Almaty Open", "ATP 250" },
                    { 5, "Outdoor", "Hard", new DateTime(2026, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Melbourne, Australia", new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Australian Open", "Grand Slam Mens" },
                    { 6, "Outdoor", "Clay", new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Roquebrune-Cap-Martin, France", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Monte-Carlo Masters", "ATP 1000" },
                    { 7, "Outdoor", "Clay", new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Madrid, Spain", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Mutua Madrid Open", "ATP 1000" },
                    { 8, "Outdoor", "Clay", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Rome, Italy", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Italian Open", "ATP 1000" },
                    { 9, "Outdoor", "Grass", new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc), "London, United Kingdom", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Cinch Championships", "ATP 500" },
                    { 10, "Indoor", "Hard", new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Basel, Switzerland", new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Swiss Indoors Basel", "ATP 500" },
                    { 11, "Outdoor", "Hard", new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Shanghai, China", new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Shanghai Masters", "ATP 1000" },
                    { 12, "Indoor", "Hard", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Brussels, Belgium", new DateTime(2026, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc), "European Open", "ATP 250" },
                    { 13, "Indoor", "Hard", new DateTime(2026, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Stockholm, Sweden", new DateTime(2026, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Bybit Stockholm Open", "ATP 250" },
                    { 14, "Indoor", "Hard", new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Turin, Italy", new DateTime(2026, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Nitto Finals", "ATP" },
                    { 15, "Indoor", "Hard", new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Bologna, Italy", new DateTime(2026, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Davis Cup Finals", "ITF Mens" },
                    { 16, "Indoor", "Hard", new DateTime(2026, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Reggio Calabria, Italy", new DateTime(2026, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Next Gen Finals", "ATP" },
                    { 101, "Indoor", "Hard", new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Lyon, France", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Open 6ème Sens Métropole de  Lyon", "WTA 250" },
                    { 102, "Outdoor", "Clay", new DateTime(2026, 5, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Madrid, Spain", new DateTime(2026, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Mutua Madrid Open", "WTA 1000" },
                    { 103, "Outdoor", "Clay", new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Rome, Italy", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Internazionali BNL d'Italia", "WTA 1000" },
                    { 104, "Outdoor", "Hard", new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "New York, USA", new DateTime(2026, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), "US Open", "Grand Slam" },
                    { 105, "Indoor", "Hard", new DateTime(2026, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Seville, Spain", new DateTime(2026, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Billie Jean King Cup Finals", "ITF Women" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Palais des Sports de Gerland (Lyon Open)" },
                    { 2, "Accor Arena / Paris La Défense Arena (Rolex Paris Masters)" },
                    { 3, "USTA Billie Jean King National Tennis   Center (US Open)" },
                    { 4, "Almaty Arena (Almaty Open)" },
                    { 5, "Melbourne Park (Australian Open)" },
                    { 6, "Monte-Carlo Country Club (Monte-Carlo   Masters)" },
                    { 7, "Caja Mágica (Mutua Madrid Open)" },
                    { 8, "Foro Italico (Italian Open)" },
                    { 9, "Queen's Club (Cinch Championships)" },
                    { 10, "St. Jakobshalle (Swiss Indoors Basel)" },
                    { 11, "Qizhong Forest Sports City Arena   ( Shanghai Masters)" },
                    { 12, "Sportpaleis Antwerp / Lotto Arena    ( European Open)" },
                    { 13, "Kungliga Tennishallen (Bybit  Stockholm Open)" },
                    { 14, "Inalpi Arena (Nitto Finals)" },
                    { 15, "Unipol Arena (Davis Cup Finals)" },
                    { 16, "PalaTennis 'Corrado Barazzutti' (Next   Gen Finals)" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Birthplace", "CountryId", "FirstName", "Gender", "Height", "LastName", "Points", "Rank", "TournamentsPlayed", "Weight" },
                values: new object[,]
                {
                    { 1, 39, "Belgrade, Serbia", 154, "Novak", "Male", "6'2\"/(188cm)", "Djokovic", 3090, 12, 14, "170 lbs/(77kg)" },
                    { 2, 23, "El Palmar, Murcia, Spain", 165, "Carlos", "Male", "6'0\"/(183cm)", "Alcaraz", 5610, 3, 18, "163 lbs/(74kg)" },
                    { 3, 25, "Innichen, Italy", 84, "Jannik", "Male", "6'3\"/(191cm)", "Sinner", 10450, 1, 20, "168 lbs/(76kg)" },
                    { 4, 30, "Moscow, Russia", 114, "Daniil", "Male", "6'6\"/(198cm)", "Medvedev", 3620, 5, 21, "183 lbs/(83kg)" },
                    { 5, 29, "Hamburg, Germany", 65, "Alexander", "Male", "6'6\"/(198cm)", "Zverev", 9750, 2, 22, "198 lbs/(90kg)" },
                    { 6, 35, "Haskovo, Bulgaria", 26, "Grigor", "Male", "6'3\"/(191cm)", "Dimitrov", 472, 124, 16, "178 lbs/(80kg)" },
                    { 7, 28, "Athens, Greece", 67, "Stefanos", "Male", "6'4\"/(193cm)", "Tsitsipas", 1380, 35, 23, "198 lbs/(90kg)" },
                    { 8, 27, "Oslo, Norway", 130, "Casper", "Male", "6'0\"/(183cm)", "Ruud", 1995, 25, 25, "178 lbs/(81kg)" },
                    { 10, 28, "Rancho Santa Fe, California, USA", 187, "Taylor", "Male", "6'5\"/(196cm)", "Fritz", 2830, 13, 22, "185 lbs/(84kg)" },
                    { 11, 27, "Sydney, Australia", 9, "Alex", "Male", "6'0\"/(183cm)", "de Minaur", 3280, 10, 21, "152 lbs/(69kg)" },
                    { 12, 29, "Moscow, Russia", 144, "Andrey", "Male", "6'2\"/(188cm)", "Rublev", 2175, 22, 24, "165 lbs/(75kg)" },
                    { 13, 29, "Wroclaw, Poland", 140, "Hubert", "Male", "6'5\"/(196cm)", "Hurkacz", 1585, 28, 20, "179 lbs/(81kg)" },
                    { 14, 24, "Atlanta, Georgia, USA", 187, "Ben", "Male", "6'4\"/(193cm)", "Shelton", 4680, 4, 23, "195 lbs/(88kg)" },
                    { 15, 28, "Hyattsville, Maryland, USA", 187, "Frances", "Male", "6'2\"/(188cm)", "Tiafoe", 3380, 8, 24, "190 lbs/(86kg)" },
                    { 16, 28, "Metz, France", 61, "Ugo", "Male", "6'2\"/(188cm)", "Humbert", 1270, 38, 22, "161 lbs/(73kg)" },
                    { 17, 26, "Bradenton, Florida, USA", 187, "Sebastian", "Male", "6'5\"/(196cm)", "Korda", 730, 81, 18, "175 lbs/(79kg)" },
                    { 18, 24, "Carrara, Italy", 84, "Lorenzo", "Male", "6'1\"/(185cm)", "Musetti", 1720, 27, 26, "165 lbs/(75kg)" },
                    { 19, 24, "Sutton, London, United Kingdom", 186, "Jack", "Male", "6'4\"/(193cm)", "Draper", 360, 157, 17, "187 lbs/(85kg)" },
                    { 20, 26, "Montreal, Canada", 32, "Felix", "Male", "6'4\"/(193cm)", "Auger-Aliassime", 3515, 7, 21, "194 lbs/(88kg)" },
                    { 21, 26, "Mar del Plata, Argentina", 7, "Francisco", "Male", "5'10\"/(178cm)", "Comesana", 455, 128, 15, "165 lbs/(75kg)" },
                    { 22, 31, "Johannesburg, South Africa", 186, "Cameron", "Male", "6'2\"/(188cm)", "Norrie", 1195, 41, 20, "180 lbs/(82kg)" },
                    { 23, 41, "Lausanne, Switzerland", 170, "Stan", "Male", "6'0\"/(183cm)", "Wawrinka", 376, 148, 14, "179 lbs/(81kg)" },
                    { 25, 30, "Rome, Italy", 84, "Matteo", "Male", "6'5\"/(196cm)", "Berrettini", 1083, 46, 16, "210 lbs/(95kg)" },
                    { 26, 30, "Moscow, Russia", 144, "Karen", "Male", "6'6\"/(198cm)", "Khachanov", 2005, 24, 22, "192 lbs/(87kg)" },
                    { 27, 25, "Buenos Aires, Argentina", 7, "Sebastian", "Male", "5'7\"/(170cm)", "Baez", 1044, 48, 24, "154 lbs/(70kg)" },
                    { 28, 28, "Buenos Aires, Argentina", 7, "Francisco", "Male", "6'1\"/(185cm)", "Cerundolo", 2260, 19, 23, "172 lbs/(78kg)" },
                    { 29, 29, "Toronto, Canada", 35, "Alejandro", "Male", "6'2\"/(188cm)", "Tabilo", 1565, 30, 21, "165 lbs/(75kg)" },
                    { 31, 27, "La Plata, Argentina", 7, "Tomas Martin", "Male", "6'5\"/(196cm)", "Etcheverry", 1565, 29, 25, "181 lbs/(82kg)" },
                    { 32, 22, "Courcouronnes, France", 61, "Arthur", "Male", "6'1\"/(185cm)", "Fils", 3375, 9, 23, "183 lbs/(83kg)" },
                    { 33, 38, "Soisy-sous-Montmorency, France", 61, "Adrian", "Male", "6'0\"/(183cm)", "Mannarino", 783, 73, 27, "174 lbs/(79kg)" },
                    { 34, 36, "Warstein, Germany", 65, "Jan-Lennard", "Male", "6'4\"/(193cm)", "Struff", 969, 54, 19, "203 lbs/(92kg)" },
                    { 36, 29, "Maia, Portugal", 141, "Nuno", "Male", "6'1\"/(185cm)", "Borges", 1000, 51, 22, "165 lbs/(75kg)" },
                    { 37, 27, "Budapest, Hungary", 76, "Fabian", "Male", "6'4\"/(193cm)", "Marozsan", 860, 61, 21, "165 lbs/(75kg)" },
                    { 38, 27, "Sydney, Australia", 9, "Alexei", "Male", "6'5\"/(196cm)", "Popyrin", 458, 127, 21, "172 lbs/(78kg)" },
                    { 39, 25, "Sanremo, Italy", 84, "Matteo", "Male", "5'11\"/(180cm)", "Arnaldi", 1311, 36, 24, "157 lbs/(71kg)" },
                    { 40, 23, "Lyon, France", 61, "Giovanni", "Male", "6'8\"/(203cm)", "Mpetshi Perricard", 385, 146, 18, "216 lbs/(98kg)" },
                    { 41, 29, "Voorhees, New Jersey, USA", 187, "Tommy", "Male", "6'1\"/(185cm)", "Paul", 2625, 14, 22, "180 lbs/(82kg)" },
                    { 42, 31, "Turin, Italy", 84, "Lorenzo", "Male", "6'3\"/(191cm)", "Sonego", 658, 90, 25, "169 lbs/(77kg)" },
                    { 44, 27, "Malaga, Spain", 165, "Alejandro", "Male", "6'0\"/(183cm)", "Davidovich Fokina", 2610, 15, 23, "176 lbs/(80kg)" },
                    { 45, 31, "Senta, Serbia", 154, "Laslo", "Male", "6'1\"/(185cm)", "Djere", 412, 136, 17, "174 lbs/(79kg)" },
                    { 46, 29, "Podolsk, Russia", 144, "Roman", "Male", "6'1\"/(185cm)", "Safiullin", 807, 69, 22, "172 lbs/(78kg)" },
                    { 50, 31, "Gassin, France", 61, "Arthur", "Male", "6'5\"/(196cm)", "Rinderknech", 870, 60, 25, "187 lbs/(85kg)" },
                    { 52, 28, "Kempen, Germany", 65, "Daniel", "Male", "6'3\"/(191cm)", "Altmaier", 849, 62, 24, "170 lbs/(77kg)" },
                    { 53, 27, "Moscow, Russia", 144, "Pavel", "Male", "6'4\"/(193cm)", "Kotov", 339, 169, 22, "185 lbs/(84kg)" },
                    { 54, 26, "Marechal Candido Rondon, Brazil", 24, "Thiago", "Male", "6'0\"/(183cm)", "Seyboth Wild", 545, 110, 21, "174 lbs/(79kg)" },
                    { 55, 33, "Thousand Oaks, California, USA", 187, "Marcos", "Male", "5'11\"/(180cm)", "Giron", 676, 87, 25, "160 lbs/(73kg)" },
                    { 56, 30, "Sydney, Australia", 9, "Aleksandar", "Male", "6'2\"/(188cm)", "Vukic", 507, 116, 23, "172 lbs/(78kg)" },
                    { 60, 31, "Wageningen, Netherlands", 123, "Botic", "Male", "6'3\"/(191cm)", "van de Zandschulp", 1295, 37, 24, "185 lbs/(84kg)" },
                    { 61, 27, "Belgrade, Serbia", 154, "Miomir", "Male", "6'0\"/(183cm)", "Kecmanović", 353, 161, 25, "170 lbs/(77kg)" },
                    { 62, 30, "Haarlem, Netherlands", 123, "Tallon", "Male", "6'2\"/(188cm)", "Griekspoor", 835, 65, 26, "183 lbs/(83kg)" },
                    { 63, 24, "Florence, Italy", 84, "Flavio", "Male", "6'0\"/(183cm)", "Cobolli", 3590, 6, 23, "165 lbs/(75kg)" },
                    { 64, 25, "9 de Julio, Argentina", 7, "Mariano", "Male", "5'9\"/(175cm)", "Navone", 1164, 43, 22, "160 lbs/(73kg)" },
                    { 65, 25, "San Diego, California, USA", 187, "Brandon", "Male", "6'1\"/(185cm)", "Nakashima", 2350, 17, 24, "170 lbs/(77kg)" },
                    { 66, 33, "New York, New York, USA", 86, "Taro", "Male", "6'3\"/(191cm)", "Daniel", 321, 177, 21, "170 lbs/(77kg)" },
                    { 67, 33, "Tenerife, Spain", 165, "Roberto", "Male", "6'0\"/(183cm)", "Carballés Baena", 835, 64, 25, "165 lbs/(75kg)" },
                    { 68, 29, "Santanyi, Spain", 165, "Jaume", "Male", "6'0\"/(183cm)", "Munar", 835, 66, 22, "165 lbs/(75kg)" },
                    { 69, 21, "Laguna Hills, California, USA", 187, "Alex", "Male", "6'4\"/(193cm)", "Michelsen", 1385, 34, 24, "170 lbs/(77kg)" },
                    { 70, 27, "New York, New York, USA", 187, "Aleksandar", "Male", "6'0\"/(183cm)", "Kovacevic", 703, 84, 23, "174 lbs/(79kg)" },
                    { 71, 28, "Sydney, Australia", 9, "Max", "Male", "6'1\"/(185cm)", "Purcell", 650, 91, 24, "157 lbs/(71kg)" },
                    { 72, 30, "Adelaide, Australia", 9, "Thanasi", "Male", "6'4\"/(193cm)", "Kokkinakis", 760, 75, 20, "185 lbs/(84kg)" },
                    { 73, 25, "Sydney, Australia", 9, "Rinky", "Male", "5'10\"/(178cm)", "Hijikata", 689, 85, 26, "152 lbs/(69kg)" },
                    { 74, 34, "Sydney, Australia", 9, "James", "Male", "6'0\"/(183cm)", "Duckworth", 814, 68, 25, "176 lbs/(80kg)" },
                    { 75, 24, "Villa Gesell, Argentina", 84, "Luciano", "Male", "6'1\"/(185cm)", "Darderi", 2160, 23, 26, "172 lbs/(78kg)" },
                    { 76, 24, "Montreal, Canada", 32, "Gabriel", "Male", "6'8\"/(203cm)", "Diallo", 382, 148, 21, "212 lbs/(96kg)" },
                    { 77, 25, "La Plata, Argentina", 7, "Thiago Agustín", "Male", "6'2\"/(188cm)", "Tirante", 1024, 49, 22, "172 lbs/(78kg)" },
                    { 78, 29, "Bondy, France", 61, "Quentin", "Male", "6'4\"/(193cm)", "Halys", 1127, 45, 23, "180 lbs/(82kg)" },
                    { 79, 25, "Haarlem, Netherlands", 123, "Jesper", "Male", "5'11\"/(180cm)", "de Jong", 591, 100, 22, "159 lbs/(72kg)" },
                    { 80, 31, "Nottingham, United Kingdom", 186, "Billy", "Male", "6'2\"/(188cm)", "Harris", 568, 105, 28, "176 lbs/(80kg)" },
                    { 81, 23, "Novi Pazar, Serbia", 154, "Hamad", "Male", "6'2\"/(188cm)", "Medjedovic", 751, 78, 19, "190 lbs/(86kg)" },
                    { 82, 25, "Lyon, France", 61, "Kyrian", "Male", "5'10\"/(178cm)", "Jacquet", 741, 79, 21, "155 lbs/(70kg)" },
                    { 83, 26, "Reims, France", 61, "Clément", "Male", "5'8\"/(173cm)", "Tabur", 355, 160, 22, "160 lbs/(73kg)" },
                    { 84, 30, "Nîmes, France", 61, "Benjamin", "Male", "6'0\"/(183cm)", "Bonzi", 617, 97, 24, "180 lbs/(82kg)" },
                    { 85, 22, "Woluwe-Saint-Lambert,Belgium", 61, "Luca", "Male", "5'10\"/(178cm)", "Van Assche", 1080, 47, 24, "158 lbs/(72kg)" },
                    { 86, 25, "Villeneuve-SaintGeorges,   France", 61, "Titouan", "Male", "6'3\"/(191cm)", "Droguet", 801, 72, 21, "176 lbs/(80kg)" },
                    { 87, 27, "Paris, France", 61, "Corentin", "Male", "5'11\"/(180cm)", "Moutet", 590, 101, 20, "156 lbs/(71kg)" },
                    { 88, 24, "Sèvres, France", 186, "Arthur", "Male", "5'9\"/(175cm)", "Féry", 1406, 33, 19, "165 lbs/(75kg)" },
                    { 89, 28, "Split, Croatia", 42, "Borna", "Male", "6'5\"/(196cm)", "Gojo", 416, 135, 16, "187 lbs/(85kg)" },
                    { 90, 35, "Schiltigheim, France", 61, "Pierre-Hugues", "Male", "6'2\"/(188cm)", "Herbert", 315, 248, 18, "176 lbs/(80kg)" },
                    { 91, 20, "Madrid, Spain", 165, "Rafael", "Male", "6'3\"/(191cm)", "Jodar", 2850, 11, 17, "154 lbs/(70kg)" },
                    { 92, 21, "Hyères, France", 75, "Arthur", "Male", "6'1\"/(185cm)", "Gea", 295, 195, 22, "165 lbs/(75kg)" },
                    { 93, 23, "Gentofte, Denmark", 47, "Holger", "Male", "6'2\"/(188cm)", "Rune", 2850, 194, 23, "170 lbs/(77kg)" },
                    { 94, 21, "Irvine, California, USA", 187, "Learner", "Male", "5'11\"/(180cm)", "Tien", 2345, 16, 13, "165 lbs/(75kg)" },
                    { 95, 29, "Gatchina, Russia", 88, "Alexander", "Male", "6'5\"/(196cm)", "Bublik", 2285, 18, 27, "181 lbs/(82kg)" },
                    { 96, 25, "Mlada Boleslav, Czech Republic", 45, "Jiri", "Male", "6'1\"/(185cm)", "Lehecka", 2275, 20, 25, "176 lbs/(80kg)" },
                    { 97, 21, "Antwerp, Belgium", 17, "Alexander", "Male", "6'3\"/(191cm)", "Blockx", 1790, 21, 21, "179 lbs/(81kg)" },
                    { 98, 28, "Roquebrune-Cap-Martin, France", 114, "Valentin", "Male", "6'4\"/(193cm)", "Vacherot", 1480, 26, 32, "185 lbs/(84kg)" },
                    { 99, 22, "Lima, Peru", 138, "Ignacio", "Male", "6'0\"/(183cm)", "Buse", 1445, 31, 22, "165 lbs/(75kg)" },
                    { 100, 20, "Rio de Janeiro, Brazil", 24, "Joao", "Male", "6'1\"/(185cm)", "Fonseca", 1250, 32, 14, "176 lbs/(80kg)" },
                    { 101, 22, "Asuncion, Paraguay", 137, "Adolfo Daniel", "Male", "6'0\"/(183cm)", "Vallejo", 965, 39, 22, "165 lbs/(75kg)" },
                    { 102, 22, "Madrid, Spain", 165, "Daniel", "Male", "6'1\"/(185cm)", "Merida", 1195, 40, 28, "165 lbs/(75kg)" },
                    { 103, 24, "Rochefort, Belgium", 17, "Raphael", "Male", "6'2\"/(188cm)", "Collignon", 975, 42, 23, "172 lbs/(78kg)" },
                    { 104, 23, "Lisbon, Portugal", 141, "Jaime", "Male", "6'1\"/(185cm)", "Faria", 960, 44, 25, "170 lbs/(77kg)" },
                    { 105, 20, "Madrid, Spain", 165, "Martin", "Male", "6'3\"/(191cm)", "Landaluce", 835, 50, 22, "172 lbs/(78kg)" },
                    { 106, 27, "Buenos Aires, Argentina", 7, "Camilo", "Male", "6'1\"/(185cm)", "Ugo Carabelli", 795, 52, 24, "165 lbs/(75kg)" },
                    { 107, 24, "Buenos Aires, Argentina", 7, "Roman Andres", "Male", "6'0\"/(183cm)", "Burruchaga", 765, 53, 22, "170 lbs/(77kg)" },
                    { 108, 30, "Piotrkow Trybunalski, Poland", 140, "Kamil", "Male", "5'11\"/(180cm)", "Majchrzak", 722, 55, 21, "172 lbs/(78kg)" },
                    { 109, 25, "Edinburgh, Scotland", 186, "Jacob", "Male", "6'0\"/(183cm)", "Fearnley", 688, 56, 20, "170 lbs/(77kg)" },
                    { 110, 36, "Santiago del Estero, Argentina", 7, "Marco", "Male", "5'11\"/(180cm)", "Trungelliti", 672, 57, 24, "165 lbs/(75kg)" },
                    { 111, 34, "Tbilisi, Georgia", 64, "Nikoloz", "Male", "6'1\"/(185cm)", "Basilashvili", 630, 58, 23, "174 lbs/(79kg)" },
                    { 112, 38, "Medjugorje, Bosnia and  Herzegovina", 42, "Marin", "Male", "6'6\"/(198cm)", "Cilic", 625, 59, 18, "196 lbs/(89kg)" },
                    { 113, 22, "Porto, Portugal", 141, "Henrique", "Male", "6'0\"/(183cm)", "Rocha", 612, 67, 25, "168 lbs/(76kg)" },
                    { 114, 22, "Montville, NJ, USA", 187, "Michael", "Male", "5'11\"/(180cm)", "Zheng", 605, 70, 20, "165 lbs/(75kg)" },
                    { 115, 25, "Paris, France", 61, "Valentin", "Male", "6'2\"/(188cm)", "Royer", 585, 71, 22, "172 lbs/(78kg)" },
                    { 116, 23, "Aarhus, Denmark", 47, "Elmer", "Male", "6'0\"/(183cm)", "Moller", 570, 74, 24, "168 lbs/(76kg)" },
                    { 117, 21, "Siauliai, Lithuania", 100, "Vilius", "Male", "6'1\"/(185cm)", "Gaubas", 555, 76, 26, "175 lbs/(79kg)" },
                    { 118, 29, "Zagreb, Croatia", 42, "Borna", "Male", "6'1\"/(185cm)", "Coric", 750, 77, 21, "183 lbs/(83kg)" },
                    { 119, 35, "Rocourt, Belgium", 17, "David", "Male", "5'11\"/(180cm)", "Goffin", 730, 80, 23, "150 lbs/(68kg)" },
                    { 120, 33, "Wiener Neustadt, Austria", 10, "Dominic", "Male", "6'1\"/(185cm)", "Thiem", 710, 82, 19, "179 lbs/(81kg)" },
                    { 121, 35, "Podgorica, Montenegro", 32, "Milos", "Male", "6'5\"/(196cm)", "Raonic", 695, 83, 12, "216 lbs/(98kg)" },
                    { 122, 34, "Buenos Aires, Argentina", 7, "Diego", "Male", "5'7\"/(170cm)", "Schwartzman", 680, 86, 22, "152 lbs/(69kg)" },
                    { 123, 28, "Spisska Nova Ves, Slovakia", 158, "Lukas", "Male", "6'4\"/(193cm)", "Klein", 670, 88, 22, "185 lbs/(84kg)" },
                    { 124, 27, "Lommel, Belgium", 17, "Zizou", "Male", "6'1\"/(185cm)", "Bergs", 660, 89, 23, "172 lbs/(78kg)" },
                    { 125, 24, "Bortala, China", 36, "Bu", "Male", "6'1\"/(185cm)", "Yunchaokete", 650, 91, 22, "172 lbs/(78kg)" },
                    { 126, 22, "Hong Kong, China", 36, "Coleman", "Male", "6'3\"/(191cm)", "Wong", 645, 92, 24, "176 lbs/(80kg)" },
                    { 127, 26, "Toulouse, France", 61, "Hugo", "Male", "5'8\"/(173cm)", "Gaston", 640, 93, 26, "150 lbs/(68kg)" },
                    { 128, 27, "Paris, France", 61, "Corentin", "Male", "5'9\"/(175cm)", "Moutet", 630, 94, 23, "150 lbs/(68kg)" },
                    { 129, 21, "Split, Croatia", 42, "Dino", "Male", "6'2\"/(188cm)", "Prizmic", 625, 95, 20, "170 lbs/(77kg)" },
                    { 130, 24, "Bournemouth, United Kingdom", 186, "Toby", "Male", "6'0\"/(183cm)", "Samuel", 620, 96, 21, "165 lbs/(75kg)" },
                    { 131, 24, "Boulogne-sur-Mer, France", 61, "Terence", "Male", "6'4\"/(193cm)", "Atmane", 612, 98, 25, "181 lbs/(82kg)" },
                    { 132, 26, "Sacramento, California, USA", 187, "Jenson", "Male", "6'4\"/(193cm)", "Brooksby", 605, 99, 19, "183 lbs/(83kg)" },
                    { 1001, 27, "Moscow, Russia", 113, "Elena", "Female", "6'0\"/(184cm)", "Rybakina", 9196, 1, 20, "143 lbs/(65kg)" },
                    { 1002, 28, "Minsk, Belarus", 16, "Aryna", "Female", "6'0\"/(182cm)", "Sabalenka", 7550, 2, 20, "176 lbs/(80kg)" },
                    { 1003, 19, "Krasnoyarsk, Russia", 144, "Mirra", "Female", "5'9\"/(175cm)", "Andreeva", 6306, 3, 20, "135 lbs/(61kg)" },
                    { 1004, 32, "Buffalo, New York, USA", 187, "Jessica", "Female", "5'7\"/(170cm)", "Pegula", 6235, 4, 19, "154 lbs/(70kg)" },
                    { 1005, 22, "Delray Beach, Florida, USA", 187, "Coco", "Female", "5'9\"/(175cm)", "Gauff", 5974, 5, 19, "141 lbs/(64kg)" },
                    { 1006, 32, "Odesa, Ukraine", 184, "Elina", "Female", "5'9\"/(174cm)", "Svitolina", 5229, 6, 19, "132 lbs/(60kg)" },
                    { 1007, 30, "Olomouc, Czech Republic", 45, "Karolina", "Female", "5'11\"/(180cm)", "Muchova", 4833, 7, 19, "141 lbs/(64kg)" },
                    { 1008, 21, "Vsetín, Czech Republic", 45, "Linda", "Female", "5'10\"/(179cm)", "Noskova", 4678, 8, 19, "143 lbs/(65kg)" },
                    { 1009, 25, "Warsaw, Poland", 140, "Iga", "Female", "5'9\"/(175cm)", "Swiatek", 4389, 9, 19, "143 lbs/(65kg)" },
                    { 1010, 24, "Kyiv, Ukraine", 184, "Marta", "Female", "5'9\"/(175cm)", "Kostyuk", 3920, 10, 18, "137 lbs/(62kg)" },
                    { 1011, 25, "Dąbrowa Górnicza, Poland", 140, "Maja", "Female", "5'5\"/(165cm)", "Chwalinska", 3031, 11, 22, "128 lbs/(58kg)" },
                    { 1012, 18, "Torrance, California, USA", 187, "Iva", "Female", "5'8\"/(173cm)", "Jovic", 2931, 12, 22, "130 lbs/(59kg)" },
                    { 1013, 22, "Zhigulyovsk, Russia", 144, "Diana", "Female", "5'8\"/(173cm)", "Shnaider", 2663, 13, 22, "143 lbs/(65kg)" },
                    { 1014, 29, "Flawil, Switzerland", 170, "Belinda", "Female", "5'9\"/(175cm)", "Bencic", 2662, 14, 18, "139 lbs/(63kg)" },
                    { 1015, 30, "Leuven, Belgium", 17, "Elise", "Female", "5'10\"/(179cm)", "Mertens", 2540, 15, 21, "148 lbs/(67kg)" },
                    { 1016, 20, "Charlotte, NorthCarolina,USA", 32, "Victoria", "Female", "5'9\"/(176cm)", "Mboko", 2501, 16, 16, "143 lbs/(65kg)" },
                    { 1017, 36, "Bucharest, Romania", 143, "Sorana", "Female", "5'9\"/(176cm)", "Cirstea", 2380, 17, 21, "130 lbs/(59kg)" },
                    { 1018, 25, "Freehold, New Jersey, USA", 187, "Amanda", "Female", "5'11\"/(180cm)", "Anisimova", 2363, 18, 15, "132 lbs/(60kg)" },
                    { 1019, 29, "Chuo-ku, Osaka, Japan", 86, "Naomi", "Female", "5'11\"/(180cm)", "Osaka", 2297, 19, 18, "152 lbs/(69kg)" },
                    { 1020, 21, "Quezon City, Philippines", 139, "Alexandra", "Female", "5'9\"/(175cm)", "Eala", 2241, 20, 28, "132 lbs/(60kg)" },
                    { 1021, 31, "Rock Island, Illinois, USA", 187, "Madison", "Female", "5'10\"/(178cm)", "Keys", 2029, 21, 21, "145 lbs/(66kg)" },
                    { 1022, 24, "Shiyan, Hubei, China", 36, "Qinwen", "Female", "5'10\"/(178cm)", "Zheng", 2018, 22, 18, "139 lbs/(63kg)" },
                    { 1023, 27, "Moscow, Russia", 144, "Anna", "Female", "5'9\"/(175cm)", "Kalinskaya", 1989, 23, 22, "137 lbs/(62kg)" },
                    { 1024, 29, "Riga, Latvia", 94, "Jelena", "Female", "5'10\"/(178cm)", "Ostapenko", 1916, 24, 21, "141 lbs/(64kg)" },
                    { 1025, 26, "King ofPrussiaPennsylvania,    USA", 187, "Ann", "Female", "5'7\"/(170cm)", "Li", 1833, 25, 27, "135 lbs/(61kg)" },
                    { 1026, 28, "Prague, Czech Republic", 45, "Marie", "Female", "5'11\"/(180cm)", "Bouzkova", 1818, 26, 23, "134 lbs/(61kg)" },
                    { 1027, 25, "Saratov, Russia", 144, "Anastasia", "Female", "5'9\"/(175cm)", "Potapova", 1814, 27, 21, "126 lbs/(57kg)" },
                    { 1028, 25, "New York City, New York,USA", 187, "Emma", "Female", "5'7\"/(170cm)", "Navarro", 1794, 28, 25, "154 lbs/(70kg)" },
                    { 1029, 20, "Prague, Czech Republic", 45, "Nikola", "Female", "5'8\"/(173cm)", "Bartunkova", 1711, 29, 23, "132 lbs/(60kg)" },
                    { 1030, 24, "Montreal, Canada", 32, "Leylah", "Female", "5'6\"/(168cm)", "Fernandez", 1709, 30, 28, "128 lbs/(58kg)" },
                    { 1031, 31, "Athens, Greece", 67, "Maria", "Female", "5'8\"/(172cm)", "Sakkari", 1706, 31, 23, "138 lbs/(62kg)" },
                    { 1032, 20, "Hrušovany nadJevišovkou,   Czech       Republic", 45, "Sara", "Female", "5'5\"/(165cm)", "Bejlek", 1650, 32, 25, "125 lbs/(57kg)" },
                    { 1033, 31, "Chelyabinsk, Russia", 144, "Ekaterina", "Female", "5'9\"/(175cm)", "Alexandrova", 1591, 33, 26, "146 lbs/(66kg)" },
                    { 1034, 24, "Nice, France", 61, "Diane", "Female", "5'7\"/(170cm)", "Parry", 1549, 34, 27, "132 lbs/(60kg)" },
                    { 1035, 30, "Castelnuovo diGarfagnana, Italy", 84, "Jasmine", "Female", "5'4\"/(163cm)", "Paolini", 1453, 35, 19, "119 lbs/(54kg)" },
                    { 1036, 30, "Osijek, Croatia", 42, "Donna", "Female", "5'10\"/(179cm)", "Vekic", 1333, 36, 24, "141 lbs/(64kg)" },
                    { 1037, 25, "Cincinnati, Ohio, USA", 187, "Peyton", "Female", "5'8\"/(173cm)", "Stearns", 1316, 37, 23, "135 lbs/(61kg)" },
                    { 1038, 28, "Chisinau, Moldova", 165, "Cristina", "Female", "5'9\"/(175cm)", "Bucsa", 1294, 38, 24, "130 lbs/(59kg)" },
                    { 1039, 25, "Shenzhen, China", 36, "Xinyu", "Female", "6'0\"/(182cm)", "Wang", 1288, 39, 25, "139 lbs/(63kg)" },
                    { 1040, 24, "Kyiv, Ukraine", 184, "Daria", "Female", "5'7\"/(170cm)", "Snigur", 1280, 40, 24, "130 lbs/(59kg)" },
                    { 1041, 28, "Dusseldorf, Germany", 9, "Kimberly", "Female", "5'7\"/(170cm)", "Birrell", 1280, 41, 28, "132 lbs/(60kg)" },
                    { 1042, 22, "Perth, Australia", 9, "Talia", "Female", "5'9\"/(175cm)", "Gibson", 1273, 42, 31, "135 lbs/(61kg)" },
                    { 1043, 27, "Olenegorsk, Russia", 144, "Liudmila", "Female", "5'11\"/(180cm)", "Samsonova", 1234, 43, 25, "148 lbs/(67kg)" },
                    { 1044, 24, "Washington, D.C., USA", 187, "Hailey", "Female", "5'9\"/(175cm)", "Baptiste", 1154, 44, 15, "150 lbs/(68kg)" },
                    { 1045, 30, "Brno, Czech Republic", 45, "Barbora", "Female", "5'10\"/(178cm)", "Krejcikova", 1133, 45, 20, "137 lbs/(62kg)" },
                    { 1046, 24, "Jakarta, Indonesia", 79, "Janice", "Female", "5'6\"/(168cm)", "Tjen", 1120, 46, 29, "130 lbs/(59kg)" },
                    { 1047, 28, "Łódź, Poland", 140, "Magdalena", "Female", "5'7\"/(171cm)", "Frech", 1110, 47, 23, "134 lbs/(61kg)" },
                    { 1048, 34, "Louny, Czech Republic", 45, "Karolina", "Female", "6'1\"/(186cm)", "Pliskova", 1105, 48, 15, "159 lbs/(72kg)" },
                    { 1049, 24, "London, United Kingdom", 186, "Sonay", "Female", "5'7\"/(170cm)", "Kartal", 1097, 49, 11, "132 lbs/(60kg)" },
                    { 1050, 26, "Kakhovka, Ukraine", 184, "Yuliia", "Female", "5'8\"/(172cm)", "Starodubtseva", 1090, 50, 29, "135 lbs/(61kg)" },
                    { 1051, 29, "Nova Kakhovka, Ukraine", 184, "Anhelina", "Female", "5'10\"/(179cm)", "Kalinina", 1087, 51, 24, "132 lbs/(60kg)" },
                    { 1052, 30, "Cairo, Egypt", 52, "Mayar", "Female", "5'11\"/(180cm)", "Sherif", 1085, 52, 27, "137 lbs/(62kg)" },
                    { 1053, 22, "Nakhon Ratchasima, Thailand", 174, "Lanlana", "Female", "5'8\"/(173cm)", "Tararudee", 1080, 53, 28, "132 lbs/(60kg)" },
                    { 1054, 23, "Copenhagen, Denmark", 47, "Clara", "Female", "6'0\"/(182cm)", "Tauson", 1074, 54, 24, "150 lbs/(68kg)" },
                    { 1055, 22, "Spring, Texas, USA", 187, "Ashlyn", "Female", "6'1\"/(185cm)", "Krueger", 1072, 55, 23, "143 lbs/(65kg)" },
                    { 1056, 31, "Hamburg, Germany", 65, "Tamara", "Female", "5'7\"/(170cm)", "Korpatsch", 1070, 56, 33, "128 lbs/(58kg)" },
                    { 1057, 18, "Lienz, Austria", 10, "Lilli", "Female", "5'9\"/(175cm)", "Tagger", 1052, 57, 22, "130 lbs/(59kg)" },
                    { 1058, 30, "Leicester, United Kingdom", 186, "Katie", "Female", "5'11\"/(180cm)", "Boulter", 1042, 58, 23, "137 lbs/(62kg)" },
                    { 1059, 24, "Cincinnati, Ohio, USA", 187, "Caty", "Female", "5'10\"/(178cm)", "Mcnally", 1035, 59, 24, "139 lbs/(63kg)" },
                    { 1060, 28, "Bucharest, Romania", 143, "Elena-Gabriela", "Female", "5'8\"/(172cm)", "Ruse", 1033, 60, 24, "132 lbs/(60kg)" },
                    { 1061, 28, "New York City, USA", 165, "Paula", "Female", "5'11\"/(180cm)", "Badosa", 1023, 61, 22, "154 lbs/(70kg)" },
                    { 1062, 25, "Kyiv, Ukraine", 184, "Oleksandra", "Female", "5'8\"/(173cm)", "Oliynykova", 1022, 62, 30, "130 lbs/(59kg)" },
                    { 1063, 24, "Istanbul, Turkey", 180, "Zeynep", "Female", "5'7\"/(170cm)", "Sonmez", 987, 63, 26, "128 lbs/(58kg)" },
                    { 1064, 25, "Atlanta, Georgia, USA", 187, "Alycia", "Female", "6'1\"/(185cm)", "Parks", 985, 64, 36, "143 lbs/(65kg)" },
                    { 1065, 25, "Ancona, Italy", 84, "Elisabetta", "Female", "5'5\"/(166cm)", "Cocciaretto", 975, 65, 21, "123 lbs/(56kg)" },
                    { 1066, 31, "Moscow, Russia", 88, "Yulia", "Female", "5'4\"/(163cm)", "Putintseva", 969, 66, 24, "130 lbs/(59kg)" },
                    { 1067, 25, "Yekaterinburg, Russia", 189, "Kamilla", "Female", "5'7\"/(170cm)", "Rakhimova", 966, 67, 28, "132 lbs/(60kg)" },
                    { 1068, 24, "Cúcuta, Colombia", 37, "Camila", "Female", "5'3\"/(160cm)", "Osorio", 963, 68, 25, "128 lbs/(58kg)" },
                    { 1069, 39, "Bad Saulgau, Germany", 65, "Tatjana", "Female", "5'8\"/(172cm)", "Maria", 945, 69, 32, "137 lbs/(62kg)" },
                    { 1070, 22, "Moscow, Russia", 189, "Maria", "Female", "5'6\"/(167cm)", "Timofeeva", 931, 70, 25, "130 lbs/(59kg)" },
                    { 1071, 28, "Bucharest, Romania", 143, "Jaqueline", "Female", "5'11\"/(180cm)", "Cristian", 928, 71, 20, "143 lbs/(65kg)" },
                    { 1072, 28, "Moscow, Russia", 61, "Anna", "Female", "5'10\"/(179cm)", "Blinkova", 921, 72, 32, "130 lbs/(59kg)" },
                    { 1073, 24, "Walnut Creek, California, USA", 187, "Katie", "Female", "5'7\"/(170cm)", "Volynets", 919, 73, 27, "130 lbs/(59kg)" },
                    { 1074, 29, "Tolyatti, Russia", 9, "Daria", "Female", "5'7\"/(170cm)", "Kasatkina", 913, 74, 25, "137 lbs/(62kg)" },
                    { 1075, 29, "Szeghalom, Hungary", 76, "Anna", "Female", "5'9\"/(175cm)", "Bondar", 913, 75, 28, "137 lbs/(62kg)" },
                    { 1076, 24, "Vienna, Austria", 10, "Sinja", "Female", "5'8\"/(172cm)", "Kraus", 910, 76, 32, "130 lbs/(59kg)" },
                    { 1077, 34, "Poznań, Poland", 140, "Magda", "Female", "5'7\"/(171cm)", "Linette", 908, 77, 21, "130 lbs/(59kg)" },
                    { 1078, 20, "Zagreb, Croatia", 42, "Petra", "Female", "5'9\"/(175cm)", "Marcinko", 905, 78, 30, "132 lbs/(60kg)" },
                    { 1079, 20, "Naples, Florida, USA", 165, "Kaitlin", "Female", "5'7\"/(170cm)", "Quevedo", 902, 79, 23, "128 lbs/(58kg)" },
                    { 1080, 19, "Moscow, Russia", 144, "Alina", "Female", "5'9\"/(175cm)", "Korneeva", 900, 80, 24, "135 lbs/(61kg)" },
                    { 1081, 25, "Taixing, Jiangsu, China", 36, "Xiyu", "Female", "5'11\"/(180cm)", "Wang", 899, 81, 17, "148 lbs/(67kg)" },
                    { 1082, 34, "Zurich, Switzerland", 170, "Viktorija", "Female", "5'7\"/(169cm)", "Golubic", 899, 82, 24, "132 lbs/(60kg)" },
                    { 1083, 28, "Kaposvár, Hungary", 76, "Panna", "Female", "5'7\"/(170cm)", "Udvardy", 899, 83, 31, "132 lbs/(60kg)" },
                    { 1084, 24, "Chanthaburi, Thailand", 174, "Mananchaya", "Female", "5'6\"/(168cm)", "Sawangkaew", 886, 84, 27, "128 lbs/(58kg)" },
                    { 1085, 37, "Tianjin, China", 36, "Shuai", "Female", "5'10\"/(177cm)", "Zhang", 880, 85, 33, "143 lbs/(65kg)" },
                    { 1086, 30, "Hradec Králové, Czech Republic", 45, "Katerina", "Female", "5'9\"/(174cm)", "Siniakova", 865, 86, 18, "150 lbs/(68kg)" },
                    { 1087, 20, "Perth, Australia", 9, "Taylah", "Female", "5'8\"/(172cm)", "Preston", 858, 87, 32, "130 lbs/(59kg)" },
                    { 1088, 19, "Prague, Czech Republic", 45, "Tereza", "Female", "5'10\"/(178cm)", "Valentova", 833, 88, 21, "135 lbs/(61kg)" },
                    { 1089, 30, "Chicago, Illinois, USA", 187, "Taylor", "Female", "5'7\"/(170cm)", "Townsend", 831, 89, 13, "170 lbs/(77kg)" },
                    { 1090, 20, "Grosse Pointe, Michigan, USA", 9, "Maya", "Female", "5'7\"/(170cm)", "Joint", 824, 90, 26, "128 lbs/(58kg)" },
                    { 1091, 23, "Oroslavje, Croatia", 42, "Antonia", "Female", "5'9\"/(175cm)", "Ruzic", 823, 91, 28, "132 lbs/(60kg)" },
                    { 1092, 31, "Montpellier, France", 61, "Leolia", "Female", "5'6\"/(168cm)", "Jeanjean", 816, 92, 28, "130 lbs/(59kg)" },
                    { 1093, 23, "Moscow, Russia", 45, "Darja", "Female", "5'8\"/(173cm)", "Vidmanova", 812, 93, 26, "132 lbs/(60kg)" },
                    { 1094, 29, "Mexico City, Mexico", 111, "Renata", "Female", "5'3\"/(160cm)", "Zarazua", 801, 94, 34, "126 lbs/(57kg)" },
                    { 1095, 26, "Thousand Oaks, California, USA", 187, "Claire", "Female", "5'7\"/(170cm)", "Liu", 789, 95, 25, "130 lbs/(59kg)" },
                    { 1096, 24, "Vilagarcía de Arousa, Spain", 165, "Jessica", "Female", "5'8\"/(173cm)", "Bouzas Maneiro", 769, 96, 29, "134 lbs/(61kg)" },
                    { 1097, 24, "Moscow, Russia", 8, "Alina", "Female", "5'7\"/(170cm)", "Charaeva", 759, 97, 30, "130 lbs/(59kg)" },
                    { 1098, 22, "Lommel, Belgium", 17, "Hanne", "Female", "5'7\"/(170cm)", "Vandewinkel", 756, 98, 28, "128 lbs/(58kg)" },
                    { 1099, 26, "Leeds, United Kingdom", 186, "Francesca", "Female", "5'8\"/(172cm)", "Jones", 752, 99, 26, "132 lbs/(60kg)" },
                    { 1100, 29, "Libreville, Gabon", 61, "Fiona", "Female", "5'7\"/(170cm)", "Ferro", 748, 100, 24, "128 lbs/(58kg)" }
                });

            migrationBuilder.InsertData(
                table: "TournamentVenues",
                columns: new[] { "TournamentId", "VenueId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 },
                    { 16, 16 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "CourtEnvironment", "CourtName", "CourtSurface", "DateTime", "FirstPlayerId", "MatchRound", "MatchStatus", "ScoreResult", "SecondPlayerId", "TournamentId", "VenueId", "WinnerId" },
                values: new object[,]
                {
                    { 1, 1, "Court 1", "Hard", new DateTime(2026, 10, 15, 13, 10, 0, 0, DateTimeKind.Utc), 5, "Quarterfinal", "Completed", "6-4 5-4", 11, 11, 12, 5 },
                    { 2, 1, "Court 2", "Hard", new DateTime(2026, 10, 15, 9, 40, 0, 0, DateTimeKind.Utc), 92, "Quarterfinal", "Completed", "1-4", 44, 11, 12, 44 },
                    { 3, 1, "Centre Court", "Hard", new DateTime(2026, 10, 16, 13, 10, 0, 0, DateTimeKind.Utc), 4, "Quarterfinal", "Completed", "6-3 1-6 6-3", 41, 11, 12, 4 },
                    { 4, 1, "Court 1", "Hard", new DateTime(2026, 10, 16, 9, 40, 0, 0, DateTimeKind.Utc), 91, "Quarterfinal", "Completed", "4-6 6-4 6-3", 8, 11, 12, 91 },
                    { 5, 1, "Centre Court", "Hard", new DateTime(2026, 10, 17, 11, 40, 0, 0, DateTimeKind.Utc), 5, "Semifinal", "Completed", "7-5 4-6 3-6", 44, 11, 12, 44 },
                    { 6, 1, "Court 2", "Hard", new DateTime(2026, 10, 17, 14, 10, 0, 0, DateTimeKind.Utc), 91, "Semifinal", "Completed", "6-3 6-4", 4, 11, 12, 91 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_PlayerId",
                table: "Coaches",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_FirstPlayerId",
                table: "Matches",
                column: "FirstPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SecondPlayerId",
                table: "Matches",
                column: "SecondPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_VenueId",
                table: "Matches",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerId",
                table: "Matches",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CountryId",
                table: "Players",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentVenues_VenueId",
                table: "TournamentVenues",
                column: "VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "TournamentVenues");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

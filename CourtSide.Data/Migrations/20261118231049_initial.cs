using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CourtSide.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TournamentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TournamentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Discipline = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourtSurface = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtEnvironment = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatchFormat = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    TieBreakRule = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Height = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "Courts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courts_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TournamentVenues",
                columns: table => new
                {
                    TournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstPlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondPlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatchRound = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourtSurface = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtEnvironment = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScoreResult = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WinnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Courts_CourtId",
                        column: x => x.CourtId,
                        principalTable: "Courts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("02cd4e92-696f-f50f-440d-ae6fa114a8ec"), "Mali" },
                    { new Guid("02df6b28-fd03-7218-5910-8b859caf1e90"), "Benin" },
                    { new Guid("030a4b3c-9650-a761-143c-b5d512416450"), "Turkey" },
                    { new Guid("034b0186-da17-fa28-0816-c47b7766fba0"), "Ghana" },
                    { new Guid("0401f956-fea7-4ed0-18bf-33d642094729"), "Eritrea" },
                    { new Guid("0411d57e-64c2-95ce-1b39-ae218af18ee1"), "Saint Vincent and the Grenadines" },
                    { new Guid("04ede756-d514-696e-2456-039c4837c19a"), "Saudi Arabia" },
                    { new Guid("0632e4f3-f45f-1685-c723-b5debab46ad7"), "Laos" },
                    { new Guid("063b7b24-142f-988a-d408-cedbf3739f9b"), "Timor-Leste" },
                    { new Guid("09678de0-a810-11e4-8792-4914194808ec"), "Chile" },
                    { new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Czech Republic" },
                    { new Guid("1335982f-2af1-4bd9-856b-4b254b85c23b"), "Bangladesh" },
                    { new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "France" },
                    { new Guid("1384d758-5c6b-a7ca-7500-098a5121ecf4"), "Kuwait" },
                    { new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "China" },
                    { new Guid("1a9916b5-bac9-69ae-5196-7a5988152168"), "Chad" },
                    { new Guid("1f7fdc55-7cab-9257-e3a2-237f741da4b4"), "Israel" },
                    { new Guid("2910aa10-3829-16a5-cd30-d6eef830df08"), "Micronesia" },
                    { new Guid("2a8a5ae7-2982-bc62-86fb-772d5d215cea"), "Seychelles" },
                    { new Guid("2a933e76-a10e-0e19-a673-9c8ec0fc3e6b"), "Panama" },
                    { new Guid("2b615fa4-84c2-8bfb-8031-502bf5f022c9"), "Liberia" },
                    { new Guid("2c6571f7-3e09-9af1-18f1-007fc6a09ba1"), "Somalia" },
                    { new Guid("2cade91f-16fb-f944-82a9-843628e94e32"), "Angola" },
                    { new Guid("2eca314d-8e01-a89b-dc72-9ce4b37901ed"), "Cyprus" },
                    { new Guid("2f775571-d309-3996-349c-9e8b256f89e5"), "South Sudan" },
                    { new Guid("2ffc56a1-8b48-2058-c5ba-73b476366843"), "Côte d'Ivoire" },
                    { new Guid("31065125-4a0a-8226-7ef4-373d232909bb"), "Nepal" },
                    { new Guid("324f36ac-a157-0376-cabf-749cb21f8da4"), "Turkmenistan" },
                    { new Guid("3303b1e1-a815-51fb-de5e-44ca510e189c"), "Slovakia" },
                    { new Guid("3321bad3-eec7-c712-6875-64f821ea4f46"), "Vanuatu" },
                    { new Guid("3354ec5b-2e6c-f880-75fd-d27587980c58"), "Norway" },
                    { new Guid("35543cc1-56e7-9fa1-ba20-73e9cd5bec7c"), "Zambia" },
                    { new Guid("35898a8e-1f4e-9909-16e4-f19eeb20f6af"), "Mozambique" },
                    { new Guid("35c84cb1-05db-6c27-1195-046233e13be5"), "Rwanda" },
                    { new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Argentina" },
                    { new Guid("3821c37b-f4b1-6cf1-ea0c-2d2d44e25600"), "Ecuador" },
                    { new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Australia" },
                    { new Guid("39eeac90-06ea-1fbd-0f45-1dfb5027d658"), "Kenya" },
                    { new Guid("3b497f86-4e54-0171-a87b-29f3324f5bdf"), "Niger" },
                    { new Guid("3b96c728-d343-f8d6-fda5-fc05c21618a7"), "Tuvalu" },
                    { new Guid("3d0073dc-3b6a-2d44-2e74-7df2aa676d9d"), "North Korea" },
                    { new Guid("3d1ce2f9-ba43-9525-4b48-afcd896bb7a4"), "Papua New Guinea" },
                    { new Guid("4050e978-8fd3-368f-aca1-4248e366b6b3"), "Ethiopia" },
                    { new Guid("434d62d9-6339-89ee-0fa2-ba0385c98b47"), "Brunei" },
                    { new Guid("437fc064-51ca-048f-27d3-895df2f365ba"), "Sweden" },
                    { new Guid("494bd034-9519-44a4-05af-41eadce5dc4b"), "Lebanon" },
                    { new Guid("49b0e9c5-b060-55d4-7164-e4c538850f92"), "Djibouti" },
                    { new Guid("4a392f39-ce99-6c69-5984-6d018b8c0150"), "Georgia" },
                    { new Guid("4bc477ac-cee6-ec99-602e-47327725bd93"), "Bahamas" },
                    { new Guid("4c4eec64-a1d4-3de1-2177-139fdc6e755b"), "Uruguay" },
                    { new Guid("4c948dae-5b45-5037-ba9c-977cceab6750"), "Egypt" },
                    { new Guid("4ddf884a-e7a4-ba46-31a9-fa1c7b44500c"), "Trinidad and Tobago" },
                    { new Guid("4decd5d6-b64c-9f4d-185b-d4443500a732"), "Brazil" },
                    { new Guid("4ecc0b9c-72b3-0ac4-6334-9d63e698bf08"), "Paraguay" },
                    { new Guid("50d77856-509b-5356-b628-39b9524c8e86"), "Oman" },
                    { new Guid("52eb80a6-ca53-b044-5291-dd534aafcb5e"), "Guyana" },
                    { new Guid("52fff4c8-4a02-8cff-0161-900bc34e7cc6"), "Nauru" },
                    { new Guid("53fa4969-ca32-0bd3-303b-a9db2ac86f1c"), "Indonesia" },
                    { new Guid("556da8cb-da33-7a7d-d668-fa6ab0aeff6f"), "Eswatini" },
                    { new Guid("55df2aa9-83f5-b024-1ec1-5f8a2df9e24b"), "Belarus" },
                    { new Guid("5742bbcf-4458-5b41-346c-a0aceb814e8e"), "Senegal" },
                    { new Guid("58d2cb88-d692-5b52-0c35-7cd3bb67819b"), "Nicaragua" },
                    { new Guid("5a76cb54-3ce5-28b9-cc2a-3435a71f94b6"), "Dominican Republic" },
                    { new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Italy" },
                    { new Guid("5d9503e5-da9b-1b6f-af16-394b2310e4e4"), "Holy See" },
                    { new Guid("5f096f4b-8929-65de-fd36-db7558756437"), "Germany" },
                    { new Guid("6165486d-2371-1510-d806-5d17165991c1"), "Dominica" },
                    { new Guid("628eeefb-2a3b-3132-2e0e-d39460edff05"), "Vietnam" },
                    { new Guid("62ea4034-bfd0-6f91-38a6-1cb072981e99"), "Jordan" },
                    { new Guid("63e8301a-102e-9527-651a-fafe14c50951"), "Armenia" },
                    { new Guid("66ea5e96-896d-65e8-d2c2-30c67de53fed"), "Comoros" },
                    { new Guid("67282f7d-7a53-e707-ebe7-8448cb23d1d3"), "Guinea" },
                    { new Guid("67aaa934-331b-91ed-5fa4-12e9a6e71580"), "Lithuania" },
                    { new Guid("699d495d-5f2d-2922-c8ae-049043d4f326"), "Bolivia" },
                    { new Guid("6b08eedc-910d-78a4-1686-74bbe3428f53"), "Democratic Republic of the Congo" },
                    { new Guid("6bceeccd-1374-fd7f-d91c-e60a093e07b6"), "Maldives" },
                    { new Guid("6ccc4ce4-a354-3827-6ac4-81d0d122edf1"), "Sudan" },
                    { new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Spain" },
                    { new Guid("6de17520-fdb8-b123-69e6-bf17f4613dde"), "San Marino" },
                    { new Guid("6e1c0409-a38d-8f5d-07ed-e83fd9839bfc"), "Belize" },
                    { new Guid("6e20db1b-a1ea-86e5-8ed2-59eb01b8f091"), "Uzbekistan" },
                    { new Guid("701743a7-417e-25c2-a18a-42cfa7f82daf"), "Nigeria" },
                    { new Guid("708d839c-0311-0f27-23a6-f9b22cf9008e"), "Suriname" },
                    { new Guid("71304549-dfa2-acec-aa49-2be5657ce2ab"), "Bulgaria" },
                    { new Guid("717a1e86-e443-a658-a307-a399e8988dfe"), "Monaco" },
                    { new Guid("719c2faf-0605-0d8a-be2c-2ed2512b702d"), "Malaysia" },
                    { new Guid("71dd9f8e-0ac6-8873-e309-4710e48eeaef"), "Kazakhstan" },
                    { new Guid("72a09b33-a328-a5a7-ca35-5bad85778db8"), "Yemen" },
                    { new Guid("72a8812b-e88c-c3b6-53c2-41dfc273ee55"), "India" },
                    { new Guid("75324c44-0aa6-2886-23fc-b5b13c330752"), "Iran" },
                    { new Guid("75e947b9-1db1-1d25-0590-373f18b725b0"), "Albania" },
                    { new Guid("772b17c4-210d-90dc-1635-aae9eb34f502"), "Mauritania" },
                    { new Guid("7750521e-3be7-187f-df2d-e49ef7e9f275"), "Gabon" },
                    { new Guid("793d6e08-4b5c-1895-d2cf-b3308e19d18e"), "Estonia" },
                    { new Guid("7ac27870-70b7-f619-6b7d-fe3fce0119ab"), "Syria" },
                    { new Guid("7b6e13f1-4041-fc30-0f0c-f9c59ed8cdf4"), "Andorra" },
                    { new Guid("7bb5dc85-2541-0a8b-06fc-3be7deb8094f"), "Afghanistan" },
                    { new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Russia" },
                    { new Guid("7e0578f9-12b8-f138-186a-f2043065af01"), "Cabo Verde" },
                    { new Guid("7ef8ac46-0670-9893-1b52-a6d2ecf85a62"), "Myanmar (Burma)" },
                    { new Guid("7f20a7cc-0aaa-8c85-ee73-b397ed591ef2"), "Burkina Faso" },
                    { new Guid("81549952-2be2-313f-9117-f276a18ecbcc"), "Guinea-Bissau" },
                    { new Guid("8179a68f-5711-7b1d-e014-89084ebbb6f3"), "Haiti" },
                    { new Guid("822b319e-4b4b-a5c1-b0b1-44025fc1f6c7"), "Azerbaijan" },
                    { new Guid("831e03bc-bdbc-0c48-ab88-8c05bd154435"), "Bhutan" },
                    { new Guid("83410ea0-5e0a-76b5-0e4a-bdba5e182585"), "Solomon Islands" },
                    { new Guid("83d3faf7-290a-0aa5-ab53-002c56c7fa43"), "Palestine State" },
                    { new Guid("85030daa-b187-20ac-4b97-81ba33adc5bf"), "South Korea" },
                    { new Guid("8509ac11-f3f9-c65f-538d-466aafce2e26"), "Equatorial Guinea" },
                    { new Guid("8742629d-e1ea-1c3d-5d35-d2886a2978a6"), "Pakistan" },
                    { new Guid("874f6fde-5b5f-3c5a-4b2c-fa72dca72450"), "El Salvador" },
                    { new Guid("8766a659-d8b0-fef0-83d0-7915341a771d"), "Tonga" },
                    { new Guid("89eef427-e7b0-1434-1c39-ad90877fdd4a"), "North Macedonia" },
                    { new Guid("89fa8d38-0138-e506-b39d-9c30a8a73146"), "Netherlands" },
                    { new Guid("8b714b91-782f-d2d8-12ea-b047ab58ed4e"), "Sao Tome and Principe" },
                    { new Guid("8c0d9600-f3cb-6701-02c1-f7d3e2e33751"), "Malawi" },
                    { new Guid("8c72bb01-f139-1b8e-d31f-2520d9c63b98"), "Canada" },
                    { new Guid("8d4a5241-680c-c361-7e7e-0078f4804705"), "Ireland" },
                    { new Guid("8e87e6e7-b38d-7ed7-2b47-fab7d15b0bef"), "Peru" },
                    { new Guid("93055199-47cf-3e0a-2bd8-c126ece743bd"), "Iceland" },
                    { new Guid("96ae7aa1-92fa-1163-7479-1fb2727ee71c"), "Saint Kitts and Nevis" },
                    { new Guid("96aed746-f45c-05ca-f53c-19abaef7b281"), "Slovenia" },
                    { new Guid("97515b37-c2fa-6b91-b3b4-df07b815bdc0"), "Fiji" },
                    { new Guid("97c3ccff-1cca-e766-97c4-b7e8e7f9f1c6"), "Malta" },
                    { new Guid("994884f9-51f3-591d-be60-502cc7abef2c"), "Luxembourg" },
                    { new Guid("99e87dfb-f2ea-12dc-0b5b-ccc99712a908"), "Libya" },
                    { new Guid("a071c251-edb4-8085-fcd6-3dc6ecb08dad"), "Algeria" },
                    { new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Belgium" },
                    { new Guid("a1d65bf8-02d6-df04-ce84-9b614353f054"), "Colombia" },
                    { new Guid("a30fb6a1-48da-8efc-1cfa-c70cf1c30d1d"), "Cambodia" },
                    { new Guid("a4b706d4-f2b0-d6c1-827e-36163f74cb39"), "Antigua and Barbuda" },
                    { new Guid("a5a94fd0-3af9-a186-fbde-1ba8c50f141c"), "Romania" },
                    { new Guid("a9652dc0-ac92-433b-dd92-d6598149823b"), "Mexico" },
                    { new Guid("aaa12cd3-4b12-d434-874e-d5ee1f99397a"), "Austria" },
                    { new Guid("ab149043-0197-42f8-21fc-8d82d569650f"), "Mongolia" },
                    { new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Ukraine" },
                    { new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Poland" },
                    { new Guid("acacea66-2429-4a8a-1ff6-c21ebd65d5ce"), "Cuba" },
                    { new Guid("ad04f235-a5b4-84ef-fea5-0c81750d6db8"), "Greece" },
                    { new Guid("adb0fd75-1c43-25c7-ef84-1949b9a27392"), "Namibia" },
                    { new Guid("aeb3e1f0-0cc4-8dcd-db4d-626e1da8d798"), "Portugal" },
                    { new Guid("aeee815e-f648-88b2-cb54-93e6c9921b10"), "Denmark" },
                    { new Guid("afaf367c-a6f8-8062-58ce-a267ea019eb0"), "Kyrgyzstan" },
                    { new Guid("b011104c-0e25-9420-322f-40eed30b96d5"), "Philippines" },
                    { new Guid("b17223a3-ff40-8c56-3136-e4c95b187f48"), "Switzerland" },
                    { new Guid("b17547c4-388b-c4d0-b04e-0c68f237e2be"), "Central African Republic" },
                    { new Guid("b344a091-8586-4111-74d9-b8ee079eaa02"), "Bahrain" },
                    { new Guid("b7e3cb8a-6042-6b4c-e78f-23e9abfeff50"), "Liechtenstein" },
                    { new Guid("b9168f16-9d17-a908-28f8-727ccafbf3ad"), "Lesotho" },
                    { new Guid("b98c2b1b-82d0-15d4-3ec1-5adac5f856e3"), "Serbia" },
                    { new Guid("ba6dff51-56d1-3943-e5c9-0985e561a870"), "Qatar" },
                    { new Guid("bc9618b2-5e31-be53-774d-31d580708859"), "Latvia" },
                    { new Guid("bcd8f34e-cf9e-0e27-2634-f9fd7641e75d"), "Kiribati" },
                    { new Guid("bf0fbb61-7cc0-0ea6-d8dc-4985981cbd28"), "Burundi" },
                    { new Guid("c4eb5bb0-97a8-b3c1-14bf-02dba2fb1893"), "Finland" },
                    { new Guid("caf7e0b6-cb80-d36a-ef40-08edad595cba"), "Mauritius" },
                    { new Guid("ce3470d1-42f0-ce8c-0137-c272d95ad33e"), "Jamaica" },
                    { new Guid("ce9470a0-8342-648d-cc6f-78d2fcdb58c9"), "Tajikistan" },
                    { new Guid("cf861546-ceeb-93d7-905f-c081eed2dd91"), "New Zealand" },
                    { new Guid("d0972e9a-d72a-78dd-13b8-7b1f37891963"), "Uganda" },
                    { new Guid("d3ff130b-5386-50ad-568a-09890b9fa9b9"), "Hungary" },
                    { new Guid("d5ff4132-0bb3-897e-5d6c-2a327e79afcf"), "Gambia" },
                    { new Guid("d72a2a0d-83b6-d441-c40e-e82e8d57b836"), "Marshall Islands" },
                    { new Guid("d8b5b059-d695-e610-ed34-8f73116b6a19"), "Montenegro" },
                    { new Guid("d9d45239-54ae-585f-d8a9-65188bbd7fe2"), "United Arab Emirates" },
                    { new Guid("da8012e8-6afc-9ec5-9067-3792c8f835c0"), "Saint Lucia" },
                    { new Guid("dd30551f-0c7e-6316-c248-eef7d50ba4d7"), "Moldova" },
                    { new Guid("df9949c3-ebf0-1960-9031-a61ed220417b"), "Morocco" },
                    { new Guid("dfd7c9b0-2e1a-4d30-d08f-a7d46b87e891"), "Costa Rica" },
                    { new Guid("e14ff148-8ede-1b4a-8ffc-c618d8a0d837"), "Singapore" },
                    { new Guid("e18409f3-13cd-03c8-d2ab-5b4a30b93ad8"), "Samoa" },
                    { new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "United Kingdom" },
                    { new Guid("e4f6c47a-df7f-3784-3885-86f86b36c656"), "Venezuela" },
                    { new Guid("e582efa0-f448-9b8e-81ec-140e0759401b"), "Tunisia" },
                    { new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "United States of America" },
                    { new Guid("e5ede489-8b0a-518b-b299-342d9fd2eb28"), "Togo" },
                    { new Guid("e6bfe824-d7f7-f321-3c8f-99b823479846"), "Tanzania" },
                    { new Guid("e79c95e9-66f7-7cb1-2d14-8ddfeaab185e"), "Madagascar" },
                    { new Guid("e7a30774-eb95-2f4f-9ee7-dfe166205c6a"), "Sierra Leone" },
                    { new Guid("e898f629-48c8-5ba8-89ac-8079b4814377"), "Guatemala" },
                    { new Guid("e9c32735-2cab-4595-25af-8ead9b5ccf77"), "Bosnia and Herzegovina" },
                    { new Guid("ebcd6139-e0f8-9c8a-173c-16a54e1d12cf"), "Barbados" },
                    { new Guid("ec81362f-cda4-033b-ab0b-e27d95a3903f"), "South Africa" },
                    { new Guid("ee0d57c9-f60c-b24e-1be2-a76aa645bc22"), "Thailand" },
                    { new Guid("f04d4af9-891d-81e4-842e-950d11d8a76f"), "Zimbabwe" },
                    { new Guid("f09b59c7-ff23-1589-0ce5-ba9e9bccbadc"), "Congo (Brazzaville)" },
                    { new Guid("f10c1873-805a-8efd-4570-4e3acd4bb54a"), "Japan" },
                    { new Guid("f37c8a86-531a-aee7-258c-b49ff571e93f"), "Cameroon" },
                    { new Guid("f53ac03d-f424-20e0-d3ac-50592c435647"), "Palau" },
                    { new Guid("f99aba81-e494-8111-59b1-b8149a9094bd"), "Grenada" },
                    { new Guid("fab102bf-b5f1-1dc9-77c8-88a8f25ec011"), "Botswana" },
                    { new Guid("fafe6ec9-732a-44f2-e128-cf590e7bd447"), "Croatia" },
                    { new Guid("fc0b2577-3c07-68f2-5ad4-e22a59816df4"), "Iraq" },
                    { new Guid("fc398a93-e156-321d-7e2f-0171692a70bb"), "Sri Lanka" },
                    { new Guid("ff1a7a06-47dd-96e8-c309-0024bacaea03"), "Honduras" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CourtEnvironment", "CourtSurface", "Discipline", "EndDate", "Location", "MatchFormat", "StartDate", "TieBreakRule", "TournamentName", "TournamentType" },
                values: new object[,]
                {
                    { new Guid("1aa45a9a-4015-560d-d7c2-f594cf300eab"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Bologna, Italy", 0, new DateTime(2026, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Davis Cup Finals", "ITF Men" },
                    { new Guid("21b75548-50bb-f5a8-3e04-4df9dd776715"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Almaty, Kazakhstan", 0, new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Almaty Open", "ATP 250" },
                    { new Guid("3ba6f36e-30af-72d9-f4e1-b8c540537633"), "Outdoor", "Hard", "Women's singles", new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "New York, USA", 0, new DateTime(2026, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), 1, "US Open", "Grand Slam Women" },
                    { new Guid("4b5fa7f6-1f63-746a-5147-8ba5e549ed4f"), "Outdoor", "Grass", "Men's singles", new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc), "London, United Kingdom", 0, new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Cinch Championships", "ATP 500" },
                    { new Guid("6375b49e-77da-ea35-07cf-d6f9e263edbe"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Turin, Italy", 0, new DateTime(2026, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Nitto Finals", "ATP Finals" },
                    { new Guid("65785e2e-be20-5a3c-3d3f-58aa7ecf99cf"), "Outdoor", "Hard", "Women's singles", new DateTime(2026, 8, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Montreal, Canada", 0, new DateTime(2026, 8, 10, 0, 0, 0, 0, DateTimeKind.Utc), 0, "National Bank Open", "WTA 1000" },
                    { new Guid("66764405-2070-1aa3-032f-59d5bbc2e03f"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Reggio Calabria, Italy", 0, new DateTime(2026, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Next Gen Finals", "ATP Finals" },
                    { new Guid("73f7bad5-fb6b-89c1-d5b4-5026e24b4778"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Basel, Switzerland", 0, new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Swiss Indoors Basel", "ATP 500" },
                    { new Guid("7f89f574-ceff-bb37-dde5-a1445391021a"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Lyon, France", 0, new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Lyon Open", "ATP 250" },
                    { new Guid("7fdfc872-c0aa-8cda-e9ad-768733c7d7d1"), "Outdoor", "Clay", "Men's singles", new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Madrid, Spain", 0, new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Mutua Madrid Open", "ATP 1000" },
                    { new Guid("85223fc0-d5d6-c0fc-a668-1fdb607e915a"), "Outdoor", "Clay", "Women's singles", new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Paris, France", 0, new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Roland Garros", "Grand Slam Women" },
                    { new Guid("878dbd49-9843-c952-f812-cc5fde377431"), "Outdoor", "Grass", "Women's singles", new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Utc), "London, United Kingdom", 0, new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Wimbledon", "Grand Slam Women" },
                    { new Guid("8c9b1e85-f41d-6795-8c87-d61bc14a51c3"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Stockholm, Sweden", 0, new DateTime(2026, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Bybit Stockholm Open", "ATP 250" },
                    { new Guid("913b563c-6c8d-af99-6835-a6b98d790768"), "Outdoor", "Hard", "Women's singles", new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Miami, USA", 0, new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Miami Open", "WTA 1000" },
                    { new Guid("9211f2c5-459b-2574-3e1b-eab2f5dd945f"), "Outdoor", "Hard", "Men's singles", new DateTime(2026, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Melbourne, Australia", 1, new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 1, "Australian Open", "Grand Slam Men" },
                    { new Guid("95225147-8237-4107-6495-22a2b87de875"), "Outdoor", "Hard", "Women's singles", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Doha, Qatar", 0, new DateTime(2026, 2, 8, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Qatar TotalEnergies Open", "WTA 1000" },
                    { new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Brussels, Belgium", 0, new DateTime(2026, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc), 0, "European Open", "ATP 250" },
                    { new Guid("a1596083-41ad-327f-a87a-538e657f4f1c"), "Outdoor", "Hard", "Women's singles", new DateTime(2026, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Beijing, China", 0, new DateTime(2026, 9, 28, 0, 0, 0, 0, DateTimeKind.Utc), 0, "China Open", "WTA 1000" },
                    { new Guid("a6dbadba-13a4-4c1a-77be-b94f0e328bad"), "Outdoor", "Grass", "Women's singles", new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Eastbourne, United Kingdom", 0, new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Rothesay International Eastbourne", "WTA 500" },
                    { new Guid("ab9923f4-66ee-81b4-220b-a5e6781b5bf4"), "Outdoor", "Hard", "Men's singles", new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), "New York, USA", 1, new DateTime(2026, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), 1, "US Open", "Grand Slam Men" },
                    { new Guid("be1bb675-aa94-289a-a381-be545fb9222b"), "Indoor", "Hard", "Men's singles", new DateTime(2026, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Paris, France", 0, new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Rolex Paris Masters", "ATP 1000" },
                    { new Guid("c4677b80-d746-8861-2f25-fd69b9e5b0cd"), "Outdoor", "Hard", "Men's singles", new DateTime(2026, 10, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Shanghai, China", 0, new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Shanghai Masters", "ATP 1000" },
                    { new Guid("c5608612-d979-6e0f-fd0c-0d4676e820f8"), "Outdoor", "Clay", "Men's singles", new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Roquebrune-Cap-Martin, France", 0, new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Monte-Carlo Masters", "ATP 1000" },
                    { new Guid("e9f7a94b-bfe0-3aac-6912-900da822d6cc"), "Outdoor", "Clay", "Men's singles", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Rome, Italy", 0, new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Italian Open", "ATP 1000" },
                    { new Guid("eee5e1a5-fe8a-dea9-d5c0-d67e751592b7"), "Indoor", "Hard", "Women's singles", new DateTime(2026, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Riyadh, Saudi Arabia", 0, new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, "WTA Finals", "WTA Finals" },
                    { new Guid("f881058f-4995-999e-4dc9-b1ac17571219"), "Indoor", "Hard", "Women's singles", new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Lyon, France", 0, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Open 6ème Sens Métropole de Lyon", "WTA 250" },
                    { new Guid("fb38fe7e-51bb-4ace-f719-de15c72f6d69"), "Outdoor", "Hard", "Women's singles", new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Indian Wells, USA", 0, new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Utc), 0, "BNP Paribas Open", "WTA 1000" },
                    { new Guid("fe67857d-f279-1751-fd7b-2e81b27a5d5f"), "Indoor", "Clay", "Women's singles", new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Stuttgart, Germany", 0, new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc), 0, "Porsche Tennis Grand Prix", "WTA 500" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01398289-742d-3688-178d-0b7ac0f3db44"), "Queen's Club" },
                    { new Guid("0a093d19-917e-4a21-972e-b1e89b39416d"), "All England Lawn Tennis and Croquet Club" },
                    { new Guid("19b8a897-43ca-78c6-1405-0a5b63aa02c7"), "Indian Wells Tennis Garden" },
                    { new Guid("1b10f29e-d2d7-4b17-1370-ce61e2826157"), "PalaTennis 'Corrado Barazzutti'" },
                    { new Guid("1d0f7e07-6c4c-2b8b-1631-216839c5fd2e"), "IGA Stadium / Stade IGA" },
                    { new Guid("247d28ed-57e6-07e8-580a-dd4f43548bcd"), "Hard Rock Stadium" },
                    { new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a"), "USTA Billie Jean King National Tennis Center" },
                    { new Guid("28b193c2-afff-79d2-0375-161185f00d6a"), "Monte-Carlo Country Club" },
                    { new Guid("3248537d-9728-1dda-efd3-5d6baedcff40"), "Estadio La Cartuja" },
                    { new Guid("4240c5f1-47f3-8993-9f84-c34f886a8fa8"), "Unipol Arena" },
                    { new Guid("4525054a-483d-f44f-f772-addd74b9daeb"), "King Saud University Indoor Arena" },
                    { new Guid("4802b018-5151-da85-21a6-4be35a67fd85"), "Almaty Arena" },
                    { new Guid("66eabd34-a820-bb37-c757-4081b5dc4f39"), "Palais des Sports de Gerland" },
                    { new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), "Lotto Arena" },
                    { new Guid("812c72e4-2f62-6626-265e-4e26c1b40174"), "Inalpi Arena" },
                    { new Guid("8b5b88b3-8c2f-f2fe-ae8b-b3c8ed532cd8"), "Melbourne Park" },
                    { new Guid("8b9928a7-30eb-959c-3878-24bf034406cd"), "Khalifa International Tennis & Squash Complex" },
                    { new Guid("9c712670-3363-37fa-3a4e-237e22c90951"), "Porsche-Arena" },
                    { new Guid("b2026a06-3e90-7c25-b97e-ae3cff9975a5"), "LDLC Arena" },
                    { new Guid("b46bf0d7-9420-f9bb-8cb7-551b28e533e9"), "St. Jakobshalle" },
                    { new Guid("dbd84836-dd9d-2a5e-0f03-5df858ea8851"), "National Tennis Center" },
                    { new Guid("dcbca76e-1aa3-cd66-7d38-6b547fb207f4"), "Kungliga Tennishallen" },
                    { new Guid("e901ac40-4167-6ed4-33c5-38adef64d6aa"), "Caja Mágica" },
                    { new Guid("ee8e8214-bff6-9fea-66bc-83713f1781ec"), "Stade Roland Garros" },
                    { new Guid("efa8e236-d522-f001-fc5a-ebd68c1ca1b4"), "Devonshire Park Lawn Tennis Club" },
                    { new Guid("f4e815bd-2c5a-8a71-e0d2-deb6e4180f28"), "Qizhong Forest Sports City Arena" },
                    { new Guid("fd8a4796-4b11-af79-77ff-367a3a157017"), "Paris La Défense Arena" },
                    { new Guid("fed03ef4-494e-b021-1973-2389bd8f283e"), "Foro Italico" }
                });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "Name", "VenueId" },
                values: new object[,]
                {
                    { new Guid("066ef2e1-c09a-5ac6-686d-865fd7d9aaef"), "Center Court", new Guid("4525054a-483d-f44f-f772-addd74b9daeb") },
                    { new Guid("08ae1a86-2ae3-1d62-8721-65520137a629"), "Centre Court", new Guid("66eabd34-a820-bb37-c757-4081b5dc4f39") },
                    { new Guid("0ba87dde-f6c7-a158-0f10-734609e77f75"), "Court Philippe-Chatrier", new Guid("ee8e8214-bff6-9fea-66bc-83713f1781ec") },
                    { new Guid("0dfbb3d7-831d-de9f-c878-0c3e5ce3b42d"), "No. 2 Court", new Guid("0a093d19-917e-4a21-972e-b1e89b39416d") },
                    { new Guid("0fd01a0e-2f44-933d-794a-c192f0720339"), "Grandstand", new Guid("247d28ed-57e6-07e8-580a-dd4f43548bcd") },
                    { new Guid("10e97bab-ac6a-2e4a-aea8-8d774e832253"), "Centre Court", new Guid("4240c5f1-47f3-8993-9f84-c34f886a8fa8") },
                    { new Guid("159cb66a-ea50-f091-98ec-65577c960527"), "Arantxa Sánchez Vicario Stadium", new Guid("e901ac40-4167-6ed4-33c5-38adef64d6aa") },
                    { new Guid("1f609712-4b54-d2fb-ccaf-04d26f2c2ef9"), "Court 1", new Guid("efa8e236-d522-f001-fc5a-ebd68c1ca1b4") },
                    { new Guid("221bd6e9-d4f8-c96c-7369-f3da518a65d6"), "Pietrangeli", new Guid("fed03ef4-494e-b021-1973-2389bd8f283e") },
                    { new Guid("24b9c7b4-0ef5-aa8d-2fc7-2c571ed939ab"), "Rod Laver Arena", new Guid("8b5b88b3-8c2f-f2fe-ae8b-b3c8ed532cd8") },
                    { new Guid("274c98b0-10b2-47bd-6f22-0a4a434165e9"), "Moon Court", new Guid("dbd84836-dd9d-2a5e-0f03-5df858ea8851") },
                    { new Guid("29de55c9-f880-2bf7-19e8-df08c2ffbd29"), "John Cain Arena", new Guid("8b5b88b3-8c2f-f2fe-ae8b-b3c8ed532cd8") },
                    { new Guid("30dce0a5-3b5d-e69d-9bc8-8e3e33f5a102"), "Grandstand", new Guid("f4e815bd-2c5a-8a71-e0d2-deb6e4180f28") },
                    { new Guid("3340272b-1a10-51d1-e16c-7c7bcf897d26"), "Stadium 3", new Guid("e901ac40-4167-6ed4-33c5-38adef64d6aa") },
                    { new Guid("360bc4f3-a086-bcc4-1dbe-3d64aa4c2b08"), "Grandstand Arena", new Guid("fed03ef4-494e-b021-1973-2389bd8f283e") },
                    { new Guid("3c004f5a-2baa-39b4-4091-6fd41518f9f6"), "Court Central", new Guid("fd8a4796-4b11-af79-77ff-367a3a157017") },
                    { new Guid("3c9d581b-3553-d7fe-bcf0-9242493f9fb0"), "Centre Court", new Guid("dcbca76e-1aa3-cd66-7d38-6b547fb207f4") },
                    { new Guid("40e92c37-6fb9-8008-0593-96370b6c46e3"), "Court 1", new Guid("4802b018-5151-da85-21a6-4be35a67fd85") },
                    { new Guid("51a4fdc8-3e97-e972-dd17-b23d1e76d2f1"), "Grandstand 1", new Guid("8b9928a7-30eb-959c-3878-24bf034406cd") },
                    { new Guid("520433f6-ca5b-0675-a4a7-dbe3a7560d3d"), "Stadium 1", new Guid("19b8a897-43ca-78c6-1405-0a5b63aa02c7") },
                    { new Guid("58e31634-c50f-7708-877f-3ced925d93ce"), "Manolo Santana Stadium", new Guid("e901ac40-4167-6ed4-33c5-38adef64d6aa") },
                    { new Guid("5d3256f6-b0a8-812c-44a7-9db8b10a6015"), "Louis Armstrong Stadium", new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a") },
                    { new Guid("6815f6a7-a27e-a785-dc81-0c23cc04475f"), "Court 1", new Guid("b46bf0d7-9420-f9bb-8cb7-551b28e533e9") },
                    { new Guid("6b61d437-70db-ef38-ae29-2287922c3b4a"), "Court 17", new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a") },
                    { new Guid("6d535bc9-e84b-ee4f-4c5c-10ebb00b50c2"), "Kia Arena", new Guid("8b5b88b3-8c2f-f2fe-ae8b-b3c8ed532cd8") },
                    { new Guid("7218ae1b-cc4a-90c8-621e-ad08c29fb6e3"), "Margaret Court Arena", new Guid("8b5b88b3-8c2f-f2fe-ae8b-b3c8ed532cd8") },
                    { new Guid("7a6d3933-8afc-e318-0bc5-576022f834d4"), "Centre Court", new Guid("8b9928a7-30eb-959c-3878-24bf034406cd") },
                    { new Guid("7c63895d-cdaf-d9b9-4c58-939a206c63da"), "Centre Court", new Guid("0a093d19-917e-4a21-972e-b1e89b39416d") },
                    { new Guid("82a88caa-d02a-f588-e263-fcb892a30e94"), "No. 3 Court", new Guid("0a093d19-917e-4a21-972e-b1e89b39416d") },
                    { new Guid("82b22f96-9416-7c8e-ac08-430308ab6d92"), "Court 1", new Guid("fd8a4796-4b11-af79-77ff-367a3a157017") },
                    { new Guid("901a7e52-ae71-bb91-83e9-cbcf06d10dbc"), "Lotus Court", new Guid("dbd84836-dd9d-2a5e-0f03-5df858ea8851") },
                    { new Guid("9187f722-09e7-d15b-3429-324c543b5b06"), "No. 1 Court", new Guid("0a093d19-917e-4a21-972e-b1e89b39416d") },
                    { new Guid("96cc294e-348a-c317-c61f-c035977a53af"), "Stadium Court", new Guid("247d28ed-57e6-07e8-580a-dd4f43548bcd") },
                    { new Guid("9c608ae4-e4bb-c812-4e21-523865bb56b4"), "Stadium 2", new Guid("19b8a897-43ca-78c6-1405-0a5b63aa02c7") },
                    { new Guid("9f541f9f-de08-5439-e273-92aec834de82"), "National Bank Court", new Guid("1d0f7e07-6c4c-2b8b-1631-216839c5fd2e") },
                    { new Guid("a06222a1-2114-03ef-2b9e-b46ab3373926"), "Court Simonne-Mathieu", new Guid("ee8e8214-bff6-9fea-66bc-83713f1781ec") },
                    { new Guid("a16267dd-c8ff-1885-6dc9-e76dc900af05"), "Campo Centrale", new Guid("fed03ef4-494e-b021-1973-2389bd8f283e") },
                    { new Guid("a216b45b-cb41-23c6-8752-1ba22a4f9613"), "Centre Court", new Guid("efa8e236-d522-f001-fc5a-ebd68c1ca1b4") },
                    { new Guid("a3ea1ced-850b-c859-f6b3-ff094ef3f41c"), "Centre Court", new Guid("1b10f29e-d2d7-4b17-1370-ce61e2826157") },
                    { new Guid("aa06fba9-5abd-a4e7-7b12-6f44fb3c51c0"), "Court 1", new Guid("01398289-742d-3688-178d-0b7ac0f3db44") },
                    { new Guid("b2cf4329-cb3b-90f4-68c1-7a3a18ef3201"), "Centre Court", new Guid("b46bf0d7-9420-f9bb-8cb7-551b28e533e9") },
                    { new Guid("b4187f9c-afe9-7944-3b3c-6f431aae8db1"), "Diamond Court", new Guid("dbd84836-dd9d-2a5e-0f03-5df858ea8851") },
                    { new Guid("b6d2527c-83b2-a58c-b226-91e2f19b74c1"), "Center Court", new Guid("f4e815bd-2c5a-8a71-e0d2-deb6e4180f28") },
                    { new Guid("bb2c1f2f-e1b8-c172-8d87-220e378e9180"), "Center Court", new Guid("4802b018-5151-da85-21a6-4be35a67fd85") },
                    { new Guid("c6a6f263-1666-9d87-58e1-93dc2fab9c30"), "Court Rainier III", new Guid("28b193c2-afff-79d2-0375-161185f00d6a") },
                    { new Guid("c7c8a1ea-94cd-ad7c-4261-67b5727f45b1"), "Grandstand", new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a") },
                    { new Guid("c8814727-671a-8e79-748c-9af3a3a723a8"), "Centre Court", new Guid("9c712670-3363-37fa-3a4e-237e22c90951") },
                    { new Guid("cdfd9bda-afd8-b1e0-590b-b04166996175"), "Arthur Ashe Stadium", new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a") },
                    { new Guid("e39915cb-f835-11dd-81dd-83a447f92add"), "Centre Court", new Guid("01398289-742d-3688-178d-0b7ac0f3db44") },
                    { new Guid("e9a2d4c9-7404-f05b-8497-5dfdc3ad5b07"), "Court 1", new Guid("66eabd34-a820-bb37-c757-4081b5dc4f39") },
                    { new Guid("eab87777-d8b6-a2c8-f387-041a8f780f34"), "Court Central", new Guid("1d0f7e07-6c4c-2b8b-1631-216839c5fd2e") },
                    { new Guid("f039dd4a-a2da-b0f1-e779-e461e97760b1"), "Court Suzanne-Lenglen", new Guid("ee8e8214-bff6-9fea-66bc-83713f1781ec") },
                    { new Guid("f394515f-52bd-d78b-6749-8fc6b635e17b"), "Stadium 3", new Guid("19b8a897-43ca-78c6-1405-0a5b63aa02c7") },
                    { new Guid("f42322f1-dbcb-c4e6-6e2e-8b6d7c9414ef"), "Centre Court", new Guid("812c72e4-2f62-6626-265e-4e26c1b40174") },
                    { new Guid("f4b8640e-7d43-5574-b595-da49a4719275"), "Court Des Princes", new Guid("28b193c2-afff-79d2-0375-161185f00d6a") },
                    { new Guid("f7c3eb67-97eb-a7f3-03d0-e6ec529a0365"), "Centre Court", new Guid("3248537d-9728-1dda-efd3-5d6baedcff40") },
                    { new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Center Court", new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9") }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Birthplace", "CountryId", "FirstName", "Gender", "Height", "LastName", "Points", "Rank", "TournamentsPlayed", "Weight" },
                values: new object[,]
                {
                    { new Guid("01cd2833-4709-690b-40d3-b63fea79cc05"), 23, "Copenhagen, Denmark", new Guid("aeee815e-f648-88b2-cb54-93e6c9921b10"), "Clara", "Female", "6'0\"/(182cm)", "Tauson", 1074, 54, 24, "150 lbs/(68kg)" },
                    { new Guid("033535aa-9abb-8093-3a14-d013333fcfd2"), 24, "Moscow, Russia", new Guid("63e8301a-102e-9527-651a-fafe14c50951"), "Alina", "Female", "5'7\"/(170cm)", "Charaeva", 759, 97, 30, "130 lbs/(59kg)" },
                    { new Guid("03c2ca4c-136f-9a73-ecbe-8e943099b523"), 23, "Novi Pazar, Serbia", new Guid("b98c2b1b-82d0-15d4-3ec1-5adac5f856e3"), "Hamad", "Male", "6'2\"/(188cm)", "Medjedovic", 751, 78, 19, "190 lbs/(86kg)" },
                    { new Guid("06f2fdbb-40c6-dd02-d4b9-8dbae368441d"), 24, "Sutton, London, United Kingdom", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Jack", "Male", "6'4\"/(193cm)", "Draper", 360, 157, 17, "187 lbs/(85kg)" },
                    { new Guid("07a2a155-37fe-2e65-5814-996fd39df5fe"), 20, "Naples, Florida, USA", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Kaitlin", "Female", "5'7\"/(170cm)", "Quevedo", 902, 79, 23, "128 lbs/(58kg)" },
                    { new Guid("09943bf5-f412-57c6-12d7-81dc3c45ebb0"), 24, "Jakarta, Indonesia", new Guid("53fa4969-ca32-0bd3-303b-a9db2ac86f1c"), "Janice", "Female", "5'6\"/(168cm)", "Tjen", 1120, 46, 29, "130 lbs/(59kg)" },
                    { new Guid("09f0ef53-b3bd-0bb3-95d7-94d1d6ff2e72"), 22, "Madrid, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Daniel", "Male", "6'1\"/(185cm)", "Merida", 1195, 40, 28, "165 lbs/(75kg)" },
                    { new Guid("0b60b537-9557-ce79-b1b0-5d7906e3a677"), 25, "Atlanta, Georgia, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Alycia", "Female", "6'1\"/(185cm)", "Parks", 985, 64, 36, "143 lbs/(65kg)" },
                    { new Guid("0c23c701-d7e9-07c6-8324-18e3cc6ade61"), 25, "Villeneuve-Saint-Georges, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Titouan", "Male", "6'3\"/(191cm)", "Droguet", 801, 72, 21, "176 lbs/(80kg)" },
                    { new Guid("0cef4f8a-ac1b-38a7-3078-9e63b6e10fd4"), 20, "Grosse Pointe, Michigan, USA", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Maya", "Female", "5'7\"/(170cm)", "Joint", 824, 90, 26, "128 lbs/(58kg)" },
                    { new Guid("0e1328df-eec6-be7f-8f5f-c07a7a01512f"), 27, "Budapest, Hungary", new Guid("d3ff130b-5386-50ad-568a-09890b9fa9b9"), "Fabian", "Male", "6'4\"/(193cm)", "Marozsan", 860, 61, 21, "165 lbs/(75kg)" },
                    { new Guid("0ed2a638-b982-d12b-d4c2-cb098374eb8a"), 24, "Buenos Aires, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Roman Andres", "Male", "6'0\"/(183cm)", "Burruchaga", 765, 53, 22, "170 lbs/(77kg)" },
                    { new Guid("0f431394-a311-1b79-a428-8ab2a4f862d0"), 28, "Split, Croatia", new Guid("fafe6ec9-732a-44f2-e128-cf590e7bd447"), "Borna", "Male", "6'5\"/(196cm)", "Gojo", 416, 135, 16, "187 lbs/(85kg)" },
                    { new Guid("1025dd50-949e-60a6-490f-88fc55f54d39"), 24, "Montreal, Canada", new Guid("8c72bb01-f139-1b8e-d31f-2520d9c63b98"), "Leylah", "Female", "5'6\"/(168cm)", "Fernandez", 1709, 30, 28, "128 lbs/(58kg)" },
                    { new Guid("114bbdd6-4f74-cd7e-531d-69182830407b"), 29, "Flawil, Switzerland", new Guid("b17223a3-ff40-8c56-3136-e4c95b187f48"), "Belinda", "Female", "5'9\"/(175cm)", "Bencic", 2662, 14, 18, "139 lbs/(63kg)" },
                    { new Guid("13781780-3e57-b533-1fb1-6d9044665c48"), 33, "Thousand Oaks, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Marcos", "Male", "5'11\"/(180cm)", "Giron", 676, 87, 25, "160 lbs/(73kg)" },
                    { new Guid("1379389d-87ed-7acf-2b2b-76423612ee2c"), 33, "New York, New York, USA", new Guid("f10c1873-805a-8efd-4570-4e3acd4bb54a"), "Taro", "Male", "6'3\"/(191cm)", "Daniel", 321, 177, 21, "170 lbs/(77kg)" },
                    { new Guid("14856f1e-6e21-29bf-7691-b0fb90e8c35d"), 18, "Torrance, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Iva", "Female", "5'8\"/(173cm)", "Jovic", 2931, 12, 22, "130 lbs/(59kg)" },
                    { new Guid("14ac1767-bd99-b7ab-f069-043392dfeffe"), 22, "Hong Kong, China", new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "Coleman", "Male", "6'3\"/(191cm)", "Wong", 645, 92, 24, "176 lbs/(80kg)" },
                    { new Guid("15fb5971-3fe8-f9a3-5a22-270ff5a0d61b"), 21, "Antwerp, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Alexander", "Male", "6'3\"/(191cm)", "Blockx", 1790, 21, 21, "179 lbs/(81kg)" },
                    { new Guid("166dcb17-c8e1-fbb6-f131-60e105a74635"), 29, "Santanyi, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Jaume", "Male", "6'0\"/(183cm)", "Munar", 835, 66, 22, "165 lbs/(75kg)" },
                    { new Guid("178b887c-29de-d1c4-5de3-d08634fd02c3"), 23, "Lyon, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Giovanni", "Male", "6'8\"/(203cm)", "Mpetshi Perricard", 385, 146, 18, "216 lbs/(98kg)" },
                    { new Guid("180acba2-2517-1ddf-1c20-17b8ec35f7e8"), 25, "Buenos Aires, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Sebastian", "Male", "5'7\"/(170cm)", "Baez", 1044, 48, 24, "154 lbs/(70kg)" },
                    { new Guid("1c7fd1ac-f4bd-2028-cf8d-ddd7cd3fe6fa"), 28, "Rancho Santa Fe, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Taylor", "Male", "6'5\"/(196cm)", "Fritz", 2830, 13, 22, "185 lbs/(84kg)" },
                    { new Guid("1f7a0998-b142-5682-d75a-4e1f3011c2cf"), 24, "Chanthaburi, Thailand", new Guid("ee0d57c9-f60c-b24e-1be2-a76aa645bc22"), "Mananchaya", "Female", "5'6\"/(168cm)", "Sawangkaew", 886, 84, 27, "128 lbs/(58kg)" },
                    { new Guid("1ff0bf2a-71da-a4f9-8bd1-8439c78c16b8"), 27, "La Plata, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Tomas Martin", "Male", "6'5\"/(196cm)", "Etcheverry", 1565, 29, 25, "181 lbs/(82kg)" },
                    { new Guid("20812449-6b03-3428-5df0-36ddd7975aa3"), 22, "Spring, Texas, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Ashlyn", "Female", "6'1\"/(185cm)", "Krueger", 1072, 55, 23, "143 lbs/(65kg)" },
                    { new Guid("227a4573-b90a-aec7-1e53-96f4a9bfb7ff"), 25, "Dąbrowa Górnicza, Poland", new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Maja", "Female", "5'5\"/(165cm)", "Chwalinska", 3031, 11, 22, "128 lbs/(58kg)" },
                    { new Guid("233e3183-55ba-9151-4d1e-7bc38fb05926"), 35, "Rocourt, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "David", "Male", "5'11\"/(180cm)", "Goffin", 730, 80, 23, "150 lbs/(68kg)" },
                    { new Guid("24473dea-3249-f23f-44ca-0bbc5a665ad6"), 22, "Perth, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Talia", "Female", "5'9\"/(175cm)", "Gibson", 1273, 42, 31, "135 lbs/(61kg)" },
                    { new Guid("25298752-2a35-960f-6ec8-11e85558fcd0"), 29, "Voorhees, New Jersey, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Tommy", "Male", "6'1\"/(185cm)", "Paul", 2625, 14, 22, "180 lbs/(82kg)" },
                    { new Guid("26f96264-3feb-1f9a-1cf1-adb64ef8b9fe"), 18, "Lienz, Austria", new Guid("aaa12cd3-4b12-d434-874e-d5ee1f99397a"), "Lilli", "Female", "5'9\"/(175cm)", "Tagger", 1052, 57, 22, "130 lbs/(59kg)" },
                    { new Guid("28e63e7c-60bd-4e5a-497c-3a7b1d9fabf0"), 26, "Thousand Oaks, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Claire", "Female", "5'7\"/(170cm)", "Liu", 789, 95, 25, "130 lbs/(59kg)" },
                    { new Guid("2aa029fb-c53d-b9cc-9c47-32a1c3ef7a67"), 22, "Delray Beach, Florida, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Coco", "Female", "5'9\"/(175cm)", "Gauff", 5974, 5, 19, "141 lbs/(64kg)" },
                    { new Guid("2b2adf51-269b-770e-bbb5-179faf103d4e"), 23, "Lisbon, Portugal", new Guid("aeb3e1f0-0cc4-8dcd-db4d-626e1da8d798"), "Jaime", "Male", "6'1\"/(185cm)", "Faria", 960, 44, 25, "170 lbs/(77kg)" },
                    { new Guid("2cffc646-d79c-c187-fe74-596057eeef4b"), 30, "Leicester, United Kingdom", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Katie", "Female", "5'11\"/(180cm)", "Boulter", 1042, 58, 23, "137 lbs/(62kg)" },
                    { new Guid("2d8007c5-a721-72d4-66b5-1fc634aba712"), 24, "Boulogne-sur-Mer, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Terence", "Male", "6'4\"/(193cm)", "Atmane", 612, 98, 25, "181 lbs/(82kg)" },
                    { new Guid("2f0ff947-02ad-998d-bc8f-89ac386c565d"), 22, "Nakhon Ratchasima, Thailand", new Guid("ee0d57c9-f60c-b24e-1be2-a76aa645bc22"), "Lanlana", "Female", "5'8\"/(173cm)", "Tararudee", 1080, 53, 28, "132 lbs/(60kg)" },
                    { new Guid("31bb326a-b097-9fbe-95d7-368ae7cea6dc"), 26, "Leeds, United Kingdom", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Francesca", "Female", "5'8\"/(172cm)", "Jones", 752, 99, 26, "132 lbs/(60kg)" },
                    { new Guid("329be20f-7f3a-7dc9-40d8-ab7ca67cdccf"), 31, "Hamburg, Germany", new Guid("5f096f4b-8929-65de-fd36-db7558756437"), "Tamara", "Female", "5'7\"/(170cm)", "Korpatsch", 1070, 56, 33, "128 lbs/(58kg)" },
                    { new Guid("32af4a9f-1702-cd66-f644-1946e1bc51ce"), 22, "Woluwe-Saint-Lambert, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Luca", "Male", "5'10\"/(178cm)", "Van Assche", 1080, 47, 24, "158 lbs/(72kg)" },
                    { new Guid("34fde92f-9e0c-cc68-3194-710d8379da76"), 30, "Olomouc, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Karolina", "Female", "5'11\"/(180cm)", "Muchova", 4833, 7, 19, "141 lbs/(64kg)" },
                    { new Guid("3592db62-52af-66c8-e8d0-cf259477b46f"), 22, "Lima, Peru", new Guid("8e87e6e7-b38d-7ed7-2b47-fab7d15b0bef"), "Ignacio", "Male", "6'0\"/(183cm)", "Buse", 1445, 31, 22, "165 lbs/(75kg)" },
                    { new Guid("35b89880-16a7-289c-5b4e-477de59d0cd2"), 27, "Moscow, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Pavel", "Male", "6'4\"/(193cm)", "Kotov", 339, 169, 22, "185 lbs/(84kg)" },
                    { new Guid("3632c6ea-9e70-3321-7d88-e95620541c17"), 35, "Podgorica, Montenegro", new Guid("8c72bb01-f139-1b8e-d31f-2520d9c63b98"), "Milos", "Male", "6'5\"/(196cm)", "Raonic", 695, 83, 12, "216 lbs/(98kg)" },
                    { new Guid("36dab34b-7903-70a1-edf3-ee54ba19f33a"), 23, "Gentofte, Denmark", new Guid("aeee815e-f648-88b2-cb54-93e6c9921b10"), "Holger", "Male", "6'2\"/(188cm)", "Rune", 2850, 194, 23, "170 lbs/(77kg)" },
                    { new Guid("3aac233c-74a9-3b41-765c-ce1d4a40a5c0"), 28, "Minsk, Belarus", new Guid("55df2aa9-83f5-b024-1ec1-5f8a2df9e24b"), "Aryna", "Female", "6'0\"/(182cm)", "Sabalenka", 7550, 2, 20, "176 lbs/(80kg)" },
                    { new Guid("3c3266f2-f9dd-2915-81d9-6b74c175dab1"), 28, "Hyattsville, Maryland, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Frances", "Male", "6'2\"/(188cm)", "Tiafoe", 3380, 8, 24, "190 lbs/(86kg)" },
                    { new Guid("404e64a0-0b4d-ac06-e1ce-5179f2f4d86f"), 30, "Piotrkow Trybunalski, Poland", new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Kamil", "Male", "5'11\"/(180cm)", "Majchrzak", 722, 55, 21, "172 lbs/(78kg)" },
                    { new Guid("405d4687-4353-2c4e-cdb9-087e54337ee3"), 24, "Villa Gesell, Argentina", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Luciano", "Male", "6'1\"/(185cm)", "Darderi", 2160, 23, 26, "172 lbs/(78kg)" },
                    { new Guid("40965ba9-defe-6d07-c908-16ef6cf27ac1"), 24, "Nice, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Diane", "Female", "5'7\"/(170cm)", "Parry", 1549, 34, 27, "132 lbs/(60kg)" },
                    { new Guid("42c8b4f8-7261-174c-40fa-f8c86a11995b"), 20, "Charlotte, North Carolina, USA", new Guid("8c72bb01-f139-1b8e-d31f-2520d9c63b98"), "Victoria", "Female", "5'9\"/(176cm)", "Mboko", 2501, 16, 16, "143 lbs/(65kg)" },
                    { new Guid("45c14476-589d-e6c1-e769-1b7c2df7d980"), 30, "Moscow, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Karen", "Male", "6'6\"/(198cm)", "Khachanov", 2005, 24, 22, "192 lbs/(87kg)" },
                    { new Guid("4852a53d-a55c-4f81-e414-63f459aa2724"), 26, "Reims, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Clément", "Male", "5'8\"/(173cm)", "Tabur", 355, 160, 22, "160 lbs/(73kg)" },
                    { new Guid("4c0924b1-ddbf-9000-b3cb-e3b7a8ab0736"), 30, "Cairo, Egypt", new Guid("4c948dae-5b45-5037-ba9c-977cceab6750"), "Mayar", "Female", "5'11\"/(180cm)", "Sherif", 1085, 52, 27, "137 lbs/(62kg)" },
                    { new Guid("4c17c5d0-99f1-a3f1-3a01-069e82f10b1e"), 22, "Lommel, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Hanne", "Female", "5'7\"/(170cm)", "Vandewinkel", 756, 98, 28, "128 lbs/(58kg)" },
                    { new Guid("4e59b16e-d221-bb2d-dbd2-9b8e9247ff1c"), 24, "Sèvres, France", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Arthur", "Male", "5'9\"/(175cm)", "Féry", 1406, 33, 19, "165 lbs/(75kg)" },
                    { new Guid("4f78c945-fdb0-a732-19e9-15fe95b5a30a"), 36, "Santiago del Estero, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Marco", "Male", "5'11\"/(180cm)", "Trungelliti", 672, 57, 24, "165 lbs/(75kg)" },
                    { new Guid("5021c9e1-5bff-2345-92e9-59e2462ed91a"), 28, "Prague, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Marie", "Female", "5'11\"/(180cm)", "Bouzkova", 1818, 26, 23, "134 lbs/(61kg)" },
                    { new Guid("532828a9-f83f-e29d-f49e-f56fd46deeb9"), 30, "Moscow, Russia", new Guid("717a1e86-e443-a658-a307-a399e8988dfe"), "Daniil", "Male", "6'6\"/(198cm)", "Medvedev", 3620, 5, 21, "183 lbs/(83kg)" },
                    { new Guid("58951034-1b8f-4001-cb8e-d41327c85c22"), 31, "Gassin, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Arthur", "Male", "6'5\"/(196cm)", "Rinderknech", 870, 60, 25, "187 lbs/(85kg)" },
                    { new Guid("59bfa265-91e9-9c89-7761-81a1cf88f34a"), 32, "Buffalo, New York, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Jessica", "Female", "5'7\"/(170cm)", "Pegula", 6235, 4, 19, "154 lbs/(70kg)" },
                    { new Guid("5ef85fe6-9730-2596-6495-174a30f2916c"), 30, "Adelaide, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Thanasi", "Male", "6'4\"/(193cm)", "Kokkinakis", 760, 75, 20, "185 lbs/(84kg)" },
                    { new Guid("628ec3e3-1826-098c-a278-d1383635d32e"), 21, "Vsetín, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Linda", "Female", "5'10\"/(179cm)", "Noskova", 4678, 8, 19, "143 lbs/(65kg)" },
                    { new Guid("62efe32c-4d1e-e691-9ecb-fd5f99249493"), 21, "Quezon City, Philippines", new Guid("b011104c-0e25-9420-322f-40eed30b96d5"), "Alexandra", "Female", "5'9\"/(175cm)", "Eala", 2241, 20, 28, "132 lbs/(60kg)" },
                    { new Guid("64463e3f-a727-cf17-2035-825f925d1785"), 29, "Chuo-ku, Osaka, Japan", new Guid("f10c1873-805a-8efd-4570-4e3acd4bb54a"), "Naomi", "Female", "5'11\"/(180cm)", "Osaka", 2297, 19, 18, "152 lbs/(69kg)" },
                    { new Guid("646bbb26-5fd9-7078-1b17-057c2c3c7d56"), 27, "Malaga, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Alejandro", "Male", "6'0\"/(183cm)", "Davidovich Fokina", 2610, 15, 23, "176 lbs/(80kg)" },
                    { new Guid("657ed5ef-6461-43c1-bc55-ee4fdb331014"), 38, "Soisy-sous-Montmorency, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Adrian", "Male", "6'0\"/(183cm)", "Mannarino", 783, 73, 27, "174 lbs/(79kg)" },
                    { new Guid("67bd1be1-e7db-ad71-871b-de84d228422f"), 23, "Moscow, Russia", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Darja", "Female", "5'8\"/(173cm)", "Vidmanova", 812, 93, 26, "132 lbs/(60kg)" },
                    { new Guid("6bab745d-2388-f2e5-79e0-4e5a5fd69f0f"), 26, "Bradenton, Florida, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Sebastian", "Male", "6'5\"/(196cm)", "Korda", 730, 81, 18, "175 lbs/(79kg)" },
                    { new Guid("6fc474fa-f6e4-95c7-bd53-52877fbb4280"), 29, "Podolsk, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Roman", "Male", "6'1\"/(185cm)", "Safiullin", 807, 69, 22, "172 lbs/(78kg)" },
                    { new Guid("700ad3fc-5367-4bf1-43c8-dc14bbba0b4b"), 20, "Hrušovany nad Jevišovkou, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Sara", "Female", "5'5\"/(165cm)", "Bejlek", 1650, 32, 25, "125 lbs/(57kg)" },
                    { new Guid("71c2c435-0a30-5a50-f401-df86e253e265"), 27, "Oslo, Norway", new Guid("3354ec5b-2e6c-f880-75fd-d27587980c58"), "Casper", "Male", "6'0\"/(183cm)", "Ruud", 1995, 25, 25, "178 lbs/(81kg)" },
                    { new Guid("7214e7d9-cb02-d983-8e9a-8b0bdee06fd0"), 30, "Brno, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Barbora", "Female", "5'10\"/(178cm)", "Krejcikova", 1133, 45, 20, "137 lbs/(62kg)" },
                    { new Guid("72ceb91c-a514-9937-a3e4-0f0a0bc79f69"), 34, "Sydney, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "James", "Male", "6'0\"/(183cm)", "Duckworth", 814, 68, 25, "176 lbs/(80kg)" },
                    { new Guid("73bb0615-9974-83c3-8269-93caa85a0cb9"), 34, "Zurich, Switzerland", new Guid("b17223a3-ff40-8c56-3136-e4c95b187f48"), "Viktorija", "Female", "5'7\"/(169cm)", "Golubic", 899, 82, 24, "132 lbs/(60kg)" },
                    { new Guid("74107364-0a09-5fb0-f7c3-51fe840ce735"), 26, "Mar del Plata, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Francisco", "Male", "5'10\"/(178cm)", "Comesana", 455, 128, 15, "165 lbs/(75kg)" },
                    { new Guid("742f6674-0807-6387-b06f-7fccde55860e"), 30, "Hradec Králové, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Katerina", "Female", "5'9\"/(174cm)", "Siniakova", 865, 86, 18, "150 lbs/(68kg)" },
                    { new Guid("762cda9e-00ff-db1b-a623-30dda5100669"), 24, "London, United Kingdom", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Sonay", "Female", "5'7\"/(170cm)", "Kartal", 1097, 49, 11, "132 lbs/(60kg)" },
                    { new Guid("777f58f4-fb79-5447-702f-4a24341b539b"), 34, "Poznań, Poland", new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Magda", "Female", "5'7\"/(171cm)", "Linette", 908, 77, 21, "130 lbs/(59kg)" },
                    { new Guid("78e916d5-bfa9-6c21-7573-025cefe4d095"), 33, "Wiener Neustadt, Austria", new Guid("aaa12cd3-4b12-d434-874e-d5ee1f99397a"), "Dominic", "Male", "6'1\"/(185cm)", "Thiem", 710, 82, 19, "179 lbs/(81kg)" },
                    { new Guid("791650e5-18ff-6b0b-5ca2-2a93eb26b032"), 29, "Riga, Latvia", new Guid("bc9618b2-5e31-be53-774d-31d580708859"), "Jelena", "Female", "5'10\"/(178cm)", "Ostapenko", 1916, 24, 21, "141 lbs/(64kg)" },
                    { new Guid("7b9782db-09ca-582a-27d3-436255dc2272"), 28, "Metz, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Ugo", "Male", "6'2\"/(188cm)", "Humbert", 1270, 38, 22, "161 lbs/(73kg)" },
                    { new Guid("7cb6c0f2-5a0b-4279-0f22-db428ebbb0cf"), 25, "San Diego, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Brandon", "Male", "6'1\"/(185cm)", "Nakashima", 2350, 17, 24, "170 lbs/(77kg)" },
                    { new Guid("7d36620c-686a-8f01-5c43-5af4d12fd433"), 31, "Montpellier, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Leolia", "Female", "5'6\"/(168cm)", "Jeanjean", 816, 92, 28, "130 lbs/(59kg)" },
                    { new Guid("7d5260d7-7164-5f66-354b-bf94d3ed2efe"), 31, "Nottingham, United Kingdom", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Billy", "Male", "6'2\"/(188cm)", "Harris", 568, 105, 28, "176 lbs/(80kg)" },
                    { new Guid("810f9c29-4569-5652-c413-cdeeda5f9d12"), 26, "Montreal, Canada", new Guid("8c72bb01-f139-1b8e-d31f-2520d9c63b98"), "Felix", "Male", "6'4\"/(193cm)", "Auger-Aliassime", 3515, 7, 21, "194 lbs/(88kg)" },
                    { new Guid("82f46a45-2860-ccd2-8e7b-f268321849fb"), 25, "Innichen, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Jannik", "Male", "6'3\"/(191cm)", "Sinner", 10450, 1, 20, "168 lbs/(76kg)" },
                    { new Guid("830c8ce7-19c3-69c6-1ca1-b0c2332f69eb"), 25, "Sanremo, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Matteo", "Male", "5'11\"/(180cm)", "Arnaldi", 1311, 36, 24, "157 lbs/(71kg)" },
                    { new Guid("84d5dbf2-7d19-8ae4-d8e0-8d7f7dbc4359"), 22, "Courcouronnes, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Arthur", "Male", "6'1\"/(185cm)", "Fils", 3375, 9, 23, "183 lbs/(83kg)" },
                    { new Guid("87d4cc3d-e077-b82a-ee0a-ad4cf1531040"), 33, "Tenerife, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Roberto", "Male", "6'0\"/(183cm)", "Carballés Baena", 835, 64, 25, "165 lbs/(75kg)" },
                    { new Guid("8881e88b-4348-9eb2-4e9f-c1f0faee4daf"), 28, "Chisinau, Moldova", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Cristina", "Female", "5'9\"/(175cm)", "Bucsa", 1294, 38, 24, "130 lbs/(59kg)" },
                    { new Guid("88acd018-671c-52d0-c297-c36dce638c59"), 25, "La Plata, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Thiago Agustín", "Male", "6'2\"/(188cm)", "Tirante", 1024, 49, 22, "172 lbs/(78kg)" },
                    { new Guid("88fb6a79-0d08-f090-5200-767b4f466320"), 24, "Carrara, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Lorenzo", "Male", "6'1\"/(185cm)", "Musetti", 1720, 27, 26, "165 lbs/(75kg)" },
                    { new Guid("89249194-7035-51e2-d8e5-74115cccf479"), 27, "Olenegorsk, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Liudmila", "Female", "5'11\"/(180cm)", "Samsonova", 1234, 43, 25, "148 lbs/(67kg)" },
                    { new Guid("89e5d1e6-0719-f2dd-d6bf-3748343f68f6"), 25, "Sydney, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Rinky", "Male", "5'10\"/(178cm)", "Hijikata", 689, 85, 26, "152 lbs/(69kg)" },
                    { new Guid("8ab91b95-266e-6e1f-7c2b-9e70cb72a3db"), 30, "Rome, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Matteo", "Male", "6'5\"/(196cm)", "Berrettini", 1083, 46, 16, "210 lbs/(95kg)" },
                    { new Guid("8bc2cede-72c8-75bc-fa6b-2f2d77c9efdb"), 21, "Hyères, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Arthur", "Male", "6'1\"/(185cm)", "Gea", 295, 195, 22, "165 lbs/(75kg)" },
                    { new Guid("8c07f551-2091-be82-d2fa-2055903268b0"), 30, "Leuven, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Elise", "Female", "5'10\"/(179cm)", "Mertens", 2540, 15, 21, "148 lbs/(67kg)" },
                    { new Guid("8ee5b3c9-8d02-bbc1-4a0f-774064ad9a35"), 25, "Taixing, Jiangsu, China", new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "Xiyu", "Female", "5'11\"/(180cm)", "Wang", 899, 81, 17, "148 lbs/(67kg)" },
                    { new Guid("8f17201d-9a73-0171-73ef-5324c2318cd7"), 22, "Moscow, Russia", new Guid("6e20db1b-a1ea-86e5-8ed2-59eb01b8f091"), "Maria", "Female", "5'6\"/(167cm)", "Timofeeva", 931, 70, 25, "130 lbs/(59kg)" },
                    { new Guid("8faa920d-2c19-94f9-08af-b9d29393ba54"), 31, "Senta, Serbia", new Guid("b98c2b1b-82d0-15d4-3ec1-5adac5f856e3"), "Laslo", "Male", "6'1\"/(185cm)", "Djere", 412, 136, 17, "174 lbs/(79kg)" },
                    { new Guid("903eabb3-e155-276c-4440-4e43e4f47a1c"), 28, "Bucharest, Romania", new Guid("a5a94fd0-3af9-a186-fbde-1ba8c50f141c"), "Jaqueline", "Female", "5'11\"/(180cm)", "Cristian", 928, 71, 20, "143 lbs/(65kg)" },
                    { new Guid("906013d4-0a72-c901-a58e-eee02c4e9fad"), 30, "Osijek, Croatia", new Guid("fafe6ec9-732a-44f2-e128-cf590e7bd447"), "Donna", "Female", "5'10\"/(179cm)", "Vekic", 1333, 36, 24, "141 lbs/(64kg)" },
                    { new Guid("90b13e11-c115-f35c-b1b6-d4688cabdc78"), 27, "Moscow, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Anna", "Female", "5'9\"/(175cm)", "Kalinskaya", 1989, 23, 22, "137 lbs/(62kg)" },
                    { new Guid("911b8de0-c5bc-cf4b-6757-99793c4b63ee"), 24, "Montreal, Canada", new Guid("8c72bb01-f139-1b8e-d31f-2520d9c63b98"), "Gabriel", "Male", "6'8\"/(203cm)", "Diallo", 382, 148, 21, "212 lbs/(96kg)" },
                    { new Guid("93236ac1-e011-f6ef-997b-c6676e94ad98"), 19, "Krasnoyarsk, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Mirra", "Female", "5'9\"/(175cm)", "Andreeva", 6306, 3, 20, "135 lbs/(61kg)" },
                    { new Guid("96f48553-24e6-9dab-9e22-30cd49e524be"), 26, "Kakhovka, Ukraine", new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Yuliia", "Female", "5'8\"/(172cm)", "Starodubtseva", 1090, 50, 29, "135 lbs/(61kg)" },
                    { new Guid("97497ad7-5819-845c-5c9c-5b3fe32130dc"), 27, "Sydney, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Alexei", "Male", "6'5\"/(196cm)", "Popyrin", 458, 127, 21, "172 lbs/(78kg)" },
                    { new Guid("991fcbd8-72df-c169-6630-a4621cec046b"), 21, "Irvine, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Learner", "Male", "5'11\"/(180cm)", "Tien", 2345, 16, 13, "165 lbs/(75kg)" },
                    { new Guid("992f1291-b58d-99fa-ed81-12e3dc4d2212"), 29, "Bondy, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Quentin", "Male", "6'4\"/(193cm)", "Halys", 1127, 45, 23, "180 lbs/(82kg)" },
                    { new Guid("9a64d86a-4603-9821-63c6-06ef38c98dd8"), 28, "Moscow, Russia", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Anna", "Female", "5'10\"/(179cm)", "Blinkova", 921, 72, 32, "130 lbs/(59kg)" },
                    { new Guid("9a93b546-0211-6944-e96f-535435808e9a"), 25, "Yekaterinburg, Russia", new Guid("6e20db1b-a1ea-86e5-8ed2-59eb01b8f091"), "Kamilla", "Female", "5'7\"/(170cm)", "Rakhimova", 966, 67, 28, "132 lbs/(60kg)" },
                    { new Guid("9c665f97-fcc4-1e54-90cd-3c191b417945"), 30, "Nîmes, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Benjamin", "Male", "6'0\"/(183cm)", "Bonzi", 617, 97, 24, "180 lbs/(82kg)" },
                    { new Guid("9e67303e-4e5b-9b22-5579-b8d6177af452"), 25, "Edinburgh, Scotland", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Jacob", "Male", "6'0\"/(183cm)", "Fearnley", 688, 56, 20, "170 lbs/(77kg)" },
                    { new Guid("9f1d222d-1951-120d-fc46-171e11d7984d"), 28, "Spisska Nova Ves, Slovakia", new Guid("3303b1e1-a815-51fb-de5e-44ca510e189c"), "Lukas", "Male", "6'4\"/(193cm)", "Klein", 670, 88, 22, "185 lbs/(84kg)" },
                    { new Guid("a07cad03-7503-3703-0127-8cb36e4d07d1"), 20, "Perth, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Taylah", "Female", "5'8\"/(172cm)", "Preston", 858, 87, 32, "130 lbs/(59kg)" },
                    { new Guid("a1d685c8-d217-f85b-6704-a7cbdcd1b2e7"), 32, "Odesa, Ukraine", new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Elina", "Female", "5'9\"/(174cm)", "Svitolina", 5229, 6, 19, "132 lbs/(60kg)" },
                    { new Guid("a2681fc4-166d-1550-5031-74fb63e1cf02"), 35, "Haskovo, Bulgaria", new Guid("71304549-dfa2-acec-aa49-2be5657ce2ab"), "Grigor", "Male", "6'3\"/(191cm)", "Dimitrov", 472, 124, 16, "178 lbs/(80kg)" },
                    { new Guid("a39cc0bb-822f-5d1c-e182-d0e5edf49820"), 20, "Zagreb, Croatia", new Guid("fafe6ec9-732a-44f2-e128-cf590e7bd447"), "Petra", "Female", "5'9\"/(175cm)", "Marcinko", 905, 78, 30, "132 lbs/(60kg)" },
                    { new Guid("a497e92e-5723-6f3d-06a4-a94a2b34ee6f"), 22, "Asuncion, Paraguay", new Guid("4ecc0b9c-72b3-0ac4-6334-9d63e698bf08"), "Adolfo Daniel", "Male", "6'0\"/(183cm)", "Vallejo", 965, 39, 22, "165 lbs/(75kg)" },
                    { new Guid("a59451c6-a488-e9ae-9f64-f415cb1e67b0"), 31, "Chelyabinsk, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Ekaterina", "Female", "5'9\"/(175cm)", "Alexandrova", 1591, 33, 26, "146 lbs/(66kg)" },
                    { new Guid("a77c1c75-bd94-3a33-8bb0-8ec996ea1382"), 25, "Paris, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Valentin", "Male", "6'2\"/(188cm)", "Royer", 585, 71, 22, "172 lbs/(78kg)" },
                    { new Guid("a888c817-36f5-056a-acf9-de515349d7d0"), 22, "Zhigulyovsk, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Diana", "Female", "5'8\"/(173cm)", "Shnaider", 2663, 13, 22, "143 lbs/(65kg)" },
                    { new Guid("a90c8bf4-df15-9553-3cc1-4816c7d5c685"), 21, "Split, Croatia", new Guid("fafe6ec9-732a-44f2-e128-cf590e7bd447"), "Dino", "Male", "6'2\"/(188cm)", "Prizmic", 625, 95, 20, "170 lbs/(77kg)" },
                    { new Guid("ab44a1b3-9dfc-4792-b0f0-e3c98f0b2a6e"), 29, "Mexico City, Mexico", new Guid("a9652dc0-ac92-433b-dd92-d6598149823b"), "Renata", "Female", "5'3\"/(160cm)", "Zarazua", 801, 94, 34, "126 lbs/(57kg)" },
                    { new Guid("abdab68f-2ce1-cd4e-4aab-54cd4a9d1bd6"), 29, "Nova Kakhovka, Ukraine", new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Anhelina", "Female", "5'10\"/(179cm)", "Kalinina", 1087, 51, 24, "132 lbs/(60kg)" },
                    { new Guid("adc85bbc-531e-cec6-322c-6d17cd0aa433"), 31, "Rock Island, Illinois, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Madison", "Female", "5'10\"/(178cm)", "Keys", 2029, 21, 21, "145 lbs/(66kg)" },
                    { new Guid("ae30c2ab-d6c8-1022-b0f1-fcc08448fd96"), 28, "Kempen, Germany", new Guid("5f096f4b-8929-65de-fd36-db7558756437"), "Daniel", "Male", "6'3\"/(191cm)", "Altmaier", 849, 62, 24, "170 lbs/(77kg)" },
                    { new Guid("ae36744e-76e8-eaec-4e50-0091ac41c5a7"), 36, "Warstein, Germany", new Guid("5f096f4b-8929-65de-fd36-db7558756437"), "Jan-Lennard", "Male", "6'4\"/(193cm)", "Struff", 969, 54, 19, "203 lbs/(92kg)" },
                    { new Guid("af40efc1-3554-c8b4-9d4e-8c68a6f69e3b"), 20, "Prague, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Nikola", "Female", "5'8\"/(173cm)", "Bartunkova", 1711, 29, 23, "132 lbs/(60kg)" },
                    { new Guid("afda09dd-04f8-9b84-c1d5-9bcfcfd35ce1"), 27, "Paris, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Corentin", "Male", "5'9\"/(175cm)", "Moutet", 630, 94, 23, "150 lbs/(68kg)" },
                    { new Guid("b094ba37-082d-d580-ad35-b3be0a12462d"), 27, "Lommel, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Zizou", "Male", "6'1\"/(185cm)", "Bergs", 660, 89, 23, "172 lbs/(78kg)" },
                    { new Guid("b10cbe01-9a46-e028-cf79-1f65cd398a5b"), 23, "Aarhus, Denmark", new Guid("aeee815e-f648-88b2-cb54-93e6c9921b10"), "Elmer", "Male", "6'0\"/(183cm)", "Moller", 570, 74, 24, "168 lbs/(76kg)" },
                    { new Guid("b3d26dd0-b115-ad8b-c0c0-64e23794a09f"), 26, "Marechal Candido Rondon, Brazil", new Guid("4decd5d6-b64c-9f4d-185b-d4443500a732"), "Thiago", "Male", "6'0\"/(183cm)", "Seyboth Wild", 545, 110, 21, "174 lbs/(79kg)" },
                    { new Guid("b43903ed-2f3a-8ec0-19f3-c82765849791"), 28, "Łódź, Poland", new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Magdalena", "Female", "5'7\"/(171cm)", "Frech", 1110, 47, 23, "134 lbs/(61kg)" },
                    { new Guid("b50c267b-75c4-ecb5-870e-e3e29d913b0e"), 29, "Maia, Portugal", new Guid("aeb3e1f0-0cc4-8dcd-db4d-626e1da8d798"), "Nuno", "Male", "6'1\"/(185cm)", "Borges", 1000, 51, 22, "165 lbs/(75kg)" },
                    { new Guid("b788aa3d-4899-a917-fbec-4bf950f2f8b4"), 24, "Lienz, Austria", new Guid("aaa12cd3-4b12-d434-874e-d5ee1f99397a"), "Sinja", "Female", "5'8\"/(172cm)", "Kraus", 910, 76, 32, "130 lbs/(59kg)" },
                    { new Guid("bc4391d6-1219-8e0e-9e6b-b4e1f0adff46"), 24, "Atlanta, Georgia, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Ben", "Male", "6'4\"/(193cm)", "Shelton", 4680, 4, 23, "195 lbs/(88kg)" },
                    { new Guid("bcd473d4-aa01-a4a5-621a-13a848dd1205"), 25, "9 de Julio, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Mariano", "Male", "5'9\"/(175cm)", "Navone", 1164, 43, 22, "160 lbs/(73kg)" },
                    { new Guid("bcf6db6e-42b0-278c-2ef9-d9d75e229bf5"), 36, "Bucharest, Romania", new Guid("a5a94fd0-3af9-a186-fbde-1ba8c50f141c"), "Sorana", "Female", "5'9\"/(176cm)", "Cirstea", 2380, 17, 21, "130 lbs/(59kg)" },
                    { new Guid("bd537c65-bf21-f85c-78bb-5f0005bcf773"), 24, "Cúcuta, Colombia", new Guid("a1d65bf8-02d6-df04-ce84-9b614353f054"), "Camila", "Female", "5'3\"/(160cm)", "Osorio", 963, 68, 25, "128 lbs/(58kg)" },
                    { new Guid("bde04240-cf13-cf6c-9e42-9a003582c2a0"), 29, "Hamburg, Germany", new Guid("5f096f4b-8929-65de-fd36-db7558756437"), "Alexander", "Male", "6'6\"/(198cm)", "Zverev", 9750, 2, 22, "198 lbs/(90kg)" },
                    { new Guid("be0fdcce-baac-95fe-5888-6eaa690b9f7f"), 34, "Buenos Aires, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Diego", "Male", "5'7\"/(170cm)", "Schwartzman", 680, 86, 22, "152 lbs/(69kg)" },
                    { new Guid("be24adc9-3934-45ec-f349-22052eeff0cc"), 28, "Sydney, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Max", "Male", "6'1\"/(185cm)", "Purcell", 650, 91, 24, "157 lbs/(71kg)" },
                    { new Guid("beb773c4-62e9-33e7-25fe-f4361691ab66"), 27, "Buenos Aires, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Camilo", "Male", "6'1\"/(185cm)", "Ugo Carabelli", 795, 52, 24, "165 lbs/(75kg)" },
                    { new Guid("bfeea382-efb2-fa92-c732-106b3a5a451c"), 24, "Rochefort, Belgium", new Guid("a07e8fbb-e337-1765-6b98-62fc46244a7a"), "Raphael", "Male", "6'2\"/(188cm)", "Collignon", 975, 42, 23, "172 lbs/(78kg)" },
                    { new Guid("c07cf102-37ed-3bc0-4bfa-a5cef09fa38d"), 31, "Johannesburg, South Africa", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Cameron", "Male", "6'2\"/(188cm)", "Norrie", 1195, 41, 20, "180 lbs/(82kg)" },
                    { new Guid("c27385bc-c2c5-8299-2022-9b0b14db0908"), 31, "Turin, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Lorenzo", "Male", "6'3\"/(191cm)", "Sonego", 658, 90, 25, "169 lbs/(77kg)" },
                    { new Guid("c46f5a57-c7b2-e6e4-87a7-74916f5749ba"), 25, "Haarlem, Netherlands", new Guid("89fa8d38-0138-e506-b39d-9c30a8a73146"), "Jesper", "Male", "5'11\"/(180cm)", "de Jong", 591, 100, 22, "159 lbs/(72kg)" },
                    { new Guid("c5da432c-8b32-caf7-eaae-d8a04ee97a90"), 38, "Medjugorje, Bosnia and Herzegovina", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Marin", "Male", "6'6\"/(198cm)", "Cilic", 625, 59, 18, "196 lbs/(89kg)" },
                    { new Guid("c7bae4af-c088-b015-e5da-4f03a9eb23c2"), 26, "Sacramento, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Jenson", "Male", "6'4\"/(193cm)", "Brooksby", 605, 99, 19, "183 lbs/(83kg)" },
                    { new Guid("c84ad2fa-dce2-901f-e666-63592d2d0743"), 25, "Lyon, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Kyrian", "Male", "5'10\"/(178cm)", "Jacquet", 741, 79, 21, "155 lbs/(70kg)" },
                    { new Guid("c90e5e41-1fe5-b43b-fdfa-206ed2611dd9"), 37, "Tianjin, China", new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "Shuai", "Female", "5'10\"/(177cm)", "Zhang", 880, 85, 33, "143 lbs/(65kg)" },
                    { new Guid("c90f3ce8-88e3-ac63-a114-d23a4938eab1"), 25, "Saratov, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Anastasia", "Female", "5'9\"/(175cm)", "Potapova", 1814, 27, 21, "126 lbs/(57kg)" },
                    { new Guid("c9a25969-e661-ebcb-eefe-ac286198874e"), 26, "Toulouse, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Hugo", "Male", "5'8\"/(173cm)", "Gaston", 640, 93, 26, "150 lbs/(68kg)" },
                    { new Guid("ca12c8b8-5a52-fd5f-6550-ff69dca603d9"), 30, "Arica, Chile", new Guid("09678de0-a810-11e4-8792-4914194808ec"), "Cristian", "Male", "6'1\"/(185cm)", "Garin", 588, 101, 23, "187 lbs/(85kg)" },
                    { new Guid("cb83e9dc-0495-3495-97f8-e5dcf4da1cc4"), 25, "New York City, New York, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Emma", "Female", "5'7\"/(170cm)", "Navarro", 1794, 28, 25, "154 lbs/(70kg)" },
                    { new Guid("cc7eee84-ba54-69ea-c788-17f19bff57d4"), 27, "Belgrade, Serbia", new Guid("b98c2b1b-82d0-15d4-3ec1-5adac5f856e3"), "Miomir", "Male", "6'0\"/(183cm)", "Kecmanović", 353, 161, 25, "170 lbs/(77kg)" },
                    { new Guid("cc8ad782-a62b-1f79-4851-8db255248f94"), 25, "Mlada Boleslav, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Jiri", "Male", "6'1\"/(185cm)", "Lehecka", 2275, 20, 25, "176 lbs/(80kg)" },
                    { new Guid("cd43c9f9-096b-f613-2eba-0786921edaed"), 22, "Montville, NJ, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Michael", "Male", "5'11\"/(180cm)", "Zheng", 605, 70, 20, "165 lbs/(75kg)" },
                    { new Guid("ce4f8ed9-323e-9c90-bcb0-3a18f885114c"), 24, "Shiyan, Hubei, China", new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "Qinwen", "Female", "5'10\"/(178cm)", "Zheng", 2018, 22, 18, "139 lbs/(63kg)" },
                    { new Guid("cee30799-42bc-db04-b50d-9c68565dbdef"), 23, "Oroslavje, Croatia", new Guid("fafe6ec9-732a-44f2-e128-cf590e7bd447"), "Antonia", "Female", "5'9\"/(175cm)", "Ruzic", 823, 91, 28, "132 lbs/(60kg)" },
                    { new Guid("cf724c07-c504-b9dd-92c7-5a3950d110e5"), 28, "New York City, USA", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Paula", "Female", "5'11\"/(180cm)", "Badosa", 1023, 61, 22, "154 lbs/(70kg)" },
                    { new Guid("cfa51d65-f041-ef84-124a-a8492219dd19"), 41, "Lausanne, Switzerland", new Guid("b17223a3-ff40-8c56-3136-e4c95b187f48"), "Stan", "Male", "6'0\"/(183cm)", "Wawrinka", 376, 148, 14, "179 lbs/(81kg)" },
                    { new Guid("d01047e5-1173-c854-3064-ac0fb5292ffc"), 28, "Athens, Greece", new Guid("ad04f235-a5b4-84ef-fea5-0c81750d6db8"), "Stefanos", "Male", "6'4\"/(193cm)", "Tsitsipas", 1380, 35, 23, "198 lbs/(90kg)" },
                    { new Guid("d070a207-3d51-a96b-4256-5f4bbbea1597"), 31, "Wageningen, Netherlands", new Guid("89fa8d38-0138-e506-b39d-9c30a8a73146"), "Botic", "Male", "6'3\"/(191cm)", "van de Zandschulp", 1295, 37, 24, "185 lbs/(84kg)" },
                    { new Guid("d0f145fb-31e6-d59c-e08c-5cad4a4f28ec"), 25, "Shenzhen, China", new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "Xinyu", "Female", "6'0\"/(182cm)", "Wang", 1288, 39, 25, "139 lbs/(63kg)" },
                    { new Guid("d2ad0922-9b10-c775-6cf6-d62f19359c36"), 31, "Athens, Greece", new Guid("ad04f235-a5b4-84ef-fea5-0c81750d6db8"), "Maria", "Female", "5'8\"/(172cm)", "Sakkari", 1706, 31, 23, "138 lbs/(62kg)" },
                    { new Guid("d35a44b3-5aec-c96e-52a1-936e950d5ec4"), 24, "Istanbul, Turkey", new Guid("030a4b3c-9650-a761-143c-b5d512416450"), "Zeynep", "Female", "5'7\"/(170cm)", "Sonmez", 987, 63, 26, "128 lbs/(58kg)" },
                    { new Guid("d494ddc8-22be-8d98-8d9b-970f59f160c7"), 20, "Rio de Janeiro, Brazil", new Guid("4decd5d6-b64c-9f4d-185b-d4443500a732"), "Joao", "Male", "6'1\"/(185cm)", "Fonseca", 1250, 32, 14, "176 lbs/(80kg)" },
                    { new Guid("d5f73a60-cacc-3324-914d-a7f7fbefd7ff"), 30, "Sydney, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Aleksandar", "Male", "6'2\"/(188cm)", "Vukic", 507, 116, 23, "172 lbs/(78kg)" },
                    { new Guid("d62906b4-21b9-7583-2eab-17a41fec544a"), 29, "Moscow, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Andrey", "Male", "6'2\"/(188cm)", "Rublev", 2175, 22, 24, "165 lbs/(75kg)" },
                    { new Guid("d643e042-f677-2f4a-3769-cd9a29cc4189"), 19, "Moscow, Russia", new Guid("7cd806df-4622-802c-1e6f-5ebbbd58762d"), "Alina", "Female", "5'9\"/(175cm)", "Korneeva", 900, 80, 24, "135 lbs/(61kg)" },
                    { new Guid("d65a558b-0c9a-6dbd-8c7c-1fd0e260247c"), 39, "Belgrade, Serbia", new Guid("b98c2b1b-82d0-15d4-3ec1-5adac5f856e3"), "Novak", "Male", "6'2\"/(188cm)", "Djokovic", 3090, 12, 14, "170 lbs/(77kg)" },
                    { new Guid("dba280da-b60a-5409-8576-c3a534b33bae"), 24, "Bournemouth, United Kingdom", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Toby", "Male", "6'0\"/(183cm)", "Samuel", 620, 96, 21, "165 lbs/(75kg)" },
                    { new Guid("dc0f3e4d-4a5c-87d3-529f-8dc9f92530af"), 30, "Haarlem, Netherlands", new Guid("89fa8d38-0138-e506-b39d-9c30a8a73146"), "Tallon", "Male", "6'2\"/(188cm)", "Griekspoor", 835, 65, 26, "183 lbs/(83kg)" },
                    { new Guid("dc365279-a64b-c27d-54cc-915c36b9bea8"), 29, "Wroclaw, Poland", new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Hubert", "Male", "6'5\"/(196cm)", "Hurkacz", 1585, 28, 20, "179 lbs/(81kg)" },
                    { new Guid("dc376e6e-65cb-d6cf-3c03-95b2c8efa532"), 20, "Madrid, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Martin", "Male", "6'3\"/(191cm)", "Landaluce", 835, 50, 22, "172 lbs/(78kg)" },
                    { new Guid("dc779c82-579f-ad02-dc81-52d5ec227da0"), 25, "Warsaw, Poland", new Guid("ac05715a-891e-88df-93cf-93012a398933"), "Iga", "Female", "5'9\"/(175cm)", "Swiatek", 4389, 9, 19, "143 lbs/(65kg)" },
                    { new Guid("dd4333cf-cf89-c851-b98e-f95561994eb7"), 30, "Castelnuovo di Garfagnana, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Jasmine", "Female", "5'4\"/(163cm)", "Paolini", 1453, 35, 19, "119 lbs/(54kg)" },
                    { new Guid("dd9c901f-2317-5c07-2648-66a51f58597a"), 25, "Ancona, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Elisabetta", "Female", "5'5\"/(166cm)", "Cocciaretto", 975, 65, 21, "123 lbs/(56kg)" },
                    { new Guid("ddc9dce2-08fd-8a43-02da-2e8866be8d58"), 24, "Florence, Italy", new Guid("5d5e3c89-2beb-f2bd-7773-ce812f45bebe"), "Flavio", "Male", "6'0\"/(183cm)", "Cobolli", 3590, 6, 23, "165 lbs/(75kg)" },
                    { new Guid("deada995-ceac-fbe2-d434-4f391e44653f"), 28, "Kaposvár, Hungary", new Guid("d3ff130b-5386-50ad-568a-09890b9fa9b9"), "Panna", "Female", "5'7\"/(170cm)", "Udvardy", 899, 83, 31, "132 lbs/(60kg)" },
                    { new Guid("e03eec8a-27b3-83e0-df40-704a52f7227d"), 29, "Libreville, Gabon", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Fiona", "Female", "5'7\"/(170cm)", "Ferro", 748, 100, 24, "128 lbs/(58kg)" },
                    { new Guid("e0ce359e-4d5d-1080-00d8-95209057c3d3"), 25, "Kyiv, Ukraine", new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Oleksandra", "Female", "5'8\"/(173cm)", "Oliynykova", 1022, 62, 30, "130 lbs/(59kg)" },
                    { new Guid("e198eade-6051-1063-4065-395d4889be02"), 27, "Sydney, Australia", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Alex", "Male", "6'0\"/(183cm)", "de Minaur", 3280, 10, 21, "152 lbs/(69kg)" },
                    { new Guid("e1ad94da-4d2f-60e0-a726-9afb3851e4a7"), 24, "Vilagarcía de Arousa, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Jessica", "Female", "5'8\"/(173cm)", "Bouzas Maneiro", 769, 96, 29, "134 lbs/(61kg)" },
                    { new Guid("e1df88e6-8f3f-751e-ce78-5dd8dcf9da5e"), 22, "Porto, Portugal", new Guid("aeb3e1f0-0cc4-8dcd-db4d-626e1da8d798"), "Henrique", "Male", "6'0\"/(183cm)", "Rocha", 612, 67, 25, "168 lbs/(76kg)" },
                    { new Guid("e331781c-f838-4c8d-5de5-b12ba2354ccd"), 21, "Siauliai, Lithuania", new Guid("67aaa934-331b-91ed-5fa4-12e9a6e71580"), "Vilius", "Male", "6'1\"/(185cm)", "Gaubas", 555, 76, 26, "175 lbs/(79kg)" },
                    { new Guid("e34c274e-9d99-20e3-b865-85934b6a4402"), 24, "Washington, D.C., USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Hailey", "Female", "5'9\"/(175cm)", "Baptiste", 1154, 44, 15, "150 lbs/(68kg)" },
                    { new Guid("e384741a-ffa3-f530-0a56-bdecb40df540"), 35, "Schiltigheim, France", new Guid("133ed024-88c6-251c-6207-e2469cd1b5b9"), "Pierre-Hugues", "Male", "6'2\"/(188cm)", "Herbert", 315, 248, 18, "176 lbs/(80kg)" },
                    { new Guid("e3ce1444-66b0-4d11-610d-29ac28e35ddb"), 21, "Laguna Hills, California, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Alex", "Male", "6'4\"/(193cm)", "Michelsen", 1385, 34, 24, "170 lbs/(77kg)" },
                    { new Guid("e3dfc357-f551-ad2f-7936-e86b327dfc7b"), 27, "Moscow, Russia", new Guid("71dd9f8e-0ac6-8873-e309-4710e48eeaef"), "Elena", "Female", "6'0\"/(184cm)", "Rybakina", 9196, 1, 20, "143 lbs/(65kg)" },
                    { new Guid("e57d6bbf-ec56-8620-a9eb-e56aac0740bf"), 26, "King of Prussia, Pennsylvania, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Ann", "Female", "5'7\"/(170cm)", "Li", 1833, 25, 27, "135 lbs/(61kg)" },
                    { new Guid("e5b6058f-eef2-3945-f26d-e3fc22584627"), 28, "Roquebrune-Cap-Martin, France", new Guid("717a1e86-e443-a658-a307-a399e8988dfe"), "Valentin", "Male", "6'4\"/(193cm)", "Vacherot", 1480, 26, 32, "185 lbs/(84kg)" },
                    { new Guid("e7b55586-88e7-8eee-1eac-ec6e54fdd805"), 29, "Gatchina, Russia", new Guid("71dd9f8e-0ac6-8873-e309-4710e48eeaef"), "Alexander", "Male", "6'5\"/(196cm)", "Bublik", 2285, 18, 27, "181 lbs/(82kg)" },
                    { new Guid("e82c9316-03d1-1ad9-bc06-bb9dfe193751"), 28, "Buenos Aires, Argentina", new Guid("37e511fc-60d5-4a3b-74bd-9b9b007a97fb"), "Francisco", "Male", "6'1\"/(185cm)", "Cerundolo", 2260, 19, 23, "172 lbs/(78kg)" },
                    { new Guid("e84166c7-adb6-aad0-7a2c-136242ddf7d7"), 28, "Dusseldorf, Germany", new Guid("38cb61dd-3fb5-4481-fa07-bcc7d36f5690"), "Kimberly", "Female", "5'7\"/(170cm)", "Birrell", 1280, 41, 28, "132 lbs/(60kg)" },
                    { new Guid("ebd8492b-5880-007c-3d03-81e574f47735"), 34, "Louny, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Karolina", "Female", "6'1\"/(186cm)", "Pliskova", 1105, 48, 15, "159 lbs/(72kg)" },
                    { new Guid("ef053a14-8c67-dab1-560f-5d67eb758e23"), 29, "Zagreb, Croatia", new Guid("e20b2069-d8fe-ec08-f16e-dc2fae4e6b20"), "Borna", "Male", "6'1\"/(185cm)", "Coric", 750, 77, 21, "183 lbs/(83kg)" },
                    { new Guid("efe432f0-67e7-6a02-e307-700fe3fffbc2"), 24, "Bortala, China", new Guid("185127cd-c953-e57d-3c8e-21bc517e67a6"), "Bu", "Male", "6'1\"/(185cm)", "Yunchaokete", 650, 91, 22, "172 lbs/(78kg)" },
                    { new Guid("f02dfbe2-b059-faff-3609-533baaee22e1"), 24, "Cincinnati, Ohio, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Caty", "Female", "5'10\"/(178cm)", "Mcnally", 1035, 59, 24, "139 lbs/(63kg)" },
                    { new Guid("f0329f64-989c-edd3-d7ce-a7c6a7a8000f"), 39, "Bad Saulgau, Germany", new Guid("5f096f4b-8929-65de-fd36-db7558756437"), "Tatjana", "Female", "5'8\"/(172cm)", "Maria", 945, 69, 32, "137 lbs/(62kg)" },
                    { new Guid("f292a26b-d021-2ada-21eb-2bc16bcf9919"), 25, "Cincinnati, Ohio, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Peyton", "Female", "5'8\"/(173cm)", "Stearns", 1316, 37, 23, "135 lbs/(61kg)" },
                    { new Guid("f2e1186d-814d-4e9d-2e13-976ecd19354a"), 31, "Moscow, Russia", new Guid("71dd9f8e-0ac6-8873-e309-4710e48eeaef"), "Yulia", "Female", "5'4\"/(163cm)", "Putintseva", 969, 66, 24, "130 lbs/(59kg)" },
                    { new Guid("f33e6459-8e50-933e-5375-c3c79f72cce0"), 29, "Toronto, Canada", new Guid("09678de0-a810-11e4-8792-4914194808ec"), "Alejandro", "Male", "6'2\"/(188cm)", "Tabilo", 1565, 30, 21, "165 lbs/(75kg)" },
                    { new Guid("f46c664d-d9a4-65c6-f467-aa67cd9fd3de"), 19, "Prague, Czech Republic", new Guid("1265c601-0d79-510b-f5c2-dca5d6db2050"), "Tereza", "Female", "5'10\"/(178cm)", "Valentova", 833, 88, 21, "135 lbs/(61kg)" },
                    { new Guid("f4fcbb01-548f-e476-c3f0-e0cd4fc063ae"), 24, "Kyiv, Ukraine", new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Marta", "Female", "5'9\"/(175cm)", "Kostyuk", 3920, 10, 18, "137 lbs/(62kg)" },
                    { new Guid("f57c5e1a-1b22-2edf-574c-f39a21f4ea2f"), 23, "El Palmar, Murcia, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Carlos", "Male", "6'0\"/(183cm)", "Alcaraz", 5610, 3, 18, "163 lbs/(74kg)" },
                    { new Guid("f6540b7c-fb8c-ad94-b686-49ba873b4ef6"), 34, "Tbilisi, Georgia", new Guid("4a392f39-ce99-6c69-5984-6d018b8c0150"), "Nikoloz", "Male", "6'1\"/(185cm)", "Basilashvili", 630, 58, 23, "174 lbs/(79kg)" },
                    { new Guid("f72b8741-39b5-474b-e9d7-8f76948a10f8"), 30, "Chicago, Illinois, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Taylor", "Female", "5'7\"/(170cm)", "Townsend", 831, 89, 13, "170 lbs/(77kg)" },
                    { new Guid("f985301c-b144-4fa7-2f87-ce7b7a13f593"), 24, "Kyiv, Ukraine", new Guid("abcfdd20-fa0d-06da-8097-d34273efc7b3"), "Daria", "Female", "5'7\"/(170cm)", "Snigur", 1280, 40, 24, "130 lbs/(59kg)" },
                    { new Guid("fa9ef637-8855-ad2f-af38-a9e33a005fb3"), 27, "New York, New York, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Aleksandar", "Male", "6'0\"/(183cm)", "Kovacevic", 703, 84, 23, "174 lbs/(79kg)" },
                    { new Guid("fcaf2edb-1c84-bf63-e670-7f50f0a14cba"), 25, "Freehold, New Jersey, USA", new Guid("e5948bc3-6513-2bab-7f42-e6ce69e45199"), "Amanda", "Female", "5'11\"/(180cm)", "Anisimova", 2363, 18, 15, "132 lbs/(60kg)" },
                    { new Guid("fe24d703-a39a-d332-2991-75170ccc1afc"), 28, "Bucharest, Romania", new Guid("a5a94fd0-3af9-a186-fbde-1ba8c50f141c"), "Elena-Gabriela", "Female", "5'8\"/(172cm)", "Ruse", 1033, 60, 24, "132 lbs/(60kg)" },
                    { new Guid("fed4e693-8dce-1d71-7c9f-c62dd88b9516"), 20, "Madrid, Spain", new Guid("6cd49520-ad18-21af-4b07-3b15a7626b1d"), "Rafael", "Male", "6'3\"/(191cm)", "Jodar", 2850, 11, 17, "154 lbs/(70kg)" }
                });

            migrationBuilder.InsertData(
                table: "TournamentVenues",
                columns: new[] { "TournamentId", "VenueId" },
                values: new object[,]
                {
                    { new Guid("1aa45a9a-4015-560d-d7c2-f594cf300eab"), new Guid("4240c5f1-47f3-8993-9f84-c34f886a8fa8") },
                    { new Guid("21b75548-50bb-f5a8-3e04-4df9dd776715"), new Guid("4802b018-5151-da85-21a6-4be35a67fd85") },
                    { new Guid("3ba6f36e-30af-72d9-f4e1-b8c540537633"), new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a") },
                    { new Guid("4b5fa7f6-1f63-746a-5147-8ba5e549ed4f"), new Guid("01398289-742d-3688-178d-0b7ac0f3db44") },
                    { new Guid("6375b49e-77da-ea35-07cf-d6f9e263edbe"), new Guid("812c72e4-2f62-6626-265e-4e26c1b40174") },
                    { new Guid("65785e2e-be20-5a3c-3d3f-58aa7ecf99cf"), new Guid("1d0f7e07-6c4c-2b8b-1631-216839c5fd2e") },
                    { new Guid("66764405-2070-1aa3-032f-59d5bbc2e03f"), new Guid("1b10f29e-d2d7-4b17-1370-ce61e2826157") },
                    { new Guid("73f7bad5-fb6b-89c1-d5b4-5026e24b4778"), new Guid("b46bf0d7-9420-f9bb-8cb7-551b28e533e9") },
                    { new Guid("7f89f574-ceff-bb37-dde5-a1445391021a"), new Guid("b2026a06-3e90-7c25-b97e-ae3cff9975a5") },
                    { new Guid("7fdfc872-c0aa-8cda-e9ad-768733c7d7d1"), new Guid("e901ac40-4167-6ed4-33c5-38adef64d6aa") },
                    { new Guid("85223fc0-d5d6-c0fc-a668-1fdb607e915a"), new Guid("ee8e8214-bff6-9fea-66bc-83713f1781ec") },
                    { new Guid("878dbd49-9843-c952-f812-cc5fde377431"), new Guid("0a093d19-917e-4a21-972e-b1e89b39416d") },
                    { new Guid("8c9b1e85-f41d-6795-8c87-d61bc14a51c3"), new Guid("dcbca76e-1aa3-cd66-7d38-6b547fb207f4") },
                    { new Guid("913b563c-6c8d-af99-6835-a6b98d790768"), new Guid("247d28ed-57e6-07e8-580a-dd4f43548bcd") },
                    { new Guid("9211f2c5-459b-2574-3e1b-eab2f5dd945f"), new Guid("8b5b88b3-8c2f-f2fe-ae8b-b3c8ed532cd8") },
                    { new Guid("95225147-8237-4107-6495-22a2b87de875"), new Guid("8b9928a7-30eb-959c-3878-24bf034406cd") },
                    { new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9") },
                    { new Guid("a1596083-41ad-327f-a87a-538e657f4f1c"), new Guid("dbd84836-dd9d-2a5e-0f03-5df858ea8851") },
                    { new Guid("a6dbadba-13a4-4c1a-77be-b94f0e328bad"), new Guid("efa8e236-d522-f001-fc5a-ebd68c1ca1b4") },
                    { new Guid("ab9923f4-66ee-81b4-220b-a5e6781b5bf4"), new Guid("285e787f-ba96-5559-64ea-77fdb69d3e9a") },
                    { new Guid("be1bb675-aa94-289a-a381-be545fb9222b"), new Guid("fd8a4796-4b11-af79-77ff-367a3a157017") },
                    { new Guid("c4677b80-d746-8861-2f25-fd69b9e5b0cd"), new Guid("f4e815bd-2c5a-8a71-e0d2-deb6e4180f28") },
                    { new Guid("c5608612-d979-6e0f-fd0c-0d4676e820f8"), new Guid("28b193c2-afff-79d2-0375-161185f00d6a") },
                    { new Guid("e9f7a94b-bfe0-3aac-6912-900da822d6cc"), new Guid("fed03ef4-494e-b021-1973-2389bd8f283e") },
                    { new Guid("eee5e1a5-fe8a-dea9-d5c0-d67e751592b7"), new Guid("4525054a-483d-f44f-f772-addd74b9daeb") },
                    { new Guid("f881058f-4995-999e-4dc9-b1ac17571219"), new Guid("66eabd34-a820-bb37-c757-4081b5dc4f39") },
                    { new Guid("fb38fe7e-51bb-4ace-f719-de15c72f6d69"), new Guid("19b8a897-43ca-78c6-1405-0a5b63aa02c7") },
                    { new Guid("fe67857d-f279-1751-fd7b-2e81b27a5d5f"), new Guid("9c712670-3363-37fa-3a4e-237e22c90951") }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "CourtEnvironment", "CourtId", "CourtSurface", "DateTime", "FirstPlayerId", "MatchRound", "MatchStatus", "ScoreResult", "SecondPlayerId", "TournamentId", "VenueId", "WinnerId" },
                values: new object[,]
                {
                    { new Guid("07328a2a-1cee-6b58-75e5-94ba73b10e4c"), 1, new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Hard", new DateTime(2026, 10, 16, 9, 40, 0, 0, DateTimeKind.Utc), new Guid("cee30799-42bc-db04-b50d-9c68565dbdef"), "Quarterfinal", "Completed", "4-6 6-4 6-3", new Guid("71c2c435-0a30-5a50-f401-df86e253e265"), new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), new Guid("cee30799-42bc-db04-b50d-9c68565dbdef") },
                    { new Guid("2b616272-fe35-d823-a286-3ddf16791624"), 1, new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Hard", new DateTime(2026, 10, 16, 13, 10, 0, 0, DateTimeKind.Utc), new Guid("532828a9-f83f-e29d-f49e-f56fd46deeb9"), "Quarterfinal", "Completed", "6-3 1-6 6-3", new Guid("c07cf102-37ed-3bc0-4bfa-a5cef09fa38d"), new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), new Guid("532828a9-f83f-e29d-f49e-f56fd46deeb9") },
                    { new Guid("30b36737-769a-6f0f-31a9-9f5e2c993b12"), 1, new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Hard", new DateTime(2026, 10, 15, 9, 40, 0, 0, DateTimeKind.Utc), new Guid("afda09dd-04f8-9b84-c1d5-9bcfcfd35ce1"), "Quarterfinal", "Completed", "1-4", new Guid("8ab91b95-266e-6e1f-7c2b-9e70cb72a3db"), new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), new Guid("8ab91b95-266e-6e1f-7c2b-9e70cb72a3db") },
                    { new Guid("9a46a435-c545-c57a-19c1-f83eb355970a"), 1, new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Hard", new DateTime(2026, 10, 17, 14, 10, 0, 0, DateTimeKind.Utc), new Guid("cee30799-42bc-db04-b50d-9c68565dbdef"), "Semifinal", "Completed", "6-3 6-4", new Guid("532828a9-f83f-e29d-f49e-f56fd46deeb9"), new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), new Guid("cee30799-42bc-db04-b50d-9c68565dbdef") },
                    { new Guid("d054775b-f0e8-b891-f93b-1a2080e48a24"), 1, new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Hard", new DateTime(2026, 10, 15, 13, 10, 0, 0, DateTimeKind.Utc), new Guid("bde04240-cf13-cf6c-9e42-9a003582c2a0"), "Quarterfinal", "Completed", "6-4 5-4", new Guid("d62906b4-21b9-7583-2eab-17a41fec544a"), new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), new Guid("bde04240-cf13-cf6c-9e42-9a003582c2a0") },
                    { new Guid("ed0085a7-ac88-0af0-1fd5-b346a143bc41"), 1, new Guid("fdfaa559-c2df-41e2-1877-f6c325759fe5"), "Hard", new DateTime(2026, 10, 17, 11, 40, 0, 0, DateTimeKind.Utc), new Guid("bde04240-cf13-cf6c-9e42-9a003582c2a0"), "Semifinal", "Completed", "7-5 4-6 3-6", new Guid("8ab91b95-266e-6e1f-7c2b-9e70cb72a3db"), new Guid("9ff588d9-efd7-5998-7564-0c60cfa790bd"), new Guid("6caac657-0e0b-25d4-226f-4a6cdd07c7e9"), new Guid("8ab91b95-266e-6e1f-7c2b-9e70cb72a3db") }
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
                name: "IX_Courts_VenueId",
                table: "Courts",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_CourtId",
                table: "Matches",
                column: "CourtId");

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
                name: "Courts");

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

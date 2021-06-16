using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tourrento.DAL.Migrations
{
    public partial class Initial : Migration
    {
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    FeePerDay = table.Column<int>(type: "int", nullable: false),
                    InStock = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
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
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UntilDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    AcceptContract = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    StartLocation_Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StartLocation_City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StartLocation_ZipCode = table.Column<int>(type: "int", nullable: false),
                    StartLocation_Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FinalLocation_Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FinalLocation_City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FinalLocation_ZipCode = table.Column<int>(type: "int", nullable: false),
                    FinalLocation_Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MaxNumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemCarts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCarts", x => new { x.ItemId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ItemCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCarts_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => new { x.ItemId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ItemCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCategories_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentedItems",
                columns: table => new
                {
                    RentId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedItems", x => new { x.ItemId, x.RentId });
                    table.ForeignKey(
                        name: "FK_RentedItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentedItems_Rents_RentId",
                        column: x => x.RentId,
                        principalTable: "Rents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipateTours",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipateTours", x => new { x.TourId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ParticipateTours_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipateTours_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    QuestionerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_QuestionerId",
                        column: x => x.QuestionerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequiredCategoryTours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false),
                    RequiredCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredCategoryTours", x => new { x.RequiredCategoryId, x.TourId });
                    table.ForeignKey(
                        name: "FK_RequiredCategoryTours_Categories_RequiredCategoryId",
                        column: x => x.RequiredCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequiredCategoryTours_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourServices",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourServices", x => new { x.TourId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_TourServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourServices_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "FELHASZNALÓ", "092a0244-66ff-428e-809c-7b0a479767f8", "Felhasznaló", "FELHASZNALÓ" },
                    { "SZERVEZŐ", "7cdcf613-5a08-428a-b3db-b95a7b18169d", "Szervező", "SZERVEZŐ" },
                    { "ADMIN", "66910755-f69f-45a6-8a8f-d3064d316406", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "seedtwo", 0, "1ed698e4-8368-463e-a5bd-8c30750cc06a", "wincheszter@gmail.com", true, false, null, "Winch Eszter", "WINCHESZTER@GMAIL.COM", "WINCHESZTER", "AQAAAAEAACcQAAAAECaehXJu0t/4OzOKFKT3VYfsocmERzfq9kyRiHOo0RIJ5tXO8V50hPLXVi10axEeJw==", "06/30-152-5123", false, "4e728a01-59f2-49ac-b55f-0fad23bf60da", false, "wincheszter" },
                    { "seedone", 0, "f4c96927-0181-4426-9d20-c62aca099ac0", "tesztelek@gmail.com", true, false, null, "Teszt Elek", "TESZTELEK@GMAIL.COM", "TESZTELEK", "AQAAAAEAACcQAAAAECPX9dqiUQ3jeQBbEnO2p8JFHpZe6lx0szwlF4t3PBS82xrfVK6VoBDR2lm8iZK8pA==", "06/30-152-5123", false, "7f2d9a16-1cd9-45ea-869a-4e7c10cfe6c2", false, "tesztelek" },
                    { "seedthree", 0, "d867e523-7678-4d48-b70b-744684360e67", "kbela@gmail.com", true, false, null, "Kis Béla", "KBELA@GMAIL.COM", "KBELA", "AQAAAAEAACcQAAAAEHfqmLoNpb/Ed1PBDCA6HOEBG3exwpasO5fUMrZhcLT51qMLy25jkezZrAVhmb2NBg==", "06/30-152-5123", false, "af2c4768-0c58-4c09-963e-37a5dddd1641", false, "kbela" },
                    { "admin", 0, "98873fe4-723f-49c8-b4a6-09b53cea8f80", "admin@tourrento.hu", true, false, null, "Admin", "ADMIN@TOURRENTO.HU", "ADMIN", "AQAAAAEAACcQAAAAEOiFsY/ie2QZR3g8Z6XfFPcVcPnahz2g4LTT2N4c7H7yIVToOh35sADw053mMs4dCw==", "06/30-152-5123", false, "99edf23c-f1e9-47cb-a10d-63a55dbf4afc", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 5, "Túrafelszerelés", null },
                    { 6, "Sétabot", 5 },
                    { 7, "Bicikli", null },
                    { 8, "Görkorcsolya", null },
                    { 9, "Egyéb felszerelés", null },
                    { 10, "Tandem", 7 },
                    { 1, "Védőfelszerelés", null },
                    { 2, "Mászófelszerelés", null },
                    { 3, "Ejtőernyő", null },
                    { 4, "Búvárruha", 1 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "FeePerDay", "ImageName", "InStock", "Name", "Price" },
                values: new object[,]
                {
                    { 10, "A hideg vízben a nedvesruha extra melegen tarthatja a testet. A búvárruhák működési elve az, hogy amikor a víz belép a ruhákba, majd egy vékony vizes réteget hagy a testen. akkor a test folyamatosan mozog, hogy hőt termeljen, melegedjen és melegen tartsa a testet.", 10000, "item10.jpg", 7, "ZCCO Férfi Szörfoverall - XL", 5990 },
                    { 9, "Széles gumiabroncsok - amortizációként szolgálhatnak, ami azt jelenti, hogy a legtöbb akadály gyakorlatilag észrevehetetlen. A tárcsára gyakorolt ​​erő sokkal nagyobb, ami csökkenti a féktávolságot.", 6400, "item9.jpg", 17, "Blank 2021 Tyro 20 Inch Bike Steel Grey", 3690 },
                    { 8, "Akár sátorozni mész a természetbe, vagy akár csak fel akarsz \"fegyverkezni\" a hétköznapokban előforduló vészhelyzetekre, ez a kompakt Túlélőfelszerelés garantáltan megfelelő társad lesz. Ebben a könyvméretű csomagban összpontosul a 8 legfontosabb eszköz, amire szükséged lehet egy - egy kaland során.Méretéből adódóan pedig akkora, hogy simán elfér a hátizsákodban vagy az autó kesztyűtartójában.", 4500, "item8.jpg", 11, "Túlélő felszerelés készlet", 2390 },
                    { 7, "3 m hosszú, 12 mm átmérőjű, körszövött, statikus poliamid kötél • félautomata hossz-szabályzó egység • mechanikai sérülések elleni védőtömlő • egy csavarmenetes, egy rugós karabiner • EU szabvány: EN358.", 1450, "item7.jpg", 41, "Kötél karabinerrel", 990 },
                    { 5, "A Offroad XC Trainer 150 Görkorcsolya a legjobb választásnak bizonyul azok számára, akik nem ragaszkodnak a járdák által megszabott útvonalakhoz. Az alumínium váz rendkívül könnyű és jó irányíthatóságot ad.", 3250, "item5.jpg", 24, "Powerslide Offroad XC Trainer 150 Terep Görkorcsolya", 1490 },
                    { 4, "A 250W extra teljesítménnyel az elektromos rásegítés kiegészíti a pedálozást, hogy megküzdj az akadályokkal. Tovább élvezheted a hegyi kerékpározást. A motor leáll, amint abbahagyod a pedálozást.", 4000, "item4.jpg", 3, "Neuzer Nelson 18 Férfi Mountain Bike bicikli", 1590 },
                    { 2, "Óvja biztonságát biciklizés vagy görkorcsolyázás közben! Brit tudósok által tesztelt, teljes védelmet biztosít esés esetén.", 1500, "item2.jpg", 27, "GroundedZero bukósisak - felnőtt", 990 },
                    { 1, "Ez a kétszemélyes bicikli megfelelő a túrázáshoz. Könnyen tekerhető és írányítható, ami nagyszerű élményt biztosít.", 5000, "item1.jpg", 4, "Xemrot Tandem bicikli v2.0", 3000 },
                    { 6, "A sétabot kiváló minőségű alumíniumból készült. Egyszerűen elfogható, és a végén csúszásgátló járóbot gumi van, amely biztonságos és zajmentes használatot tesz lehetővé.", 1550, "item6.jpg", 28, "Fa fogantyús sétabot - fekete", 990 },
                    { 3, "Válaszd a legnagyobb biztonságú és hatékonyságú ejtőernyőt. Dupla öltésű varratok ragasztott menettel. Megerősítés a kulcsfontosságú területeken az extra tartósság érdekében.", 3500, "item3.jpg", 20, "Skydiver x20 ejtőernyő", 1990 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Idegenvezetés" },
                    { 2, "Étkezés biztosítása" },
                    { 3, "Alvás lehetőség" },
                    { 4, "Orvosi ellátás" },
                    { 5, "Szükséges eszközök biztosítása" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "Admin", "admin" },
                    { "Felhasznaló", "seedthree" },
                    { "Felhasznaló", "seedtwo" },
                    { "Szervező", "seedone" }
                });

            migrationBuilder.InsertData(
                table: "ItemCarts",
                columns: new[] { "ItemId", "UserId", "Quantity" },
                values: new object[,]
                {
                    { 6, "seedthree", 1 },
                    { 9, "seedthree", 2 },
                    { 10, "seedthree", 2 },
                    { 2, "seedthree", 3 },
                    { 8, "seedtwo", 3 },
                    { 3, "seedtwo", 2 },
                    { 5, "seedtwo", 1 },
                    { 1, "seedtwo", 2 }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "CategoryId", "ItemId" },
                values: new object[,]
                {
                    { 4, 10 },
                    { 10, 1 },
                    { 7, 9 },
                    { 1, 2 },
                    { 3, 3 },
                    { 7, 4 },
                    { 8, 5 },
                    { 5, 6 },
                    { 1, 10 },
                    { 2, 7 },
                    { 6, 6 },
                    { 5, 8 },
                    { 9, 8 },
                    { 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "Rents",
                columns: new[] { "Id", "AcceptContract", "RentalDate", "TotalPrice", "UntilDate", "UserId" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2021, 6, 16, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(9687), new TimeSpan(0, 2, 0, 0, 0)), 2000, new DateTimeOffset(new DateTime(2021, 6, 17, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, 2, 0, 0, 0)), "seedtwo" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 6, 16, 18, 10, 0, 671, DateTimeKind.Unspecified).AddTicks(576), new TimeSpan(0, 2, 0, 0, 0)), 1000, new DateTimeOffset(new DateTime(2021, 6, 17, 18, 10, 0, 671, DateTimeKind.Unspecified).AddTicks(579), new TimeSpan(0, 2, 0, 0, 0)), "seedtwo" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 6, 16, 18, 10, 0, 671, DateTimeKind.Unspecified).AddTicks(582), new TimeSpan(0, 2, 0, 0, 0)), 5000, new DateTimeOffset(new DateTime(2021, 6, 17, 18, 10, 0, 671, DateTimeKind.Unspecified).AddTicks(585), new TimeSpan(0, 2, 0, 0, 0)), "seedthree" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 6, 16, 18, 10, 0, 671, DateTimeKind.Unspecified).AddTicks(561), new TimeSpan(0, 2, 0, 0, 0)), 3000, new DateTimeOffset(new DateTime(2021, 6, 17, 18, 10, 0, 671, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, 2, 0, 0, 0)), "seedthree" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatorId", "Description", "EndDate", "ImageName", "MaxNumberOfPeople", "Name", "Price", "StartDate", "FinalLocation_City", "FinalLocation_Country", "FinalLocation_Street", "FinalLocation_ZipCode", "StartLocation_City", "StartLocation_Country", "StartLocation_Street", "StartLocation_ZipCode" },
                values: new object[,]
                {
                    { 4, "seedone", "A biciklizés során a fő célunk, hogy mindenki jól érezze magát. A túra során a pihenőkön közös programokat szervezünk, hogy a csapatot jobban összekovácsoljuk.", new DateTimeOffset(new DateTime(2021, 7, 20, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(2554), new TimeSpan(0, 2, 0, 0, 0)), "tour4.jpg", 12, "Hegyi biciklizés", 1800, new DateTimeOffset(new DateTime(2021, 7, 20, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(2548), new TimeSpan(0, 2, 0, 0, 0)), "Budapest", "Magyarország", "Mátyáshegyi út 57", 1037, "Budapest", "Magyarország", "Mátyáshegyi út 57", 1037 },
                    { 3, "seedone", "A több napos túra során rengeteg kalandban veszünk majd részt. Az étkezés és alvást a túra szervezői biztosítják.", new DateTimeOffset(new DateTime(2021, 8, 3, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 2, 0, 0, 0)), "tour3.jpg", 32, "Több napos túra", 42800, new DateTimeOffset(new DateTime(2021, 7, 24, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(2363), new TimeSpan(0, 2, 0, 0, 0)), "Budapest", "Magyarország", "Glück Frigyes út", 1025, "Budaörs", "Magyarország", "Mandula utca", 2040 },
                    { 1, "seedone", "Gyere el velünk a legjobb János-hegyi túrára! Ajánlott védőfelszerelés, mert a túra során mászásra is sor kerülhet.", new DateTimeOffset(new DateTime(2021, 7, 8, 18, 10, 0, 669, DateTimeKind.Unspecified).AddTicks(8359), new TimeSpan(0, 2, 0, 0, 0)), "tour1.jpg", 18, "János-hegyi túra", 2000, new DateTimeOffset(new DateTime(2021, 7, 7, 18, 10, 0, 668, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 2, 0, 0, 0)), "Budapest", "Magyarország", "Zugligeti út 110", 1121, "Budapest", "Magyarország", "Zugligeti út 110", 1121 },
                    { 2, "seedone", "Gyere el velünk a legjobb Gellért-hegyi túrára! Ajánlott védőfelszerelés, mert a túra során mászásra is sor kerülhet.", new DateTimeOffset(new DateTime(2021, 7, 19, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 2, 0, 0, 0)), "tour2.jpg", 30, "Gellért-hegyi túra", 1800, new DateTimeOffset(new DateTime(2021, 7, 19, 18, 10, 0, 670, DateTimeKind.Unspecified).AddTicks(2205), new TimeSpan(0, 2, 0, 0, 0)), "Budapest", "Magyarország", "Szent Gellért rkp. 16", 1013, "Budapest", "Magyarország", "Szent Gellért rkp. 16", 1013 }
                });

            migrationBuilder.InsertData(
                table: "ParticipateTours",
                columns: new[] { "TourId", "UserId", "IsPaid", "Price" },
                values: new object[,]
                {
                    { 1, "seedtwo", false, 1500 },
                    { 2, "seedthree", true, 1700 },
                    { 4, "seedthree", false, 1800 },
                    { 3, "seedtwo", true, 1200 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Answer", "Question", "QuestionerId", "TourId" },
                values: new object[,]
                {
                    { 8, null, "Gyerekek is résztvehetnek az eseményen? A fiam szívesen jönne", "seedtwo", 4 },
                    { 4, "Nem, az ételről mindenki maga gondoskodik, de megfogunk állni a boltoknál ha szükséges.", "Az étkezés benne van az árban?", "seedthree", 4 },
                    { 1, null, "Hány megálló lesz, ahol pihenni lehet?", "seedtwo", 1 },
                    { 5, "Igen, így aki szeretne az vásárolhat magának frissítőket vagy ennivalót.", "Fogunk megállni bolt közelébe?", "seedthree", 1 },
                    { 7, "Igen, így aki szeretne az vásárolhat magának frissítőket vagy ennivalót.", "Fogunk megállni bolt közelébe?", "seedthree", 3 },
                    { 3, null, "Hány megálló lesz, ahol pihenni lehet?", "seedtwo", 3 },
                    { 2, "Nem, az ételről mindenki maga gondoskodik, de megfogunk állni a boltoknál ha szükséges.", "Az étkezés benne van az árban?", "seedthree", 2 },
                    { 6, null, "Gyerekek is résztvehetnek az eseményen? A fiam szívesen jönne", "seedtwo", 2 }
                });

            migrationBuilder.InsertData(
                table: "RentedItems",
                columns: new[] { "ItemId", "RentId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 9, 3, 2400, 1 },
                    { 6, 3, 3500, 2 },
                    { 2, 1, 3000, 2 },
                    { 4, 2, 4500, 2 },
                    { 7, 4, 2000, 2 }
                });

            migrationBuilder.InsertData(
                table: "RequiredCategoryTours",
                columns: new[] { "RequiredCategoryId", "TourId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 1 },
                    { 2, 1 },
                    { 5, 1 },
                    { 7, 4 },
                    { 1, 2 },
                    { 2, 2 },
                    { 5, 2 },
                    { 5, 4 },
                    { 2, 3 },
                    { 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "TourServices",
                columns: new[] { "ServiceId", "TourId" },
                values: new object[,]
                {
                    { 4, 3 },
                    { 3, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 4, 4 },
                    { 2, 1 },
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 2 },
                    { 5, 3 }
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
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCarts_UserId",
                table: "ItemCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategories_CategoryId",
                table: "ItemCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipateTours_UserId",
                table: "ParticipateTours",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_QuestionerId",
                table: "Posts",
                column: "QuestionerId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TourId",
                table: "Posts",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedItems_RentId",
                table: "RentedItems",
                column: "RentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserId",
                table: "Rents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredCategoryTours_TourId",
                table: "RequiredCategoryTours",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CreatorId",
                table: "Tours",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_TourServices_ServiceId",
                table: "TourServices",
                column: "ServiceId");
        }

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
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "ItemCarts");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "ParticipateTours");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "RentedItems");

            migrationBuilder.DropTable(
                name: "RequiredCategoryTours");

            migrationBuilder.DropTable(
                name: "TourServices");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

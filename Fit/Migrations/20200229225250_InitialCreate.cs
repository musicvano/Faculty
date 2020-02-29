using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Fit.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NameEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fundings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fundings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Acronym = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    FacultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    FacultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    House = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buildings_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buildings_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstNameEn = table.Column<string>(nullable: true),
                    MiddleNameEn = table.Column<string>(nullable: true),
                    LastNameEn = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    PassportSerial = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    TaxId = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    House = table.Column<string>(nullable: true),
                    Appartment = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    PositionId = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true),
                    DegreeId = table.Column<int>(nullable: true),
                    RankId = table.Column<int>(nullable: true),
                    OrcidId = table.Column<string>(nullable: true),
                    ScopusId = table.Column<string>(nullable: true),
                    ScholarId = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstNameEn = table.Column<string>(nullable: true),
                    MiddleNameEn = table.Column<string>(nullable: true),
                    LastNameEn = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    PassportSerial = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    TaxId = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    House = table.Column<string>(nullable: true),
                    Appartment = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    GradeBook = table.Column<string>(nullable: true),
                    FundingId = table.Column<int>(nullable: true),
                    StudyId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    SpecialtyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Fundings_FundingId",
                        column: x => x.FundingId,
                        principalTable: "Fundings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Studies_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Studies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    BuildingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    House = table.Column<string>(nullable: true),
                    Appartment = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    StudentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relatives_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relatives_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relatives_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relatives_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "CityId", "CountryId", "House", "Name", "PostCode", "RegionId", "Street" },
                values: new object[,]
                {
                    { 1, null, null, null, "Центральний корпус", null, null, null },
                    { 2, null, null, null, "Будівельний корпус", null, null, null },
                    { 3, null, null, null, "Гірничий корпус", null, null, null },
                    { 4, null, null, null, "Трампарк-корпус", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Київ" },
                    { 2, "Харків" },
                    { 3, "Дніпро" },
                    { 4, "Кривий Ріг" },
                    { 5, "Львів" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "UA", "Україна" });

            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 37, "Д-р мед. наук", "Доктор медичних наук" },
                    { 36, "Д-р культ.", "Доктор культурології" },
                    { 35, "Д-р іст. наук", "Доктор історичних наук" },
                    { 34, "Д-р екон. наук", "Доктор економічних наук" },
                    { 29, "Д-р вет. наук", "Доктор ветеринарних наук" },
                    { 32, "Д-р геолог. наук", "Доктор геологічних наук" },
                    { 31, "Д-р географ. наук", "Доктор географічних наук" },
                    { 30, "Д-р військ. наук", "Доктор військових наук" },
                    { 38, "Д-р мист.", "Доктор мистецтвознавства" },
                    { 33, "Д-р держ. упр.", "Доктор наук з державного управління" },
                    { 39, "Д-р пед. наук", "Доктор педагогічних наук" },
                    { 44, "Д-р соціол. наук", "Доктор соціологічних наук" },
                    { 41, "Д-р психол. наук", "Доктор психологічних наук" },
                    { 42, "Д-р с.-г. наук", "Доктор сільськогосподарських наук" },
                    { 43, "Д-р соц. ком.", "Доктор наук із соціальних комунікацій" },
                    { 28, "Д-р біол. наук", "Доктор біологічних наук" },
                    { 45, "Д-р техн. наук", "Доктор технічних наук" },
                    { 47, "Д-р фармац. наук", "Доктор фармацевтичних наук" },
                    { 48, "Д-р фіз. виховання і спорту", "Доктор наук з фізичного виховання і спорту" },
                    { 49, "Д-р філол. наук", "Доктор філологічних наук" },
                    { 50, "Д-р філос. наук", "Доктор філософських наук" },
                    { 51, "Д-р хім. наук", "Доктор хімічних наук" },
                    { 52, "Д-р юрид. наук", "Доктор юридичних наук" },
                    { 40, "Д-р політ. наук", "Доктор політичних наук" },
                    { 27, "Д-р арх.", "Доктор архітектури" },
                    { 46, "Д-р фіз.-мат. наук", "Доктор фізико-математичних наук" },
                    { 25, "Канд. хім. наук", "Кандидат хімічних наук" },
                    { 1, "Канд. арх.", "Кандидат архітектури" },
                    { 2, "Канд. біол. наук", "Кандидат біологічних наук" },
                    { 3, "Канд. вет. наук", "Кандидат ветеринарних наук" },
                    { 4, "Канд. військ. наук", "Кандидат військових наук" },
                    { 5, "Канд. географ. наук", "Кандидат географічних наук" },
                    { 6, "Канд. геолог. наук", "Кандидат геологічних наук" },
                    { 26, "Канд. юрид. наук", "Кандидат юридичних наук" },
                    { 7, "Канд. держ. упр.", "Кандидат наук з державного управління" },
                    { 8, "Канд. екон. наук", "Кандидат економічних наук" },
                    { 9, "Канд. іст. наук", "Кандидат історичних наук" },
                    { 10, "Канд. культ.", "Кандидат культурології" },
                    { 12, "Канд. мист.", "Кандидат мистецтвознавства" },
                    { 11, "Канд. мед. наук", "Кандидат медичних наук" },
                    { 14, "Канд. політ. наук", "Кандидат політичних наук" },
                    { 15, "Канд. психол. наук", "Кандидат психологічних наук" },
                    { 16, "Канд. с.-г. наук", "Кандидат сільськогосподарських наук" },
                    { 17, "Канд. соц. ком.", "Кандидат наук із соціальних комунікацій" },
                    { 18, "Канд. соціол. наук", "Кандидат соціологічних наук" },
                    { 19, "Канд. техн. наук", "Кандидат технічних наук" },
                    { 20, "Канд. фіз.-мат. наук", "Кандидат фізико-математичних наук" },
                    { 21, "Канд. фармац. наук", "Кандидат фармацевтичних наук" },
                    { 22, "Канд. фіз. виховання і спорту", "Кандидат наук з фізичного виховання і спорту" },
                    { 23, "Канд. філол. наук", "Кандидат філологічних наук" },
                    { 24, "Канд. філос. наук", "Кандидат філософських наук" },
                    { 13, "Канд. пед. наук", "Кандидат педагогічних наук" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 6, "ТФ", "Транспортний факультет" },
                    { 8, "ФІТФ", "Факультет інформаційних технологій" },
                    { 7, "ФЕУБ", "Факультет економіки та управління бізнесом" },
                    { 5, "ММФ", "Механіко-машинобудівний факультет" },
                    { 2, "ГЕФ", "Геолого-екологічний факультет" },
                    { 3, "ГМФ", "Гірничо-металургійний факультет" },
                    { 1, "БФ", "Будівельний факультет" },
                    { 4, "ЕТФ", "Електротехнічний факультет" }
                });

            migrationBuilder.InsertData(
                table: "Fundings",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 1, "Б", "Бюджет" },
                    { 2, "К", "Контракт" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { 60, null, "КІ-18" },
                    { 59, null, "КІ-17" },
                    { 58, null, "КІ-16-2" },
                    { 57, null, "КІ-16-1" },
                    { 56, null, "ІПЗ-19ск" },
                    { 55, null, "ІПЗ-19м" },
                    { 54, null, "ІПЗ-19-2" },
                    { 53, null, "ІПЗ-19-1" },
                    { 50, null, "ІПЗ-18-2" },
                    { 51, null, "ІПЗ-18м" },
                    { 49, null, "ІПЗ-18-1" },
                    { 48, null, "ІПЗ-17ск" },
                    { 47, null, "ІПЗ-17-2" },
                    { 46, null, "ІПЗ-17-1" },
                    { 44, null, "ІПЗ-16-1" },
                    { 45, null, "ІПЗ-16-2" },
                    { 61, null, "КІ-18м" },
                    { 52, null, "ІПЗ-18ск" },
                    { 62, null, "КІ-19" },
                    { 80, null, "ПОКТ-19м-прх" },
                    { 64, null, "КН-16" },
                    { 43, null, "ЗПОКТ-19м-прх" },
                    { 81, null, "ПОКТ-19ск" },
                    { 79, null, "ПОКТ-19м" },
                    { 78, null, "ПОКТ-19" },
                    { 77, null, "ПОКТ-18ск" },
                    { 76, null, "ПОКТ-18м" },
                    { 75, null, "ПОКТ-18" },
                    { 74, null, "ПОКТ-17ск" },
                    { 73, null, "ПОКТ-17" },
                    { 72, null, "ПОКТ-16" },
                    { 71, null, "ПОЕЕ-19ск" },
                    { 70, null, "ПОЕЕ-19" },
                    { 69, null, "ПОЕЕ-17" },
                    { 68, null, "КН-19м" },
                    { 67, null, "КН-19" },
                    { 66, null, "КН-18" },
                    { 65, null, "КН-17" },
                    { 63, null, "КІ-19м" },
                    { 42, null, "ЗПОКТ-19м" },
                    { 26, null, "ЗІПЗ-19м" },
                    { 40, null, "ЗПОКТ-18" },
                    { 16, null, "ЗАКІТ-19" },
                    { 15, null, "ЗАКІТ-18м-прх" },
                    { 14, null, "ЗАКІТ-18м" },
                    { 13, null, "ЗАКІТ-18" },
                    { 12, null, "ЗАКІТ-17" },
                    { 11, null, "ЗАКІТ-16" },
                    { 10, null, "АКІТ-19ск" },
                    { 9, null, "АКІТ-19м-прх" },
                    { 8, null, "АКІТ-19м" },
                    { 7, null, "АКІТ-19" },
                    { 6, null, "АКІТ-18ск" },
                    { 5, null, "АКІТ-18м-прх" },
                    { 4, null, "АКІТ-18м" },
                    { 3, null, "АКІТ-18" },
                    { 2, null, "АКІТ-17" },
                    { 1, null, "АКІТ-16" },
                    { 41, null, "ЗПОКТ-18м-прх" },
                    { 17, null, "ЗАКІТ-19м" },
                    { 18, null, "ЗАКІТ-19м-прх" },
                    { 19, null, "ЗАКІТ-19ск" },
                    { 30, null, "ЗКІ-18м" },
                    { 36, null, "ЗПО-19" },
                    { 35, null, "ЗКН-19м" },
                    { 34, null, "ЗКН-19" },
                    { 33, null, "ЗКН-18" },
                    { 32, null, "ЗКІ-19м" },
                    { 31, null, "ЗКІ-19" },
                    { 20, null, "ЗІПЗ-16" },
                    { 37, null, "ЗПОЕЕ-16" },
                    { 29, null, "ЗКІ-17" },
                    { 27, null, "ЗІПЗ-19м-прх" },
                    { 39, null, "ЗПОКТ-17" },
                    { 25, null, "ЗІПЗ-19" },
                    { 24, null, "ЗІПЗ-18м-прх" },
                    { 23, null, "ЗІПЗ-18м" },
                    { 22, null, "ЗІПЗ-18" },
                    { 21, null, "ЗІПЗ-17" },
                    { 28, null, "ЗКІ-16" },
                    { 38, null, "ЗПОКТ-16" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 6, "В. о. завкаф.", "В. о. завідувача кафедри" },
                    { 7, "Завкаф.", "Завідувач кафедри" },
                    { 5, "Проф.", "Професор" },
                    { 1, "Асист.", "Асистент" },
                    { 3, "Старш. викл.", "Старший викладач" },
                    { 4, "Доц.", "Доцент" },
                    { 2, "Викл.", "Викладач" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 1, "Доц.", "Доцент" },
                    { 2, "Проф.", "Професор" },
                    { 3, "Старш. дослідник", "Старший дослідник" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 25, "Чернігівська обл.", "Чернігівська область" },
                    { 24, "Чернівецька обл.", "Чернівецька область" },
                    { 23, "Черкаська обл.", "Черкаська область" },
                    { 14, "Миколаївська обл.", "Миколаївська область" },
                    { 21, "Херсонська обл.", "Херсонська область" },
                    { 20, "Харківська обл.", "Харківська область" },
                    { 19, "Тернопільська обл.", "Тернопільська область" },
                    { 18, "Сумська обл.", "Сумська область" },
                    { 17, "Рівненська обл.", "Рівненська область" },
                    { 16, "Полтавська обл.", "Полтавська область" },
                    { 15, "Одеська обл.", "Одеська область" },
                    { 22, "Хмельницька обл.", "Хмельницька область" },
                    { 13, "Львівська обл.", "Львівська область" },
                    { 11, "Кіровоградська обл.", "Кіровоградська область" },
                    { 1, "АРК", "Автономна Республіка Крим" },
                    { 12, "Луганська обл.", "Луганська область" },
                    { 3, "Волинська обл.", "Волинська область" },
                    { 4, "Дніпропетровська обл.", "Дніпропетровська область" },
                    { 5, "Донецька обл.", "Донецька область" },
                    { 2, "Вінницька обл.", "Вінницька область" },
                    { 7, "Закарпатська обл.", "Закарпатська область" },
                    { 8, "Запорізька обл.", "Запорізька область" },
                    { 9, "Івано-Франківська обл.", "Івано-Франківська область" },
                    { 10, "Київська обл.", "Київська область" },
                    { 6, "Житомирська обл.", "Житомирська область" }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "015", "Професійна освіта" },
                    { 2, "121", "Автоматизація та комп’ютерно-інтегровані технології" },
                    { 3, "122", "Інженерія програмного забезпечення" },
                    { 4, "123", "Комп’ютерні науки" },
                    { 5, "151", "Комп’ютерна інженерія" }
                });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "Id", "Acronym", "Name" },
                values: new object[,]
                {
                    { 1, "Д", "Денна форма" },
                    { 2, "З", "Заочна форма" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Acronym", "Email", "FacultyId", "Logo", "Name", "Phone", "Url" },
                values: new object[,]
                {
                    { 1, "Кафедра ПЦМБ", null, 1, null, "Кафедра промислового, цивільного і міського будівництва", null, null },
                    { 21, "Кафедра ГМО", null, 5, null, "Кафедра гірничих машин та обладнання", null, null },
                    { 22, "Кафедра АТ", null, 6, null, "Кафедра автомобільного транспорту", null, null },
                    { 23, "Кафедра ВМ", null, 6, null, "Кафедра вищої математики", null, null },
                    { 24, "Кафедра ФСН", null, 6, null, "Кафедра філософії і соціальних наук", null, null },
                    { 25, "Кафедра ФВ", null, 6, null, "Кафедра фізичного виховання", null, null },
                    { 26, "Кафедра ФСГІР", null, 7, null, "Кафедра фінансів суб’єктів господарювання та інноваційного розвитку", null, null },
                    { 20, "Кафедра ТМ", null, 5, null, "Кафедра технології машинобудування", null, null },
                    { 27, "Кафедра ООПУА", null, 7, null, "Кафедра обліку, оподаткування, публічного управління та адміністрування", null, null },
                    { 29, "Кафедра МіА", null, 7, null, "Кафедра менеджменту і адміністрування", null, null },
                    { 30, "Кафедра права", null, 7, null, "Кафедра права", null, null },
                    { 31, "Кафедра АКНТ", "aknt@knu.edu.ua", 8, "aknt.svg", "Кафедра автоматизації, комп’ютерних наук і технологій", "+380564090635", "aknt.knu.edu.ua" },
                    { 32, "Кафедра МПЗ", "mpz@knu.edu.ua", 8, "mpz.svg", "Кафедра моделювання і програмного забезпечення", "+380564090605", "mpz.knu.edu.ua" },
                    { 33, "Кафедра КСМ", "ksm@knu.edu.ua", 8, "ksm.svg", "Кафедра комп’ютерних систем та мереж", "+380564091720", "ksm.knu.edu.ua" },
                    { 34, "Кафедра ІПМП", "ipmp@knu.edu.ua", 8, "ipmp.svg", "Кафедра інженерної педагогіки та мовної підготовки", "+380564090607", "ipmp.knu.edu.ua" },
                    { 28, "Кафедра ЕОУП", null, 7, null, "Кафедра економіки, організації та управління підприємствами", null, null },
                    { 19, "Кафедра ПМЗД", null, 5, null, "Кафедра прикладної механіки та загальноінженерних дисциплін", null, null },
                    { 18, "Кафедра фізики", null, 4, null, "Кафедра фізики", null, null },
                    { 17, "Кафедра ТЕ", null, 4, null, "Кафедра теплоенергетики", null, null },
                    { 2, "Кафедра ТБВМВ", null, 1, null, "Кафедра технології будівельних виробів, матеріалів та конструкцій", null, null },
                    { 3, "Кафедра ТВВ", null, 1, null, "Кафедра теплогазoводопостачання, водовідведення і вентиляції", null, null },
                    { 4, "Кафедра ГПМ", null, 2, null, "Кафедра геології і прикладної мінералогії", null, null },
                    { 5, "Кафедра екол.", null, 2, null, "Кафедра екології", null, null },
                    { 6, "Кафедра геодез.", null, 2, null, "Кафедра геодезії", null, null },
                    { 7, "Кафедра ПРРКК", null, 3, null, "Кафедра підземної розробки родовищ корисних копалин", null, null },
                    { 8, "Кафедра ВГР", null, 3, null, "Кафедра відкритих гірничих робіт", null, null },
                    { 9, "Кафедра маркшейдерії", null, 3, null, "Кафедра маркшейдерії", null, null },
                    { 10, "Кафедра ОПЦБ", null, 3, null, "Кафедра охорони праці та цивільної безпеки", null, null },
                    { 11, "Кафедра БГ", null, 3, null, "Кафедра будівельних геотехнологій", null, null },
                    { 12, "Кафедра ЗККХ", null, 3, null, "Кафедра збагачення корисних копалин і хімії", null, null },
                    { 13, "Кафедра МЧМЛВ", null, 3, null, "Кафедра металургії чорних металів і ливарного виробництва", null, null },
                    { 14, "Кафедра АЕСПТ", null, 4, null, "Кафедра автоматизованих електромеханічних систем в промисловості та транспорті", null, null },
                    { 15, "Кафедра ЕЕМ", null, 4, null, "Кафедра електропостачання та енергетичного менеджменту", null, null },
                    { 16, "Кафедра ЕМ", null, 4, null, "Кафедра електромеханіки", null, null },
                    { 35, "Кафедра ІМ", "im@knu.edu.ua", 8, "im.svg", "Кафедра іноземних мов", "+380564090649", "im.knu.edu.ua" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Appartment", "Birthday", "CityId", "CountryId", "Email", "FirstName", "FirstNameEn", "FundingId", "GradeBook", "GroupId", "House", "LastName", "LastNameEn", "MiddleName", "MiddleNameEn", "PassportNumber", "PassportSerial", "Phone", "Photo", "PostCode", "RegionId", "SpecialtyId", "StatusId", "Street", "StudyId", "TaxId", "Telegram" },
                values: new object[] { new Guid("17fe8532-0b20-4e33-ac4c-f532ce7fb8aa"), "26", new DateTime(2000, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "ivanov@gmail.com", "Іван", "Ivan", 1, "123-17", 59, "15", "Іванов", "Ivanov", "Іванович", "Ivanovych", "012345", "AA", "+380961234567", "default.png", "50027", 4, 1, null, "Вул. Поштова", 1, "01234567890", "@ivanov" });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_CityId",
                table: "Buildings",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_CountryId",
                table: "Buildings",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_RegionId",
                table: "Buildings",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FacultyId",
                table: "Groups",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_CityId",
                table: "Relatives",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_CountryId",
                table: "Relatives",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_RegionId",
                table: "Relatives",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_StudentId",
                table: "Relatives",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BuildingId",
                table: "Rooms",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CityId",
                table: "Students",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CountryId",
                table: "Students",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FundingId",
                table: "Students",
                column: "FundingId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_RegionId",
                table: "Students",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SpecialtyId",
                table: "Students",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StatusId",
                table: "Students",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudyId",
                table: "Students",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CityId",
                table: "Teachers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CountryId",
                table: "Teachers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_DegreeId",
                table: "Teachers",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_DepartmentId",
                table: "Teachers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_PositionId",
                table: "Teachers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_RankId",
                table: "Teachers",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_RegionId",
                table: "Teachers",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Fundings");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Studies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}

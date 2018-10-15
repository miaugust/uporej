using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejupo.Migrations.FakeDb
{
    public partial class AuDocumentAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Abbreviation = table.Column<string>(nullable: false),
                    Descritption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ControlNumber = table.Column<string>(nullable: false),
                    Division = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ControlNumber);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDataAuthorizationScope",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Scope = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDataAuthorizationScope", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RejupoUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Division = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejupoUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizationToProcesPersonalDataDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: true),
                    CancelingDate = table.Column<DateTime>(nullable: true),
                    LastChangedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationToProcesPersonalDataDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorizationToProcesPersonalDataDocuments_Log_LastChangedId",
                        column: x => x.LastChangedId,
                        principalTable: "Log",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizationToProcesPersonalDataDocuments_Employee_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employee",
                        principalColumn: "ControlNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDataAuthorization_Document_Scope",
                columns: table => new
                {
                    DocumentId = table.Column<int>(nullable: false),
                    ScopeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDataAuthorization_Document_Scope", x => new { x.DocumentId, x.ScopeId });
                    table.ForeignKey(
                        name: "FK_PersonalDataAuthorization_Document_Scope_AuthorizationToProcesPersonalDataDocuments_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "AuthorizationToProcesPersonalDataDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDataAuthorization_Document_Scope_PersonalDataAuthorizationScope_ScopeId",
                        column: x => x.ScopeId,
                        principalTable: "PersonalDataAuthorizationScope",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationToProcesPersonalDataDocuments_LastChangedId",
                table: "AuthorizationToProcesPersonalDataDocuments",
                column: "LastChangedId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationToProcesPersonalDataDocuments_OwnerId",
                table: "AuthorizationToProcesPersonalDataDocuments",
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDataAuthorization_Document_Scope_ScopeId",
                table: "PersonalDataAuthorization_Document_Scope",
                column: "ScopeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "PersonalDataAuthorization_Document_Scope");

            migrationBuilder.DropTable(
                name: "RejupoUser");

            migrationBuilder.DropTable(
                name: "AuthorizationToProcesPersonalDataDocuments");

            migrationBuilder.DropTable(
                name: "PersonalDataAuthorizationScope");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejupo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorizationScopes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Scope = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationScopes", x => x.Id);
                });

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
                name: "Employees",
                columns: table => new
                {
                    ControlNumber = table.Column<string>(nullable: false),
                    Division = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Pos_title = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ControlNumber);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
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
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentBases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: true),
                    CancelingDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentBases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentBases_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
                        principalColumn: "ControlNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Document_Scopes",
                columns: table => new
                {
                    DocumentBaseId = table.Column<int>(nullable: false),
                    AuthorizationScopeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_Scopes", x => new { x.DocumentBaseId, x.AuthorizationScopeId });
                    table.ForeignKey(
                        name: "FK_Document_Scopes_AuthorizationScopes_AuthorizationScopeId",
                        column: x => x.AuthorizationScopeId,
                        principalTable: "AuthorizationScopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Document_Scopes_DocumentBases_DocumentBaseId",
                        column: x => x.DocumentBaseId,
                        principalTable: "DocumentBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_Scopes_AuthorizationScopeId",
                table: "Document_Scopes",
                column: "AuthorizationScopeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentBases_OwnerId",
                table: "DocumentBases",
                column: "OwnerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Document_Scopes");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "AuthorizationScopes");

            migrationBuilder.DropTable(
                name: "DocumentBases");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

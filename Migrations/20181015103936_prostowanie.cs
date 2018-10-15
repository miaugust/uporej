using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rejupo.Migrations
{
    public partial class prostowanie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_PersonalDataAuthorizationScope");

            migrationBuilder.DropTable(
                name: "AuthorizationToProcesPersonalData");

            migrationBuilder.CreateTable(
                name: "AuthorizationToProcesPersonalDataDocument",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: true),
                    CancelingDate = table.Column<DateTime>(nullable: true),
                    LastChangedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationToProcesPersonalDataDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorizationToProcesPersonalDataDocument_Logs_LastChangedId",
                        column: x => x.LastChangedId,
                        principalTable: "Logs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizationToProcesPersonalDataDocument_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
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
                        name: "FK_PersonalDataAuthorization_Document_Scope_AuthorizationToProc~",
                        column: x => x.DocumentId,
                        principalTable: "AuthorizationToProcesPersonalDataDocument",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDataAuthorization_Document_Scope_PersonalDataAuthori~",
                        column: x => x.ScopeId,
                        principalTable: "PersonalDataAuthorizationScopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationToProcesPersonalDataDocument_LastChangedId",
                table: "AuthorizationToProcesPersonalDataDocument",
                column: "LastChangedId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationToProcesPersonalDataDocument_OwnerId",
                table: "AuthorizationToProcesPersonalDataDocument",
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
                name: "PersonalDataAuthorization_Document_Scope");

            migrationBuilder.DropTable(
                name: "AuthorizationToProcesPersonalDataDocument");

            migrationBuilder.CreateTable(
                name: "AuthorizationToProcesPersonalData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CancelingDate = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastChangedId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    ValidTo = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationToProcesPersonalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorizationToProcesPersonalData_Logs_LastChangedId",
                        column: x => x.LastChangedId,
                        principalTable: "Logs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizationToProcesPersonalData_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
                        principalColumn: "ControlNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee_PersonalDataAuthorizationScope",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(nullable: false),
                    ScopeId = table.Column<int>(nullable: false),
                    AuthorizationToProcesPersonalDataId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_PersonalDataAuthorizationScope", x => new { x.EmployeeId, x.ScopeId });
                    table.ForeignKey(
                        name: "FK_Employee_PersonalDataAuthorizationScope_AuthorizationToProce~",
                        column: x => x.AuthorizationToProcesPersonalDataId,
                        principalTable: "AuthorizationToProcesPersonalData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_PersonalDataAuthorizationScope_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "ControlNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_PersonalDataAuthorizationScope_PersonalDataAuthoriz~",
                        column: x => x.ScopeId,
                        principalTable: "PersonalDataAuthorizationScopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationToProcesPersonalData_LastChangedId",
                table: "AuthorizationToProcesPersonalData",
                column: "LastChangedId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationToProcesPersonalData_OwnerId",
                table: "AuthorizationToProcesPersonalData",
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonalDataAuthorizationScope_AuthorizationToProce~",
                table: "Employee_PersonalDataAuthorizationScope",
                column: "AuthorizationToProcesPersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonalDataAuthorizationScope_ScopeId",
                table: "Employee_PersonalDataAuthorizationScope",
                column: "ScopeId");
        }
    }
}

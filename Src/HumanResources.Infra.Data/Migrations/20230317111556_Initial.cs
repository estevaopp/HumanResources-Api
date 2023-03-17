using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResources.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HcmEmployeeRoleEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HcmEmployeeRoleEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlySalaryFixed = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    MonthlySalaryVariable = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    EmployeeStatus = table.Column<int>(type: "int", nullable: false),
                    EmploymentStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmploymentEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeSeniority = table.Column<int>(type: "int", nullable: false),
                    HcmEmployeeRoleEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeEntities_HcmEmployeeRoleEntities_HcmEmployeeRoleEntityId",
                        column: x => x.HcmEmployeeRoleEntityId,
                        principalTable: "HcmEmployeeRoleEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HcmPersonDetailEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeEntityId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HcmPersonDetailEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HcmPersonDetailEntities_EmployeeEntities_EmployeeEntityId",
                        column: x => x.EmployeeEntityId,
                        principalTable: "EmployeeEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEntities_HcmEmployeeRoleEntityId",
                table: "EmployeeEntities",
                column: "HcmEmployeeRoleEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_HcmPersonDetailEntities_EmployeeEntityId",
                table: "HcmPersonDetailEntities",
                column: "EmployeeEntityId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HcmPersonDetailEntities");

            migrationBuilder.DropTable(
                name: "EmployeeEntities");

            migrationBuilder.DropTable(
                name: "HcmEmployeeRoleEntities");
        }
    }
}

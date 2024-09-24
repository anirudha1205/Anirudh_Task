using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anirudh_Task.Migrations
{
    /// <inheritdoc />
    public partial class Task1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdType = table.Column<int>(type: "int", nullable: true),
                    IdNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KRA_PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHIF_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSSF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: true),
                    DateHired = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProbationFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProbationTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    EducationLevelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DesignationItemId = table.Column<int>(type: "int", nullable: true),
                    FamilyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstGuarantor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstGuarantorContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstGuarantorRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondGuarantor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondGuarantorContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondGuarantorRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextOfKinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextOfKinContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextOfKinRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpouseEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpouseMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanAccess = table.Column<bool>(type: "bit", nullable: false),
                    EmailVerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RememberToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLoanAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsAdvanceAllowed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

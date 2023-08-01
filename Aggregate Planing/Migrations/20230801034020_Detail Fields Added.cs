using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    /// <inheritdoc />
    public partial class DetailFieldsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Demand",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequiredOperators",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitPerOperador",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "actualOperators",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "businessDays",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "inventory",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "missingUnits",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "operatorsOff",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "operatorsUsed",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opertorsHired",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unitsAvailable",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unitsProduced",
                table: "AgreggationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Demand",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "RequiredOperators",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "UnitPerOperador",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "actualOperators",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "businessDays",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "inventory",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "missingUnits",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "operatorsOff",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "operatorsUsed",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "opertorsHired",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "unitsAvailable",
                table: "AgreggationDetails");

            migrationBuilder.DropColumn(
                name: "unitsProduced",
                table: "AgreggationDetails");
        }
    }
}

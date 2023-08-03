using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    /// <inheritdoc />
    public partial class AgreggationPlanfieldsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "costOfDismissing",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costOfHiring",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costToStore",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "dailyCosPerOver",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "hoursPerWeek",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "initialCurrentOperators",
                table: "AgreggationPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "initialInventory",
                table: "AgreggationPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "operatorAverage",
                table: "AgreggationPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "shortageCost",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "costOfDismissing",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "costOfHiring",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "costToStore",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "dailyCosPerOver",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "hoursPerWeek",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "initialCurrentOperators",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "initialInventory",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "operatorAverage",
                table: "AgreggationPlans");

            migrationBuilder.DropColumn(
                name: "shortageCost",
                table: "AgreggationPlans");
        }
    }
}

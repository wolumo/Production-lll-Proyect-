using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyAgregationDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "operatorAverage",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "initialInventory",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "initialCurrentOperators",
                table: "AgreggationPlans",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey("fk_idPlan","AgreggationDetails", "idPlan", "AgreggationPlans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "operatorAverage",
                table: "AgreggationPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "initialInventory",
                table: "AgreggationPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "initialCurrentOperators",
                table: "AgreggationPlans",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.DropForeignKey("fk_idPlan", "AgreggationDetails", "idPlan");

        }

    }
}

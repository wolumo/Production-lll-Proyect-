using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    /// <inheritdoc />
    public partial class DetailCostForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey("fk_idMonthCost", "AgreggationDetailsCosts", "idMonth", "Months" );
            migrationBuilder.AddForeignKey("fk_idPlanCost", "AgreggationDetailsCosts", "idPlan", "AgreggationPlans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("fk_idMonthCost", "AgreggationDetailsCosts", "idMonth");
            migrationBuilder.DropForeignKey("fk_idPlanCost", "AgreggationDetailsCosts", "idPlan");
        }
    }
}

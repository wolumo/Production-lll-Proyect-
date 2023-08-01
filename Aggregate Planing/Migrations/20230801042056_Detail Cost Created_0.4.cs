using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    /// <inheritdoc />
    public partial class DetailCostCreated_04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgreggationDetailsCosts",
                columns: table => new
                {
                    AgregationDetailCostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPlan = table.Column<int>(type: "int", nullable: false),
                    idMonth = table.Column<int>(type: "int", nullable: false),
                    costToHires = table.Column<double>(type: "float", nullable: false),
                    costTolayingOff = table.Column<double>(type: "float", nullable: false),
                    costToLabour = table.Column<double>(type: "float", nullable: false),
                    costToStore = table.Column<double>(type: "float", nullable: false),
                    costForShortages = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgreggationDetailsCosts", x => x.AgregationDetailCostId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgreggationDetailsCosts");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aggregate_Planing.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeysFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
   
            //Constraint Name , Table , Atributte, TableReferences
            migrationBuilder.AddForeignKey("fk_idMonth", "AgreggationDetails", "idMonth", "Months");

        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
 
            migrationBuilder.DropForeignKey("fk_idMonth", "AgreggationDetails", "idMonth");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace KoningsSurveyApp.EfDBContext.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "SurveyTemplates",
                newName: "AnotherField");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnotherField",
                table: "SurveyTemplates",
                newName: "SupplierName");
        }
    }
}

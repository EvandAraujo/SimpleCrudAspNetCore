using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleCrudBackEndNetCore.Infra.Migrations
{
    public partial class FixTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Person",
                schema: "bdo",
                newName: "Person",
                newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bdo");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "dbo",
                newName: "Person",
                newSchema: "bdo");
        }
    }
}

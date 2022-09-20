using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleCrudBackEndNetCore.Infra.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "bdo");

            migrationBuilder.CreateTable(
                name: "BrazilianUf",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Uf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UfCode = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrazilianUf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "bdo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZoneInformationPostalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PublicPlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrazilianUfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_BrazilianUf_BrazilianUfId",
                        column: x => x.BrazilianUfId,
                        principalSchema: "dbo",
                        principalTable: "BrazilianUf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BrazilianUf",
                columns: new[] { "Id", "Country", "Name", "Uf", "UfCode" },
                values: new object[,]
                {
                    { new Guid("02b4f971-6c52-4d7c-a438-9914c3c6a89b"), "BR", "Piauí", "PI", 22 },
                    { new Guid("0679caf3-a9f4-4ab5-9872-a74aa69ab97d"), "BR", "Goiás", "GO", 52 },
                    { new Guid("085f7465-387a-42d5-a4b5-82e5be81ca7c"), "BR", "Amazonas", "AM", 13 },
                    { new Guid("1207c116-bf8c-41b2-9cfa-b28c42371ff3"), "BR", "Pará", "PA", 15 },
                    { new Guid("156c834a-7300-4c7b-8a45-a87df774f900"), "BR", "Rondônia", "RO", 11 },
                    { new Guid("217c3406-b20a-4224-a243-94549accfbe3"), "BR", "Bahia", "BA", 29 },
                    { new Guid("276ad231-4150-4bca-9c6d-ff1181746e85"), "BR", "Paraíba", "PB", 25 },
                    { new Guid("2a3c6bf7-4044-445f-8a24-8b938d66c437"), "BR", "Pernambuco", "PE", 26 },
                    { new Guid("425b7437-cf6b-44e3-b708-c0fc869998d6"), "BR", "Maranhão", "MA", 21 },
                    { new Guid("4d46948c-c8d6-408b-847a-c98957a3df9f"), "BR", "Ceará", "CE", 23 },
                    { new Guid("5192f341-c245-43ed-9567-1ef291d53485"), "BR", "Roraima", "RR", 14 },
                    { new Guid("52a9afdb-ee0f-4008-875a-45bdb99ca7b0"), "BR", "São Paulo", "SP", 35 },
                    { new Guid("5cdc9548-9638-4b10-ab85-4e0058920110"), "BR", "Paraná", "PR", 41 },
                    { new Guid("6657eaf7-78f1-4f74-85e1-0944594adb22"), "BR", "Rio Grande do Norte", "RN", 24 },
                    { new Guid("6c92b0ef-9567-4d54-b0cc-02b7e041d53c"), "BR", "Rio Grande do Sul", "RS", 43 },
                    { new Guid("790e3c57-596d-46db-98fc-0eb1fbd16516"), "BR", "Amapá", "AP", 16 },
                    { new Guid("9d9e728f-02bd-4260-95a5-8df655d434d0"), "BR", "Acre", "AC", 12 },
                    { new Guid("a073ffd3-36f0-410b-96de-c26e838e5249"), "BR", "Santa Catarina", "SC", 42 },
                    { new Guid("a7b033f0-6376-4c05-8438-899e87b2b71e"), "BR", "Mato Grosso", "MT", 51 },
                    { new Guid("b53b6ae9-87d8-4d9f-94fc-a7e01ca1b6ae"), "BR", "Minas Gerais", "MG", 31 },
                    { new Guid("c69ed4b3-54c0-456c-a2e0-56b1300120c4"), "BR", "Rio de Janeiro", "RJ", 33 },
                    { new Guid("cd0c5d23-d0cd-4663-a829-79e98a0aa5e0"), "BR", "Mato Grosso do Sul", "MS", 50 },
                    { new Guid("cd8c355e-992b-4d84-bbd9-87e388294772"), "BR", "Alagoas", "AL", 27 },
                    { new Guid("e0ff5f07-eec9-4161-9657-5c38dd230dd3"), "BR", "Tocantins", "TO", 17 },
                    { new Guid("e40c2b75-93ef-47e4-9b9d-ff302d2f04d6"), "BR", "Distrito Federal", "DF", 53 },
                    { new Guid("e6dc1a76-56ff-4462-a5d5-6b8c5eac2d5c"), "BR", "Sergipe", "SE", 28 },
                    { new Guid("e8eeba35-7581-4b54-9ee6-6fabd7a5dfb1"), "BR", "Espírito Santo", "ES", 32 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_BrazilianUfId",
                schema: "bdo",
                table: "Person",
                column: "BrazilianUfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person",
                schema: "bdo");

            migrationBuilder.DropTable(
                name: "BrazilianUf",
                schema: "dbo");
        }
    }
}

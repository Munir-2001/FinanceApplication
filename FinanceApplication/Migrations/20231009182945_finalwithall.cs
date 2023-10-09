using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApplication.Migrations
{
    /// <inheritdoc />
    public partial class finalwithall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tratype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entityfortransId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    domainfortransId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    dt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transaction_domain_domainfortransId",
                        column: x => x.domainfortransId,
                        principalTable: "domain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaction_entities_entityfortransId",
                        column: x => x.entityfortransId,
                        principalTable: "entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transaction_domainfortransId",
                table: "transaction",
                column: "domainfortransId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_entityfortransId",
                table: "transaction",
                column: "entityfortransId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaction");

            migrationBuilder.DropTable(
                name: "entities");
        }
    }
}

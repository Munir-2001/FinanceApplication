using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApplication.Migrations
{
    /// <inheritdoc />
    public partial class munirlatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_domain_entitymodellists_entitymodellistsId",
                table: "domain");

            migrationBuilder.DropForeignKey(
                name: "FK_entities_entitymodellists_entitymodellistsId",
                table: "entities");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entitymodellists_eId",
                table: "transaction");

            migrationBuilder.DropTable(
                name: "entitymodellists");

            migrationBuilder.DropIndex(
                name: "IX_transaction_eId",
                table: "transaction");

            migrationBuilder.DropIndex(
                name: "IX_entities_entitymodellistsId",
                table: "entities");

            migrationBuilder.DropIndex(
                name: "IX_domain_entitymodellistsId",
                table: "domain");

            migrationBuilder.DropColumn(
                name: "eId",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "entitymodellistsId",
                table: "entities");

            migrationBuilder.DropColumn(
                name: "entitymodellistsId",
                table: "domain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "eId",
                table: "transaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "entitymodellistsId",
                table: "entities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "entitymodellistsId",
                table: "domain",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "entitymodellists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entitymodellists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transaction_eId",
                table: "transaction",
                column: "eId");

            migrationBuilder.CreateIndex(
                name: "IX_entities_entitymodellistsId",
                table: "entities",
                column: "entitymodellistsId");

            migrationBuilder.CreateIndex(
                name: "IX_domain_entitymodellistsId",
                table: "domain",
                column: "entitymodellistsId");

            migrationBuilder.AddForeignKey(
                name: "FK_domain_entitymodellists_entitymodellistsId",
                table: "domain",
                column: "entitymodellistsId",
                principalTable: "entitymodellists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_entities_entitymodellists_entitymodellistsId",
                table: "entities",
                column: "entitymodellistsId",
                principalTable: "entitymodellists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_entitymodellists_eId",
                table: "transaction",
                column: "eId",
                principalTable: "entitymodellists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

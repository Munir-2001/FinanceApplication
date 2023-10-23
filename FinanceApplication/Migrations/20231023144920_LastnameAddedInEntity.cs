using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApplication.Migrations
{
    /// <inheritdoc />
    public partial class LastnameAddedInEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaction_domain_domainfortransId",
                table: "transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_transaction_entities_entityfortransId",
                table: "transaction");

            migrationBuilder.DropIndex(
                name: "IX_transaction_domainfortransId",
                table: "transaction");

            migrationBuilder.DropIndex(
                name: "IX_transaction_entityfortransId",
                table: "transaction");

            migrationBuilder.RenameColumn(
                name: "entityfortransId",
                table: "transaction",
                newName: "entityfortrans");

            migrationBuilder.RenameColumn(
                name: "domainfortransId",
                table: "transaction",
                newName: "domainfortrans");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "entities",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "entities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "entities");

            migrationBuilder.RenameColumn(
                name: "entityfortrans",
                table: "transaction",
                newName: "entityfortransId");

            migrationBuilder.RenameColumn(
                name: "domainfortrans",
                table: "transaction",
                newName: "domainfortransId");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "entities",
                newName: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_domainfortransId",
                table: "transaction",
                column: "domainfortransId");

            migrationBuilder.CreateIndex(
                name: "IX_transaction_entityfortransId",
                table: "transaction",
                column: "entityfortransId");

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_domain_domainfortransId",
                table: "transaction",
                column: "domainfortransId",
                principalTable: "domain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaction_entities_entityfortransId",
                table: "transaction",
                column: "entityfortransId",
                principalTable: "entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

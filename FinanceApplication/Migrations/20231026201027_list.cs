using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceApplication.Migrations
{
    /// <inheritdoc />
    public partial class list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "domainfortrans",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "entityfortrans",
                table: "transaction");

            migrationBuilder.AddColumn<string>(
                name: "dom",
                table: "transaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ent",
                table: "transaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dom",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "ent",
                table: "transaction");

            migrationBuilder.AddColumn<Guid>(
                name: "domainfortrans",
                table: "transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "entityfortrans",
                table: "transaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}

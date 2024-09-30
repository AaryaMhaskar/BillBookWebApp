using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillBookSystem.Migrations
{
    /// <inheritdoc />
    public partial class summmm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_salesdetails",
                table: "salesdetails");

            migrationBuilder.RenameColumn(
                name: "BillTo",
                table: "salesdetails",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "salesdetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "PartyName",
                table: "salesdetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Profit",
                table: "salesdetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesdetails",
                table: "salesdetails",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "salessummary",
                columns: table => new
                {
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    PartyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salessummary", x => x.InvoiceDate);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "salessummary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesdetails",
                table: "salesdetails");

            migrationBuilder.DropColumn(
                name: "PartyName",
                table: "salesdetails");

            migrationBuilder.DropColumn(
                name: "Profit",
                table: "salesdetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "salesdetails",
                newName: "BillTo");

            migrationBuilder.AlterColumn<int>(
                name: "BillTo",
                table: "salesdetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesdetails",
                table: "salesdetails",
                column: "Amount");
        }
    }
}

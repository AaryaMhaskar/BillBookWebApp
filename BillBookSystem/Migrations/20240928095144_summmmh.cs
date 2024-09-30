using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillBookSystem.Migrations
{
    /// <inheritdoc />
    public partial class summmmh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sale",
                table: "sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inven",
                table: "inven");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invo",
                table: "invo");

            migrationBuilder.RenameTable(
                name: "invo",
                newName: "invoiced");

            migrationBuilder.AlterColumn<int>(
                name: "BillTo",
                table: "sale",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "sale",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "sale",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "inven",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceStatus",
                table: "invoiced",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sale",
                table: "sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inven",
                table: "inven",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invoiced",
                table: "invoiced",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sale",
                table: "sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_inven",
                table: "inven");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invoiced",
                table: "invoiced");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "sale");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "sale");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "inven");

            migrationBuilder.DropColumn(
                name: "InvoiceStatus",
                table: "invoiced");

            migrationBuilder.RenameTable(
                name: "invoiced",
                newName: "invo");

            migrationBuilder.AlterColumn<int>(
                name: "BillTo",
                table: "sale",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sale",
                table: "sale",
                column: "BillTo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_inven",
                table: "inven",
                column: "SalesPrice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invo",
                table: "invo",
                column: "Id");
        }
    }
}

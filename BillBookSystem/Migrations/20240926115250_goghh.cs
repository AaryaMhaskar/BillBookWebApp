using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillBookSystem.Migrations
{
    /// <inheritdoc />
    public partial class goghh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sale",
                table: "sale");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "sale");

            migrationBuilder.DropColumn(
                name: "InvoicedItemId",
                table: "sale");

            migrationBuilder.DropColumn(
                name: "ShopTo",
                table: "sale");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sale",
                table: "sale");

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

            migrationBuilder.AddColumn<int>(
                name: "InvoicedItemId",
                table: "sale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShopTo",
                table: "sale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sale",
                table: "sale",
                column: "Id");
        }
    }
}

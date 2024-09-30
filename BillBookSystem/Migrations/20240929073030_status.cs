using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillBookSystem.Migrations
{
    /// <inheritdoc />
    public partial class status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartyName",
                table: "salesdetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "salesdetails",
                newName: "BillTo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BillTo",
                table: "salesdetails",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "PartyName",
                table: "salesdetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillBookSystem.Migrations
{
    /// <inheritdoc />
    public partial class stahh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "status",
                newName: "Invoiceid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Invoiceid",
                table: "status",
                newName: "Id");
        }
    }
}

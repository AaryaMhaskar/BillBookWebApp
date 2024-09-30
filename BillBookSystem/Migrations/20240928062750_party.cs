using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BillBookSystem.Migrations
{
    /// <inheritdoc />
    public partial class party : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_invo",
                table: "invo");

            migrationBuilder.AlterColumn<int>(
                name: "SalesId",
                table: "invo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "invo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invo",
                table: "invo",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "party",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GSTINumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PANCardNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PartyTypeId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PartyCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreditPeriod = table.Column<int>(type: "int", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_party", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "party");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invo",
                table: "invo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "invo");

            migrationBuilder.AlterColumn<int>(
                name: "SalesId",
                table: "invo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invo",
                table: "invo",
                column: "SalesId");
        }
    }
}

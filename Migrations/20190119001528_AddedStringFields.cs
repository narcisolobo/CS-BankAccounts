using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccounts.Migrations
{
    public partial class AddedStringFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AmountString",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedAtString",
                table: "Transactions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountString",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CreatedAtString",
                table: "Transactions");
        }
    }
}

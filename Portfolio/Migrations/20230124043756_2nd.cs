using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_portfolios",
                table: "portfolios");

            migrationBuilder.RenameTable(
                name: "portfolios",
                newName: "Portfolio_Data");

            migrationBuilder.AddColumn<string>(
                name: "Proj_Description",
                table: "Portfolio_Data",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolio_Data",
                table: "Portfolio_Data",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolio_Data",
                table: "Portfolio_Data");

            migrationBuilder.DropColumn(
                name: "Proj_Description",
                table: "Portfolio_Data");

            migrationBuilder.RenameTable(
                name: "Portfolio_Data",
                newName: "portfolios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_portfolios",
                table: "portfolios",
                column: "Id");
        }
    }
}

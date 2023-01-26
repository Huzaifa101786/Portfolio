using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "portfolios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjName = table.Column<string>(name: "Proj_Name", type: "nvarchar(max)", nullable: false),
                    ProjType = table.Column<string>(name: "Proj_Type", type: "nvarchar(max)", nullable: false),
                    ProjLanguage = table.Column<string>(name: "Proj_Language", type: "nvarchar(max)", nullable: false),
                    Pic1 = table.Column<string>(name: "Pic_1", type: "nvarchar(max)", nullable: false),
                    Pic2 = table.Column<string>(name: "Pic_2", type: "nvarchar(max)", nullable: false),
                    Pic3 = table.Column<string>(name: "Pic_3", type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projcode = table.Column<string>(name: "proj_code", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_portfolios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "portfolios");
        }
    }
}

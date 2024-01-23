using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sehmus.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title2",
                table: "BlogSliders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "BlogSliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

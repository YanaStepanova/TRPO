using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRPO.Migrations
{
    /// <inheritdoc />
    public partial class lenadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "len",
                table: "products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "len",
                table: "products");
        }
    }
}

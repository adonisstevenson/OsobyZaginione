using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OsobyZaginione.Migrations
{
    public partial class SexField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "People");
        }
    }
}

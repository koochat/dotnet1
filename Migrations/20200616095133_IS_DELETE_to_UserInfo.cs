using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet1.Migrations
{
    public partial class IS_DELETE_to_UserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IS_DELETE",
                table: "UserInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IS_DELETE",
                table: "UserInfo");
        }
    }
}

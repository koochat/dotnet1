using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet1.Migrations
{
    public partial class init_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}

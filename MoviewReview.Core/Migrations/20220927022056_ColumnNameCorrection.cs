using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviewReview.Core.Migrations
{
    public partial class ColumnNameCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rules1",
                table: "tbl_Users");

            migrationBuilder.AlterColumn<int>(
                name: "Rules",
                table: "tbl_Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tbl_Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "tbl_Users");

            migrationBuilder.AlterColumn<string>(
                name: "Rules",
                table: "tbl_Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Rules1",
                table: "tbl_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

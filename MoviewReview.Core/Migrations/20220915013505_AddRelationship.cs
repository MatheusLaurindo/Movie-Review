using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviewReview.Core.Migrations
{
    public partial class AddRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cast",
                table: "Titles");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Titles",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Titles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actors_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_DirectorId",
                table: "Titles",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_TitleId",
                table: "Reviews",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_TitleId",
                table: "Actors",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Titles_TitleId",
                table: "Reviews",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_Directors_DirectorId",
                table: "Titles",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Titles_TitleId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_Directors_DirectorId",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Titles_DirectorId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_TitleId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Titles",
                newName: "Director");

            migrationBuilder.AddColumn<string>(
                name: "Cast",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

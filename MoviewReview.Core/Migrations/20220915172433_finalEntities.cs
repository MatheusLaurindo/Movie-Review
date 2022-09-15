using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviewReview.Core.Migrations
{
    public partial class finalEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Titles_TitleId",
                table: "Actors");

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
                name: "Casts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Titles",
                table: "Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_TitleId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tbl_Users");

            migrationBuilder.RenameTable(
                name: "Titles",
                newName: "tbl_Titles");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "tbl_Reviews");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "tbl_Directors");

            migrationBuilder.RenameTable(
                name: "Actors",
                newName: "tbl_Actor");

            migrationBuilder.RenameColumn(
                name: "TitleMovie",
                table: "tbl_Titles",
                newName: "Synopsis");

            migrationBuilder.RenameColumn(
                name: "Screenwriter",
                table: "tbl_Titles",
                newName: "Synopsis1");

            migrationBuilder.RenameColumn(
                name: "DirectorId",
                table: "tbl_Titles",
                newName: "IdScreenwriter");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_DirectorId",
                table: "tbl_Titles",
                newName: "IX_tbl_Titles_IdScreenwriter");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tbl_Reviews",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "TitleId",
                table: "tbl_Reviews",
                newName: "IdTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "tbl_Reviews",
                newName: "IX_tbl_Reviews_IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_TitleId",
                table: "tbl_Reviews",
                newName: "IX_tbl_Reviews_IdTitle");

            migrationBuilder.AlterColumn<string>(
                name: "Rules",
                table: "tbl_Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "tbl_Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rules1",
                table: "tbl_Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Synopsis",
                table: "tbl_Titles",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdDirector",
                table: "tbl_Titles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Reviews",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Directors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tbl_Actor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Titles",
                table: "tbl_Titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Reviews",
                table: "tbl_Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Directors",
                table: "tbl_Directors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Actor",
                table: "tbl_Actor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tbl_ActorsTitles",
                columns: table => new
                {
                    IdTitle = table.Column<int>(type: "int", nullable: false),
                    IdActor = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ActorsTitles", x => new { x.IdActor, x.IdTitle });
                    table.ForeignKey(
                        name: "FK_tbl_ActorsTitles_tbl_Actor_IdActor",
                        column: x => x.IdActor,
                        principalTable: "tbl_Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_ActorsTitles_tbl_Titles_IdTitle",
                        column: x => x.IdTitle,
                        principalTable: "tbl_Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Screenwriters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Screenwriters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Titles_IdDirector",
                table: "tbl_Titles",
                column: "IdDirector");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ActorsTitles_IdTitle",
                table: "tbl_ActorsTitles",
                column: "IdTitle");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Reviews_tbl_Titles_IdTitle",
                table: "tbl_Reviews",
                column: "IdTitle",
                principalTable: "tbl_Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Reviews_tbl_Users_IdUser",
                table: "tbl_Reviews",
                column: "IdUser",
                principalTable: "tbl_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Titles_tbl_Directors_IdDirector",
                table: "tbl_Titles",
                column: "IdDirector",
                principalTable: "tbl_Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Titles_tbl_Screenwriters_IdScreenwriter",
                table: "tbl_Titles",
                column: "IdScreenwriter",
                principalTable: "tbl_Screenwriters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Reviews_tbl_Titles_IdTitle",
                table: "tbl_Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Reviews_tbl_Users_IdUser",
                table: "tbl_Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Titles_tbl_Directors_IdDirector",
                table: "tbl_Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Titles_tbl_Screenwriters_IdScreenwriter",
                table: "tbl_Titles");

            migrationBuilder.DropTable(
                name: "tbl_ActorsTitles");

            migrationBuilder.DropTable(
                name: "tbl_Screenwriters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Titles",
                table: "tbl_Titles");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Titles_IdDirector",
                table: "tbl_Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Reviews",
                table: "tbl_Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Directors",
                table: "tbl_Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Actor",
                table: "tbl_Actor");

            migrationBuilder.DropColumn(
                name: "Rules1",
                table: "tbl_Users");

            migrationBuilder.DropColumn(
                name: "IdDirector",
                table: "tbl_Titles");

            migrationBuilder.RenameTable(
                name: "tbl_Users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "tbl_Titles",
                newName: "Titles");

            migrationBuilder.RenameTable(
                name: "tbl_Reviews",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "tbl_Directors",
                newName: "Directors");

            migrationBuilder.RenameTable(
                name: "tbl_Actor",
                newName: "Actors");

            migrationBuilder.RenameColumn(
                name: "Synopsis",
                table: "Titles",
                newName: "TitleMovie");

            migrationBuilder.RenameColumn(
                name: "Synopsis1",
                table: "Titles",
                newName: "Screenwriter");

            migrationBuilder.RenameColumn(
                name: "IdScreenwriter",
                table: "Titles",
                newName: "DirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Titles_IdScreenwriter",
                table: "Titles",
                newName: "IX_Titles_DirectorId");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Reviews",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "IdTitle",
                table: "Reviews",
                newName: "TitleId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Reviews_IdUser",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Reviews_IdTitle",
                table: "Reviews",
                newName: "IX_Reviews_TitleId");

            migrationBuilder.AlterColumn<int>(
                name: "Rules",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TitleMovie",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 2147483647);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Titles",
                table: "Titles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    IdCast = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.IdCast);
                    table.ForeignKey(
                        name: "FK_Casts_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Casts_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_TitleId",
                table: "Actors",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Casts_ActorId",
                table: "Casts",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Casts_TitleId",
                table: "Casts",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Titles_TitleId",
                table: "Actors",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id");

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
    }
}

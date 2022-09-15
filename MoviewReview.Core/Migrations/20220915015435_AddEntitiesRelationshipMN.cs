using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviewReview.Core.Migrations
{
    public partial class AddEntitiesRelationshipMN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Titles_TitleId",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_TitleId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Actors");

            migrationBuilder.CreateTable(
                name: "ActorTitle",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "int", nullable: false),
                    TitlesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorTitle", x => new { x.CastId, x.TitlesId });
                    table.ForeignKey(
                        name: "FK_ActorTitle_Actors_CastId",
                        column: x => x.CastId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorTitle_Titles_TitlesId",
                        column: x => x.TitlesId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorTitle_TitlesId",
                table: "ActorTitle",
                column: "TitlesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorTitle");

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_TitleId",
                table: "Actors",
                column: "TitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Titles_TitleId",
                table: "Actors",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id");
        }
    }
}

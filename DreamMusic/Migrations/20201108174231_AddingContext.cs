using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamMusic.Migrations
{
    public partial class AddingContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrumSheet_Users_CreatorId",
                table: "DrumSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_DrumSheet_SheetId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Users_UserId",
                table: "Like");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Like",
                table: "Like");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrumSheet",
                table: "DrumSheet");

            migrationBuilder.RenameTable(
                name: "Like",
                newName: "Likes");

            migrationBuilder.RenameTable(
                name: "DrumSheet",
                newName: "DrumSheets");

            migrationBuilder.RenameIndex(
                name: "IX_Like_UserId",
                table: "Likes",
                newName: "IX_Likes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Like_SheetId",
                table: "Likes",
                newName: "IX_Likes_SheetId");

            migrationBuilder.RenameIndex(
                name: "IX_DrumSheet_CreatorId",
                table: "DrumSheets",
                newName: "IX_DrumSheets_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Likes",
                table: "Likes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrumSheets",
                table: "DrumSheets",
                column: "SheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrumSheets_Users_CreatorId",
                table: "DrumSheets",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_DrumSheets_SheetId",
                table: "Likes",
                column: "SheetId",
                principalTable: "DrumSheets",
                principalColumn: "SheetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_UserId",
                table: "Likes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrumSheets_Users_CreatorId",
                table: "DrumSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_DrumSheets_SheetId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_UserId",
                table: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Likes",
                table: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrumSheets",
                table: "DrumSheets");

            migrationBuilder.RenameTable(
                name: "Likes",
                newName: "Like");

            migrationBuilder.RenameTable(
                name: "DrumSheets",
                newName: "DrumSheet");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_UserId",
                table: "Like",
                newName: "IX_Like_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_SheetId",
                table: "Like",
                newName: "IX_Like_SheetId");

            migrationBuilder.RenameIndex(
                name: "IX_DrumSheets_CreatorId",
                table: "DrumSheet",
                newName: "IX_DrumSheet_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Like",
                table: "Like",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrumSheet",
                table: "DrumSheet",
                column: "SheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrumSheet_Users_CreatorId",
                table: "DrumSheet",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_DrumSheet_SheetId",
                table: "Like",
                column: "SheetId",
                principalTable: "DrumSheet",
                principalColumn: "SheetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Users_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    public partial class BookCopySetNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksCopy_Books_BookId",
                table: "BooksCopy");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksCopy_Terminals_TerminalId",
                table: "BooksCopy");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksCopy_Users_UserId",
                table: "BooksCopy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksCopy",
                table: "BooksCopy");

            migrationBuilder.RenameTable(
                name: "BooksCopy",
                newName: "BookCopies");

            migrationBuilder.RenameIndex(
                name: "IX_BooksCopy_UserId",
                table: "BookCopies",
                newName: "IX_BookCopies_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksCopy_TerminalId",
                table: "BookCopies",
                newName: "IX_BookCopies_TerminalId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksCopy_BookId",
                table: "BookCopies",
                newName: "IX_BookCopies_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Terminals_TerminalId",
                table: "BookCopies",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Users_UserId",
                table: "BookCopies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Terminals_TerminalId",
                table: "BookCopies");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Users_UserId",
                table: "BookCopies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies");

            migrationBuilder.RenameTable(
                name: "BookCopies",
                newName: "BooksCopy");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_UserId",
                table: "BooksCopy",
                newName: "IX_BooksCopy_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_TerminalId",
                table: "BooksCopy",
                newName: "IX_BooksCopy_TerminalId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_BookId",
                table: "BooksCopy",
                newName: "IX_BooksCopy_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksCopy",
                table: "BooksCopy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksCopy_Books_BookId",
                table: "BooksCopy",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksCopy_Terminals_TerminalId",
                table: "BooksCopy",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksCopy_Users_UserId",
                table: "BooksCopy",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}

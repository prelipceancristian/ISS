using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.Migrations
{
    public partial class BookCopiesWithTerminals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TerminalId",
                table: "BooksCopy",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksCopy_TerminalId",
                table: "BooksCopy",
                column: "TerminalId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksCopy_Terminals_TerminalId",
                table: "BooksCopy",
                column: "TerminalId",
                principalTable: "Terminals",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksCopy_Terminals_TerminalId",
                table: "BooksCopy");

            migrationBuilder.DropIndex(
                name: "IX_BooksCopy_TerminalId",
                table: "BooksCopy");

            migrationBuilder.DropColumn(
                name: "TerminalId",
                table: "BooksCopy");
        }
    }
}

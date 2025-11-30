using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NameInverter.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CommonNameId",
                table: "Sobrenomes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Sobrenomes_CommonNameId",
                table: "Sobrenomes",
                column: "CommonNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobrenomes_Nomes_CommonNameId",
                table: "Sobrenomes",
                column: "CommonNameId",
                principalTable: "Nomes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sobrenomes_Nomes_CommonNameId",
                table: "Sobrenomes");

            migrationBuilder.DropIndex(
                name: "IX_Sobrenomes_CommonNameId",
                table: "Sobrenomes");

            migrationBuilder.DropColumn(
                name: "CommonNameId",
                table: "Sobrenomes");
        }
    }
}

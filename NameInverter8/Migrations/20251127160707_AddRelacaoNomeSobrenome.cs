using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NameInverter.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacaoNomeSobrenome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sobrenomes_CommonNameId",
                table: "Sobrenomes");

            migrationBuilder.CreateIndex(
                name: "IX_Sobrenomes_CommonNameId",
                table: "Sobrenomes",
                column: "CommonNameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sobrenomes_CommonNameId",
                table: "Sobrenomes");

            migrationBuilder.CreateIndex(
                name: "IX_Sobrenomes_CommonNameId",
                table: "Sobrenomes",
                column: "CommonNameId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConnectApplicationCommentwithSubmittedApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ApplicationComment_ApplicationId",
                table: "ApplicationComment",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationComment_SubmittedApplication_ApplicationId",
                table: "ApplicationComment",
                column: "ApplicationId",
                principalTable: "SubmittedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationComment_SubmittedApplication_ApplicationId",
                table: "ApplicationComment");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationComment_ApplicationId",
                table: "ApplicationComment");
        }
    }
}

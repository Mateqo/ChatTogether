using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatTogether.Web.Migrations
{
    public partial class migration_2804_1845 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acquaintances_AppUsers_AcquaintanceId",
                table: "Acquaintances");

            migrationBuilder.DropForeignKey(
                name: "FK_Acquaintances_AppUsers_UserId",
                table: "Acquaintances");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppUsers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Confirmations_UserId",
                table: "Confirmations");

            migrationBuilder.CreateIndex(
                name: "IX_Confirmations_UserId",
                table: "Confirmations",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Acquaintances_AppUsers_AcquaintanceId",
                table: "Acquaintances",
                column: "AcquaintanceId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Acquaintances_AppUsers_UserId",
                table: "Acquaintances",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AppUsers_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AppUsers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acquaintances_AppUsers_AcquaintanceId",
                table: "Acquaintances");

            migrationBuilder.DropForeignKey(
                name: "FK_Acquaintances_AppUsers_UserId",
                table: "Acquaintances");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppUsers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Confirmations_UserId",
                table: "Confirmations");

            migrationBuilder.CreateIndex(
                name: "IX_Confirmations_UserId",
                table: "Confirmations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acquaintances_AppUsers_AcquaintanceId",
                table: "Acquaintances",
                column: "AcquaintanceId",
                principalTable: "AppUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Acquaintances_AppUsers_UserId",
                table: "Acquaintances",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AppUsers_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "AppUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AppUsers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }
    }
}

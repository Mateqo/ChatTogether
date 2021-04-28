using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatTogether.Web.Migrations
{
    public partial class migration_2804_1412 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppUsers_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Messages");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Acquaintances_AcquaintanceId",
                table: "Acquaintances",
                column: "AcquaintanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acquaintances_AppUsers_AcquaintanceId",
                table: "Acquaintances",
                column: "AcquaintanceId",
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
                name: "FK_Messages_AppUsers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Acquaintances_AcquaintanceId",
                table: "Acquaintances");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AppUsers_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

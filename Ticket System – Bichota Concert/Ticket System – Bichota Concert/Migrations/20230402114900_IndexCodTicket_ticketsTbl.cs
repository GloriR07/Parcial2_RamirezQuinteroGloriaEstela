using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket_System___Bichota_Concert.Migrations
{
    /// <inheritdoc />
    public partial class IndexCodTicket_ticketsTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_Id",
                table: "Tickets");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CodTicket",
                table: "Tickets",
                column: "CodTicket",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_CodTicket",
                table: "Tickets");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Id",
                table: "Tickets",
                column: "Id",
                unique: true);
        }
    }
}

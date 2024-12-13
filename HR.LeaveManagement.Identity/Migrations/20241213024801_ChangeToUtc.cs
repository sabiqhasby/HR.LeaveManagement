using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToUtc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a231e7d7-6e66-4be3-97a6-07f965a73941", "AQAAAAIAAYagAAAAEFui3I9SRFqHbye7eY2Kk2Go2W+bYdSiXgiakyZd5kUBGiiRhVt9enP9Wk2YeBDLqA==", "16d5185a-bbb8-4754-9ca8-febbc03dab62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbcb3d85-b06d-4760-9502-28efab410cd7", "AQAAAAIAAYagAAAAEBOVUgFXeT3sIyQGsVFl2xmfr4zKcSu43VbvOtEtvpYEcbLv1qY9jLRAWenXl7A1oQ==", "bf357c69-c374-4a07-a657-d867088de638" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1df7b20-cccb-4ae0-aaf7-e7869cd6bb0e", "AQAAAAIAAYagAAAAEI5QD8GhQkaabEG+YC6+KyF2TPIgXRhahvXmDRZYd/pV11PT9hhYW4+qESt7Ipo4zA==", "1427336b-9f56-409a-9357-340e000ab64b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "141140db-ed2a-4fc8-9fb8-53f4f546dbfc", "AQAAAAIAAYagAAAAEPZWqX0DZmrPsnlEQGAXQDDD9rNguwipzhKJlOYJNXMRa8IW6wP6FjF9TEkTPJzK/g==", "256a4dcd-38d1-494a-a6d0-b27ea03ab804" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb3c8cde-d048-4790-b669-095963b5669d", "AQAAAAIAAYagAAAAEGf4n2pvzvlU+3McFEpC3OKd63urCLm2lKF1ODLgTdRH8AqBGrloKTZ5IbFLmam02A==", "e713471e-1299-4717-af15-55e9970caf89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "115d50e1-5ea5-48df-b8a9-c1d0245e64c6", "AQAAAAIAAYagAAAAEHt8pRIMlnLxee5XP0d78xM+d7Rh5Gm+AOrVCeoPTRLkFUe10lKKwBGQXeVWU0/DBw==", "7ebb4e42-a428-49b2-9d7b-4787d0f07f4b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

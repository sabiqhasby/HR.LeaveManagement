using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToUtc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 12, 13, 2, 49, 12, 277, DateTimeKind.Utc).AddTicks(2640), new DateTime(2024, 12, 13, 2, 49, 12, 277, DateTimeKind.Utc).AddTicks(2642) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 12, 4, 13, 19, 33, 158, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 12, 4, 13, 19, 33, 158, DateTimeKind.Local).AddTicks(2980) });
        }
    }
}

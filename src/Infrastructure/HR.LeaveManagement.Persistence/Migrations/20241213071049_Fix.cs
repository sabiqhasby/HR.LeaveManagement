using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 12, 13, 7, 10, 48, 837, DateTimeKind.Utc).AddTicks(4780), new DateTime(2024, 12, 13, 7, 10, 48, 837, DateTimeKind.Utc).AddTicks(4783) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 12, 13, 6, 4, 14, 387, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 12, 13, 6, 4, 14, 387, DateTimeKind.Utc).AddTicks(7611) });
        }
    }
}

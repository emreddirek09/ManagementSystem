using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementSystem.Persitence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "s",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "RoleName" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2518), "Admin" });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "RoleName" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 26, 50, 838, DateTimeKind.Local).AddTicks(2519), "User" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "s",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "RoleName" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5477), "Egzoz Gazı Ölçümü" });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "RoleName" },
                values: new object[] { new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5478), "Fren Testi" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManagementSystem.Persitence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0c351ef5-3d23-47da-8fcd-f3b809a18fd3"));

            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6cdef731-0497-4cf6-a435-fa7fb8c27538"));

            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8f0ee820-c03b-4807-b02a-42cb1078426a"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("45aa33d2-7275-430e-8a7e-7caf1db7e325"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("801deb79-4da6-44ed-a21a-29d475c47648"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("edc589f5-4182-4f75-bf05-74d19d4a78f4"));

            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "CreateDate", "StatusName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("5591ac5f-47be-4623-872f-b1dadf169160"), new DateTime(2024, 11, 17, 21, 28, 2, 750, DateTimeKind.Local).AddTicks(4001), "Tamamlandı", null },
                    { new Guid("80c34d88-99c9-45f6-a061-ad16efbb19fc"), new DateTime(2024, 11, 17, 21, 28, 2, 750, DateTimeKind.Local).AddTicks(3999), "İptal Edildi", null },
                    { new Guid("ff4b0525-068c-4702-937c-a61c8a9af886"), new DateTime(2024, 11, 17, 21, 28, 2, 750, DateTimeKind.Local).AddTicks(3987), "Onaylandı", null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("4b71cadb-6886-4954-a4fd-802c74648def"), new DateTime(2024, 11, 17, 21, 28, 2, 750, DateTimeKind.Local).AddTicks(4126), "Far Ayarı", null },
                    { new Guid("d12a8a9f-c74d-4ea6-92dc-e6ab5cf69602"), new DateTime(2024, 11, 17, 21, 28, 2, 750, DateTimeKind.Local).AddTicks(4122), "Egzoz Gazı Ölçümü", null },
                    { new Guid("f0a917b1-7e42-4bf7-981c-7c00252c4dbb"), new DateTime(2024, 11, 17, 21, 28, 2, 750, DateTimeKind.Local).AddTicks(4124), "Fren Testi", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5591ac5f-47be-4623-872f-b1dadf169160"));

            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("80c34d88-99c9-45f6-a061-ad16efbb19fc"));

            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ff4b0525-068c-4702-937c-a61c8a9af886"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("4b71cadb-6886-4954-a4fd-802c74648def"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("d12a8a9f-c74d-4ea6-92dc-e6ab5cf69602"));

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: new Guid("f0a917b1-7e42-4bf7-981c-7c00252c4dbb"));

            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "CreateDate", "StatusName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0c351ef5-3d23-47da-8fcd-f3b809a18fd3"), new DateTime(2024, 11, 17, 20, 14, 5, 595, DateTimeKind.Local).AddTicks(5677), "Tamamlandı", null },
                    { new Guid("6cdef731-0497-4cf6-a435-fa7fb8c27538"), new DateTime(2024, 11, 17, 20, 14, 5, 595, DateTimeKind.Local).AddTicks(5667), "İptal Edildi", null },
                    { new Guid("8f0ee820-c03b-4807-b02a-42cb1078426a"), new DateTime(2024, 11, 17, 20, 14, 5, 595, DateTimeKind.Local).AddTicks(5654), "Onaylandı", null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreateDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("45aa33d2-7275-430e-8a7e-7caf1db7e325"), new DateTime(2024, 11, 17, 20, 14, 5, 595, DateTimeKind.Local).AddTicks(5827), "Egzoz Gazı Ölçümü", null },
                    { new Guid("801deb79-4da6-44ed-a21a-29d475c47648"), new DateTime(2024, 11, 17, 20, 14, 5, 595, DateTimeKind.Local).AddTicks(5830), "Fren Testi", null },
                    { new Guid("edc589f5-4182-4f75-bf05-74d19d4a78f4"), new DateTime(2024, 11, 17, 20, 14, 5, 595, DateTimeKind.Local).AddTicks(5832), "Far Ayarı", null }
                });
        }
    }
}

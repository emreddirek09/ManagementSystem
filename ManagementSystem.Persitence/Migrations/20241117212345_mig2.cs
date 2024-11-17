using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ManagementSystem.Persitence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AppointmentStatuses_StatusId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentStatuses");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_StatusId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Appointments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AppointmentStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StatusId",
                table: "Appointments",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AppointmentStatuses_StatusId",
                table: "Appointments",
                column: "StatusId",
                principalTable: "AppointmentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

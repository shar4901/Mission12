using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    AppointmentDateTime = table.Column<DateTime>(nullable: false),
                    AppointmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.AppointmentDateTime);
                    table.ForeignKey(
                        name: "FK_TimeSlots_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 1, "test@test.com", "Farquad Squad", 4, "801-123-1234" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[,]
                {
                    { new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new DateTime(2022, 4, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_AppointmentId",
                table: "TimeSlots",
                column: "AppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}

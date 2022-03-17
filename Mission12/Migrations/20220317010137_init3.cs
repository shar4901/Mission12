using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "AppointmentDateTime", "AppointmentId" },
                values: new object[] { new DateTime(2022, 4, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "AppointmentDateTime",
                keyValue: new DateTime(2022, 4, 9, 20, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Day", "DoctorId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 5, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) }
                });
        }
    }
}

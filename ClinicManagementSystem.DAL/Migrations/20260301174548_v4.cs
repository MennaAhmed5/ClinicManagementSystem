using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "BirthDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateOnly(1992, 4, 18), "Youssef Khaled", "01055667788" },
                    { 2, new DateOnly(1998, 9, 3), "Nour Elhoda", "01122334455" },
                    { 3, new DateOnly(1987, 12, 27), "Karim Adel", "01299887766" },
                    { 4, new DateOnly(2001, 6, 14), "Hana Mostafa", "01533445566" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "VisitLength" },
                values: new object[,]
                {
                    { 1, new DateOnly(2026, 3, 2), 1, new TimeOnly(16, 30, 0), 1, new TimeOnly(16, 0, 0), 30 },
                    { 2, new DateOnly(2026, 3, 2), 1, new TimeOnly(17, 0, 0), 2, new TimeOnly(16, 30, 0), 30 },
                    { 3, new DateOnly(2026, 3, 3), 2, new TimeOnly(18, 30, 0), 3, new TimeOnly(18, 0, 0), 30 },
                    { 4, new DateOnly(2026, 3, 3), 2, new TimeOnly(19, 0, 0), 4, new TimeOnly(18, 30, 0), 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

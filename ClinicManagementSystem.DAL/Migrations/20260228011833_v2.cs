using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicManagementSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Port Said", "Port Said Medical Center", "0661234567" },
                    { 2, "Cairo", "Cairo Health Clinic", "0223456789" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ClinicId", "Email", "Name", "Phone", "Specialization" },
                values: new object[,]
                {
                    { 1, 1, "ahmed@clinic.com", "Dr. Ahmed Hassan", "01012345678", "Cardiology" },
                    { 2, 1, "sara@clinic.com", "Dr. Sara Ali", "01112345678", "Dermatology" },
                    { 3, 2, "mohamed@clinic.com", "Dr. Mohamed Tarek", "01212345678", "Orthopedics" },
                    { 4, 2, "mona@clinic.com", "Dr. Mona Ibrahim", "01512345678", "Pediatrics" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Day", "DoctorId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 0, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 1, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 2, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 3, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 4, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 6, 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 0, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 1, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 2, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 3, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 4, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 6, 2, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 0, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 1, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 2, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 3, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 4, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 6, 3, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 0, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 1, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 2, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 3, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 4, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 5, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) },
                    { 6, 4, new TimeOnly(20, 0, 0), new TimeOnly(16, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 0, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 0, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 0, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 0, 4 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumns: new[] { "Day", "DoctorId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

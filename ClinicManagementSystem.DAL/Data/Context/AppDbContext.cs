using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Data.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Clinic> Clinics { get; set; }

        public DbSet<Schedule> Schedules { get; set; }  

        public DbSet<Appointment> Appointments { get; set; }    

        public AppDbContext(DbContextOptions options):base(options) 
        {

        }
  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent api : create composite key 
            modelBuilder.Entity<Schedule>().HasKey(s => new { s.DoctorId, s.Day });
            base.OnModelCreating(modelBuilder);

            #region seeding

            #region Clinic
            modelBuilder.Entity<Clinic>().HasData(
                new Clinic
                {
                    Id = 1,
                    Name = "Port Said Medical Center",
                    City = "Port Said",
                    Phone = "0661234567"
                },
                new Clinic
                {
                    Id = 2,
                    Name = "Cairo Health Clinic",
                    City = "Cairo",
                    Phone = "0223456789"
                }
            );

            #endregion

            #region Doctor
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Dr. Ahmed Hassan",
                    Specialization = "Cardiology",
                    Email = "ahmed@clinic.com",
                    Phone = "01012345678",
                    ClinicId = 1
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Dr. Sara Ali",
                    Specialization = "Dermatology",
                    Email = "sara@clinic.com",
                    Phone = "01112345678",
                    ClinicId = 1
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Dr. Mohamed Tarek",
                    Specialization = "Orthopedics",
                    Email = "mohamed@clinic.com",
                    Phone = "01212345678",
                    ClinicId = 2
                },
                new Doctor
                {
                    Id = 4,
                    Name = "Dr. Mona Ibrahim",
                    Specialization = "Pediatrics",
                    Email = "mona@clinic.com",
                    Phone = "01512345678",
                    ClinicId = 2
                }
            );

            #endregion
             
            #region Patients 
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                   Id = 1,
                   Name = "Youssef Khaled",
                   BirthDate = new DateOnly(1992, 4, 18),
                   Phone = "01055667788"
                },
                new Patient
                {
                   Id = 2,
                   Name = "Nour Elhoda",
                   BirthDate = new DateOnly(1998, 9, 3),
                   Phone = "01122334455"
                },
                new Patient
                {
                   Id = 3,
                   Name = "Karim Adel",
                   BirthDate = new DateOnly(1987, 12, 27),
                   Phone = "01299887766"
                },
                new Patient
                {
                   Id = 4,
                   Name = "Hana Mostafa",
                   BirthDate = new DateOnly(2001, 6, 14),
                   Phone = "01533445566"
                }
            );
            #endregion
            

            #region schedule
            var schedules = new List<Schedule>();
            int[] doctorsIds = { 1, 2, 3, 4 };
            foreach (var doctorId in doctorsIds)
            {
                foreach (WorkDay day in Enum.GetValues(typeof(WorkDay)))
                {
                    if (day == WorkDay.Friday)
                        continue;

                    schedules.Add(new Schedule()
                    {
                        DoctorId = doctorId,
                        Day = day,
                        StartTime = new TimeOnly(16, 0), //4 pm
                        EndTime = new TimeOnly(20, 0) //8 pm
                    });

                }
            }
            modelBuilder.Entity<Schedule>().HasData(schedules);
            #endregion
            #endregion
        }

    }
}

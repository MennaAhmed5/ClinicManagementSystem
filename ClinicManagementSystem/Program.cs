using ClinicManagementSystem.BL.Managers.Appointments;
using ClinicManagementSystem.BL.Managers.Doctors;
using ClinicManagementSystem.BL.Managers.Patients;
using ClinicManagementSystem.BL.Managers.Schedules;
using ClinicManagementSystem.DAL.Data.Context;
using ClinicManagementSystem.DAL.Repositories;
using ClinicManagementSystem.DAL.Repositories.Appointments;
using ClinicManagementSystem.DAL.Repositories.Doctors;
using ClinicManagementSystem.DAL.Repositories.Patients;
using ClinicManagementSystem.DAL.Repositories.Schedules;
using ClinicManagementSystem.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            var connectionString = builder.Configuration.GetConnectionString("ClinicDb");

             builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));


            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            builder.Services.AddScoped<IScheduleRepository, ScheduleRepository>();

            builder.Services.AddScoped<IDoctorManager, DoctorManager>();
            builder.Services.AddScoped<IPatientManager, PatientManager>();
            builder.Services.AddScoped<IAppointmentManager, ApointmentManager>();
            builder.Services.AddScoped<IScheduleManager,  ScheduleManager>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MyLearningProject.Data.DbContexts;
using MyLearningProject.Data.IRepositories;
using MyLearningProject.Data.Repositories;
using MyLearningProject.Service.Interfaces.IUserServices;
using MyLearningProject.Service.Mappers;
using MyLearningProject.Service.Services.UserServices;
using Serilog;
using System;

namespace MyLearningProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //Connect qilish uchun shu narsa kerak juda muhim !!!
            builder.Services.AddDbContext<AppDbContext>(option
                => option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            // Logger
            var logger = new LoggerConfiguration()
              .ReadFrom.Configuration(builder.Configuration)
              .Enrich.FromLogContext()
              .CreateLogger();
            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(logger);




            //Middleware
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
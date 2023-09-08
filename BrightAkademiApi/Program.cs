
using BrightAkademiApi.Data.Concrete.EFCore.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BrightAkademiApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();

            builder.Services.AddDbContext<BrightAkademiApiContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
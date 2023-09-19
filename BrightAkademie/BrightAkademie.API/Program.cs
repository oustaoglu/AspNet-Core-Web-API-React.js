using BrightAkademie.Business.Abstract;
using BrightAkademie.Business.Concrete;
using BrightAkademie.Data.Abstract;
using BrightAkademie.Data.Concrete.EFCore.Contexts;
using BrightAkademie.Data.Concrete.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<BrightAkademieContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICourseService, CourseManager>();
builder.Services.AddScoped<ISettingService, SettingManager>();
builder.Services.AddScoped<ITraineeService, TraineeManager>();
builder.Services.AddScoped<ITrainerService, TrainerManager>();

builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<ICourseRepository, EfCoreCourseRepository>();
builder.Services.AddScoped<ISettingRepository, EfCoreSettingRepository>();
builder.Services.AddScoped<ITraineeRepository, EfCoreTraineeRepository>();
builder.Services.AddScoped<ITrainerRepository, EfCoreTrainerRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "_allowAllPolicy",
        policy =>
        {
            policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        }
    );
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors("_allowAllPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

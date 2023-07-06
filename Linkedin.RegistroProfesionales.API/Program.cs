using Linkedin.RegistroProfesionales.Application.Implementacion;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Linkedin.RegistroProfesionales.Application.Profiles;
using Linkedin.RegistroProfesionales.Repository;
using Linkedin.RegistroProfesionales.Repository.Implementacion;
using Linkedin.RegistroProfesionales.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(cfg => cfg.UseSqlServer
        (builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddScoped<IProfesionalApplication, ProfesionalApplication>();
builder.Services.AddScoped<IProfesionalRepository, ProfesionalRepository>();

builder.Services.AddScoped<ICursoApplication, CursoApplication>();
builder.Services.AddScoped<ICursoRepository, CursoRepository>();

builder.Services.AddCors(c => c.AddPolicy("GeneralPolicy", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("GeneralPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

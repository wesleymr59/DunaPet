using DunaPet.App.Interfaces.HealthyCheck;
using DunaPet.App.Interfaces.User;
using DunaPet.App.Mappings;
using DunaPet.App.Usecases.HealthyCheck;
using DunaPet.App.Usecases.User;
using DunaPet.App.Utils;
using DunaPet.Infrastructure.Database.MySql.Repositories.Users;
using DunaPet.Infrastructure.Database.Teste;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Pet.Infrastructure.Data.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DunaPet API", Version = "v1" });
});

// registro mySql
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30)))); // Especifique a versão do MySQL


// Registro do repositório
builder.Services.AddScoped<IHealthyCheck, HealthyCheckDB>();
builder.Services.AddScoped<IUser, UserRepository>();

// Registro da UseCase
builder.Services.AddScoped<HealthyCheckUseCase>();
builder.Services.AddScoped<UserUsecase>();

// Registro do AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile)); // ou passe vários perfis se necessário

//Registro Utils
builder.Services.AddSingleton<Crypt>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Configuração do middleware
app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();

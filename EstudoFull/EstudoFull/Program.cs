using EstudoFull.Models.Context;
using EstudoFull.Services;
using EstudoFull.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//injecao de dependencias

    var conn =  builder.Configuration["MySQLConnection:MySQLConString"];
    builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
        conn,
        new MySqlServerVersion(new Version(8,0,29)))
    );
    builder.Services.AddScoped<IPessoaService, PessoaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

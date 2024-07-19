using EstudoFull.Models.Context;
using EstudoFull.Repository;
using EstudoFull.Repository.Interfaces;
using EstudoFull.Services;
using EstudoFull.Services.Interfaces;
using EvolveDb;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


    var conn =  builder.Configuration["MySQLConnection:MySQLConString"];
    builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
        conn,
        new MySqlServerVersion(new Version(8,0,29)))
    );

if(builder.Environment.IsDevelopment())
{
    MigrateDatabase(conn);
}
builder.Services.AddApiVersioning();

//injecao de dependencias
builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();

builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();

builder.Services.AddScoped(typeof(IAllRepository<>), typeof(AllRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void MigrateDatabase(string conn)
{
    try
    {
        var evolveConn = new MySqlConnection(conn);
        var evolve = new Evolve(evolveConn, Log.Information)
        {
            Locations = new List<string> { "db/migrations", "db/dataset" },
            IsEraseDisabled = true,
        };
        evolve.Migrate();
    }
    catch (Exception ex)
    {
        Log.Error("Migration falhou", ex);
        throw;
    }


}

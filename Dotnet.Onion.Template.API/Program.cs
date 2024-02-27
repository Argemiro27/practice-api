using Dotnet.Onion.Template.Domain.Services.ContratoExp;
using Dotnet.Onion.Template.Infrastructure.Repositories.ContratoExp.Certificados;
using Dotnet.Onion.Template.Infrastructure.Repositories.ContratoExp.Containers;
using Dotnet.Onion.Template.Infrastructure.Repositories.ContratoExp;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Dotnet.Onion.Template.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Dotnet.Onion.Template.Infrastructure.Repositories.ContratoExp.OICs;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Define o ambiente de execução
var environment = builder.Environment;

// Carrega a configuração com base no ambiente
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

var connectionString = builder.Configuration.GetConnectionString("StringConexao");

builder.Services.AddDbContext<ContextDB>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

//builder.Services.AddScoped<IListExpContratoRepository, ListExpContratoRepository>();
//builder.Services.AddScoped<IListExpContratoService, ListExpContratoService>();

builder.Services.AddScoped<IExpContratoService, ExpContratoService>();
builder.Services.AddScoped<IExpContratoRepository, ExpContratoRepository>();

builder.Services.AddScoped<IOICsRepository, OICsRepository>();

builder.Services.AddScoped<ICertificadosRepository, CertificadosRepository>();

builder.Services.AddScoped<IContainersRepository, ContainersRepository>();

// Build the application.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Configure CORS policy to allow any origin, method, and header.
app.UseCors(options =>
{
    options.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
});

app.Run();

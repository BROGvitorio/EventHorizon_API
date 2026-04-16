/*
 CURRENT:
    -

 TODO:
    - Definição das BankAccounts, herança TPH
    - 
 */

using EventHorizon_API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
//dotnet ef migrations add
//dotnet ef migrations remove
//dotnet ef database update

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI( c =>
        {
            c.DocumentTitle = "Event Horizon API";
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Event Horizon API");
        }    
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using TestAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Establecer la cadena de conexion para el context
var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
// Establecer la base de datos en memoria
builder.Services.AddDbContext<MemDbContext>();

var app = builder.Build();

// Executar la migración inicial
using (var scope = app.Services.CreateScope())
{
    AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

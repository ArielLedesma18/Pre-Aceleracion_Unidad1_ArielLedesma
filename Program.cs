using Microsoft.EntityFrameworkCore;
using Pre_Aceleracion_Unidad1_ArielLedesma.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddDbContext<UsersContext>((services, options) =>
{
  options.UseInternalServiceProvider(services);
    //options.UseSqlServer(connectionString: "Data Source=DESKTOP-5DBB3FS;Database=PreAceleracion;Integrated Security=True;");
  options.UseSqlServer(builder.Configuration.GetConnectionString(name: "AlkemyConnectionString"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

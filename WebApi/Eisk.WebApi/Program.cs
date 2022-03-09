using Eisk.DataServices.EFCore;
using Eisk.DataServices.EFCore.DataContext;
using Eisk.DataServices.Interfaces;
using Eisk.DomainServices;
using Eisk.EFCore.Setup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//custom services

builder.Services.AddScoped<AppDbContext, InMemoryDbContext>();
builder.Services.AddScoped<IEmployeeDataService, EmployeeDataService>();
builder.Services.AddScoped<EmployeeDomainService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

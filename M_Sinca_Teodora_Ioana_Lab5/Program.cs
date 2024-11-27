using Microsoft.EntityFrameworkCore;
using M_Sinca_Teodora_Ioana_Lab5.Models;
using Microsoft.Extensions.DependencyInjection;
using M_Sinca_Teodora_Ioana_Lab5.Data;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<M_Sinca_Teodora_Ioana_Lab5Context>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("M_Sinca_Teodora_Ioana_Lab5Context") ?? throw new InvalidOperationException("Connection string 'M_Sinca_Teodora_Ioana_Lab5Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ExpenseContext>(opt =>opt.UseInMemoryDatabase("ExpenseList"));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

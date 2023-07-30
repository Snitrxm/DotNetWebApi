using Domain.Contracts.Services.UserServices;
using Microsoft.EntityFrameworkCore;
using Application.Services.User;
using DataAccess.ApiDbContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICreateUserService, CreateUserService>();

builder.Services.AddDbContext<ApiDbContext>(options => options.UseInMemoryDatabase("ApiDb"));

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

using FlowPlane.Application.Commands.CreateActivity;
using FlowPlane.Core.Repositories;
using FlowPlane.Core.Services;
using FlowPlane.Infrastructure.AuthService;
using FlowPlane.Infrastructure.Persistence;
using FlowPlane.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<FlowPlaneDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("FlowPlaneCS")));

builder.Services.AddScoped<IActivityRepository, ActivityRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateActivityCommand).Assembly));

builder.Services.AddControllers();
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

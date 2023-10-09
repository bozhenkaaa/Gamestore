// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Gamestore.BLL.Services.Implementations;
using Gamestore.BLL.Services.Interfaces;
using Gamestore.DAL.Data;
using Gamestore.DAL.Repositories.Implementations;
using Gamestore.DAL.Repositories.Interfaces;
using Gamestore.DAL.UnitOfWork.Implementations;
using Gamestore.DAL.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GamestoreDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var dbContextOptions = new DbContextOptionsBuilder<GamestoreDbContext>()
    .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    .Options;
using var dbContext = new GamestoreDbContext(dbContextOptions);
dbContext.Database.EnsureCreated();
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
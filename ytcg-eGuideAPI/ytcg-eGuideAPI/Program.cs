using Microsoft.EntityFrameworkCore;
using ytcg_eGuideAPI.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => { options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });

IConfigurationBuilder buildConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
IConfiguration configuration = buildConfig.Build();
builder.Services.AddDbContext<YtcgEguiudeDbContext> (options =>
options.UseSqlServer(configuration.GetConnectionString("ytcg-eguiudeDB"))); // Make sure to use the right name

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowAll");

app.Run();

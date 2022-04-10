using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddDbContext<Nyarchive.Server.Model.NyarchiveDbContext>(options =>
    options.UseMySql(builder.Configuration.GetSection("ConnectionStrings:Default").Value, MariaDbServerVersion.AutoDetect(builder.Configuration.GetSection("ConnectionStrings:Default").Value))
);
builder.Services.AddIdentity<Nyarchive.Server.Model.Auth.User, Nyarchive.Server.Model.Auth.Role>()
    .AddEntityFrameworkStores<Nyarchive.Server.Model.NyarchiveDbContext>()
    .AddDefaultTokenProviders();
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

// using System.Text.Json;

// Name of the project
// dockerartcile

// First Key
// MxJe/sx1neIhvqbuhQiGB2t1c1ngTox5t+/6Qmwmn/+ACRD/3AX5

// Second Key
// dy4LAN4eD4BUVRMwaA24GB45E8Un7pT64SX+KqQ7lK+ACRDAsXyk

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => 
    options.AddDefaultPolicy(p =>
        p.AllowAnyOrigin()));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

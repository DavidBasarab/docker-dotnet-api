// using System.Text.Json;

// Name of the project
// dockerArticle

// First Key
// a2FVzNaeQcdEGdANxhP3rJwTTg6+cclZbv7cNVCkRA+ACRC9R9Sf

// Second Key
// N0K8F0XnX6brSiL9V9vrFIP74CtThsG85LjhzgReU++ACRBXDnCp

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

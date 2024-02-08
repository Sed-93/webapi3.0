using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<Controller>();
builder.Services.AddControllers();

var app = builder.Build();

// Ensure the controller is created by the DI container
var controller = app.Services.GetRequiredService<Controller>();

app.MapGet("/encrypt/{plainText}/{shift}", (string plainText, int shift) => controller.Encrypt(plainText, shift));
app.MapGet("/decrypt/{cipherText}/{shift}", (string cipherText, int shift) => controller.Decrypt(cipherText, shift));

app.Run();

using Basic_Api.Services;
using Basic_Api.Interfaces;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IClienteServices, ClienteServices>();
//builder.Services.AddTransient<IClienteServices, ClienteServices>();
builder.Services.AddSingleton<IClienteServices, ClienteServices>();

var app = builder.Build(); 

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();



app.Run();
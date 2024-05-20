using Fitnet.Contracts;
using Fitnet.Contracts.Data.Database;
using Fitnet.Passes;
using Fitnet.Passes.Data.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PassesPersistence>();
builder.Services.AddScoped<ContractsPersistence>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

PassesEndpoints.Map(app);
ContractsEndpoint.Map(app);

app.Run();

public partial class Program { }
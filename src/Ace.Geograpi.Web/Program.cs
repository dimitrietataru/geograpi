using Ace.Geograpi.Application;
using Ace.Geograpi.Infrastructure;
using Ace.Geograpi.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddGeograpiLogger();

builder.AddApplication();
builder.AddInfrastructure();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    await app.ApplyDbMigrationsAsync();
}

app.UseGeograpiLogger();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync().ConfigureAwait(false);

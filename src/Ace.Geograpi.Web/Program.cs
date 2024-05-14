using Ace.Geograpi.Application;
using Ace.Geograpi.Infrastructure;
using Ace.Geograpi.Web;

var builder = WebApplication.CreateBuilder(args);

builder.AddGeograpiLogger();

builder.AddApplication();
builder.AddInfrastructure();

builder.Services.AddGeograpiCors();
builder.Services.AddControllers();
builder.Services.AddGeograpiApiVersioning();
builder.Services.AddGeograpiSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Docker"))
{
    app.UseGeograpiCorsPermissive();
    app.UseGeograpiSwagger();

    await app.ApplyDbMigrationsAsync();
}

app.UseGeograpiLogger();
app.UseHttpsRedirection();
app.UseGeograpiCorsRestrictive();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync().ConfigureAwait(false);

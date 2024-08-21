using HackathonPrep.Application;
using HackathonPrep.Infrastructure;
using HackathonPrep.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.SetIsOriginAllowed(x => true);
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
        builder.AllowCredentials();
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


using IServiceScope scope = app.Services.CreateScope();
ApplicationDbContextInitializer initializer = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitializer>();
await initializer.InitializeAsync();
await initializer.SeedAsync();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

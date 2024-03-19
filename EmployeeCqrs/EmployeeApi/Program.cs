using System.Reflection;
using Employee.Business.Database;
using Employee.Business.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connString=builder.Configuration.GetConnectionString("CommandDb");

builder.Services.AddDbContext<EmployeeWriteContext>(options =>
    options.UseMySql(connString,
    ServerVersion.AutoDetect(connString),
    b => b.MigrationsAssembly("EmployeeApi")));

var connString1=builder.Configuration.GetConnectionString("QueryDb");

builder.Services.AddDbContext<EmployeeReadContext>(options =>
    options.UseMySql(connString1,
    ServerVersion.AutoDetect(connString1)));

// builder.Services.AddMediatR(media =>
//     media.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()
//     ));
// foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
// {
//     builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
// }

// builder.Services.AddMediatR(media => media.RegisterServicesFromAssemblies(Assembly.Load("Employee.Business"),Assembly.Load("EmployeeApi")));



builder.Services.AddScoped<IWriteRepository,EmployeeWriteRepository>();
builder.Services.AddScoped<IReadRepository,EmployeeReadRepository>();

builder.Services.AddMediatR(media => media.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

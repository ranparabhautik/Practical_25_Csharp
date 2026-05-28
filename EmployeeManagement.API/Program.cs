using EmployeeManagement.DAL.Behavior;
using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Feature.Employee.Handler;
using EmployeeManagement.DAL.Repository.CommandRepository;
using EmployeeManagement.DAL.Repository.QueryRepository;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn")));


builder.Services.AddMediatR(cfg=>{cfg.RegisterServicesFromAssembly(typeof(CreateEmployeeHandler).Assembly);});

builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

builder.Services.AddTransient(typeof(IPipelineBehavior<,>),typeof(ValidationBehavior<,>));

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployeeCommandRepository,EmployeeCommandRepository>();
builder.Services.AddScoped<IEmployeeQueryRepository,EmployeeQueryRepository>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

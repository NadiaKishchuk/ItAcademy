
using Microsoft.EntityFrameworkCore;
using ToDo.BLL.Services.TaskColor;
using ToDo.BLL.Services.ToDoTask;
using ToDo.Context;
using ToDo.Repositories.TaskColorRepositories;
using ToDo.Repositories.ToDoTaskRepositories;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(ToDo.BLL.Mapping.ToDoTask.ToDoTaskProfile),
    typeof(ToDo.BLL.Mapping.TaskColor.TaskColorProfile)
    );
builder.Services.AddSingleton<ToDoDBContext, ToDoDBContext>();
builder.Services.AddDbContext<ToDoDBContext>(
    option => option
    .UseSqlServer(builder.Configuration.GetConnectionString("ToDoConnectionString")), ServiceLifetime.Singleton);


builder.Services.AddSingleton<IToDoTaskRepository, ToDoTaskRepository>();
builder.Services.AddSingleton<ITaskColorRepository, TaskColorRepository>();


builder.Services.AddSingleton<IToDoTaskService, ToDoTaskService>();
builder.Services.AddSingleton<ITaskColorService, TaskColorService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(x =>
{
    x.AddDefaultPolicy(s =>
    {
        s.AllowAnyMethod();
        s.AllowAnyOrigin();
        s.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();
app.MapControllers();

app.Run();

using LibraryApp.BusinessLogic;
using LibraryApp.BusinessLogic.Interfaces;
using LibraryApp.DataAccess;
using LibraryApp.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                  builder =>
                  {
                      builder.WithOrigins("https://localhost:8080");
                  });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserDataAccessService, UserDataAccessService>();
builder.Services.AddScoped<ITerminalDataAccessService, TerminalDataAccessService>();
builder.Services.AddScoped<IBookCopyDataAccessService, BookCopyDataAccessService>();
builder.Services.AddScoped<IBookDataAccessService, BookDataAccessService>();

builder.Services.AddScoped<IUserBusinessLogicService, UserBusinessLogicService>();
builder.Services.AddScoped<ITerminalBusinessLogicService, TerminalBusinessLogicService>();
builder.Services.AddScoped<IBookCopyBusinessLogicService, BookCopyBusinessLogicService>();
builder.Services.AddDbContext<LibraryApp.AppContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

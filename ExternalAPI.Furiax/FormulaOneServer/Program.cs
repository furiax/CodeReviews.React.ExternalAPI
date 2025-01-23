using FormulaOneServer.Data;
using FormulaOneServer.Services;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    //React page is running on localhost:/5176, adjust accordingly
        {
            policy.WithOrigins("http://localhost:60834");
        });

});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<FormulaDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IFormulaService, FormulaService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
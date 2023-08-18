using API.Configurations;
using API.Entities;
using API.Mapping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterRepositories();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
});

builder.Services.AddAutoMapper(typeof(Maps));

builder.Services.RegisterGraphQLTypes();
builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder => {
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));

var app = builder.Build();

app.MapGraphQL();

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.Run();

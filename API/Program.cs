using API.Configurations;
using API.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterRepositories();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
});

builder.Services.RegisterGraphQLTypes();

var app = builder.Build();

app.MapGraphQL();

app.UseHttpsRedirection();

app.Run();

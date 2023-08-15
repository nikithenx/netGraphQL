using API.Contracts;
using API.Entities;
using API.GraphQL.QueryTypes;
using API.MutationTypes;
using API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
    o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
});

builder.Services.AddGraphQLServer()
    .AddQueryType<AuthorQueryTypes>()
    .AddMutationType<AuthorMutationTypes>();

var app = builder.Build();

app.MapGraphQL();

app.UseHttpsRedirection();

app.Run();

using API.Contracts;
using API.Repositories;

namespace API.Configurations
{
    public static class RepositoryConfiguration
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}
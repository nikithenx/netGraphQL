using API.GraphQL.MutationTypes;
using API.GraphQL.QueryTypes;

namespace API.Configurations
{
    public static class GraphQLConfiguration
    {
        public static IServiceCollection RegisterGraphQLTypes(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType(q => q.Name("Query"))
                .AddType<AuthorQuery>()
                .AddType<BookQuery>()
                .AddMutationType(q => q.Name("Mutation"))
                .AddType<AuthorMutation>()
                .AddType<BookMutation>();

            return services;
        }
    }
}
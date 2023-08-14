using API.Contracts;
using API.Entities;

namespace API.GraphQL.QueryTypes
{
    public class AuthorQueryTypes
    {
        public async Task<IEnumerable<Author>> GetAuthorListAsync([Service] IAuthorRepository repo)
            => await repo.GetAllAsync();
    }
}
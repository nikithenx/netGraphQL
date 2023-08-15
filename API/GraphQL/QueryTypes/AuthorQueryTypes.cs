using API.Contracts;
using API.Entities;

namespace API.GraphQL.QueryTypes
{
    public class AuthorQueryTypes
    {
        public async Task<IEnumerable<Author>> GetAuthorsAsync([Service] IAuthorRepository repo)
            => await repo.GetAllAsync();

        public async Task<IEnumerable<Author>> GetAuthorsWithBooksAsync([Service] IAuthorRepository repo)
            => await repo.GetAllWithBooksAsync();

        public async Task<Author> GetAuthorAsync([Service] IAuthorRepository repo, string id)
            => await repo.GetByIdAsync(id);
    }
}
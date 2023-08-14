using API.Contracts;
using API.Entities;

namespace API.MutationTypes
{
    public class AuthorMutationTypes
    {
        public async Task<Author> CreateAuthor([Service] IAuthorRepository repo, Author author)
            => await repo.CreateAsync(author);
    }
}
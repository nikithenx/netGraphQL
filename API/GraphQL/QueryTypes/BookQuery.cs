using API.Contracts;
using API.Entities;

namespace API.GraphQL.QueryTypes
{
    [ExtendObjectType("Query")]
    public class BookQuery
    {
        public async Task<IEnumerable<Book>> GetBooksAsync([Service] IBookRepository repo)
            => await repo.GetAllAsync();

        public async Task<IEnumerable<Book>> GetByAuthorAsync([Service] IBookRepository repo, int authorId)
            => await repo.GetByAuthorAsync(authorId);

        public async Task<IEnumerable<Book>> GetByTitleAsync([Service] IBookRepository repo, 
            string title, StringComparison comparison, bool isEqual = true)
            => await repo.GetByTitleAsync(title, comparison, isEqual);
    }
}
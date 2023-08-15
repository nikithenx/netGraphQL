using API.Contracts;
using API.Entities;

namespace API.GraphQL.QueryTypes
{
    [ExtendObjectType("Query")]
    public class BookQuery
    {
        [UseProjection]
        public IQueryable<Book> GetBooks([Service] IBookRepository repo)
            => repo.GetAll();

        [UseProjection]
        public IQueryable<Book> GetBooksByAuthor([Service] IBookRepository repo, int authorId)
            => repo.GetByAuthor(authorId);

        [UseProjection]
        public IQueryable<Book> GetBooksByTitle([Service] IBookRepository repo, 
            string title, StringComparison comparison, bool isEqual = true)
            => repo.GetByTitle(title, comparison, isEqual);
    }
}
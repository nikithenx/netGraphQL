using API.Entities;

namespace API.Contracts
{
    public interface IBookRepository
    {
        Task<Book> CreateAsync(Book book);
        IQueryable<Book> GetAll();
        IQueryable<Book> GetByAuthor(int authorId);
        IQueryable<Book> GetByTitle(string title, StringComparison comparison, bool isEqual);
    }
}
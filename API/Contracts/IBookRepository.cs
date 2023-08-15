using API.Entities;

namespace API.Contracts
{
    public interface IBookRepository
    {
        Task<Book> CreateAsync(Book book);
        Task<IEnumerable<Book>> GetAllAsync();
        Task<IEnumerable<Book>> GetByAuthorAsync(int authorId);
        Task<IEnumerable<Book>> GetByTitleAsync(string title, StringComparison comparison, bool isEqual);
    }
}
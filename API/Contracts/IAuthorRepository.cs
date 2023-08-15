using API.Entities;

namespace API.Contracts
{
    public interface IAuthorRepository
    {
        Task<Author> CreateAsync(Author author);
        Task<IEnumerable<Author>> GetAllAsync();
        Task<IEnumerable<Author>> GetAllWithBooksAsync();
        Task<Author> GetByIdAsync(string id);
        Task<bool> UpdateAsync(Author author);
        Task<bool> DeleteAsync(int id);
    }
}
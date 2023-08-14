using API.Entities;

namespace API.Contracts
{
    public interface IAuthorRepository
    {
        Task<Author> CreateAsync(Author author);
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetByIdAsync(string id);
    }
}
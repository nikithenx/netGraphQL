using API.Entities;

namespace API.Contracts
{
    public interface IAuthorRepository
    {
        Task<Author> CreateAsync(Author author);
        IQueryable<Author> GetAll();
        IQueryable<Author> GetAllWithBooks();
        IQueryable<Author> GetById(string id);
        Task<bool> UpdateAsync(Author author);
        Task<bool> DeleteAsync(int id);
    }
}
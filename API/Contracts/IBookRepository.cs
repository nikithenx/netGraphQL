using API.Entities;

namespace API.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
    }
}
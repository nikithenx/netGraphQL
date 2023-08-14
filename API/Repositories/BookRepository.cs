using API.Contracts;
using API.Entities;

namespace API.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
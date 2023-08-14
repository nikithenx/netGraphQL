using API.Contracts;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _db;

        public AuthorRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Author> CreateAsync(Author author)
        {
            author.Guid = Guid.NewGuid().ToString();
            await _db.Authors.AddAsync(author);
            return await _db.SaveChangesAsync() > 0 ? author : null;
        }

        public async Task<IEnumerable<Author>> GetAllAsync() 
            => await _db.Authors.ToArrayAsync();

        public async Task<Author> GetByIdAsync(string id)
            => await _db.Authors.FirstOrDefaultAsync(x => x.Guid == id);
    }
}